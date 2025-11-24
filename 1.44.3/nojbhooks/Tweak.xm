#import "Macros.h"
#include <substrate.h>
#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>
#include <stdio.h>
#import "Offsets.h"
#import "Vector2.h"
#import "Vector3.h"

#import "dobby_defines.h"

#include <libgen.h>
#include <mach-o/fat.h>
#include <mach-o/loader.h>
#include <mach-o/dyld.h>
#include <mach/vm_page_size.h>
#include <Foundation/Foundation.h>
#include <map>
#include <deque>
#include <vector>
#include <array>
#include <mach/mach.h>
#include <mach/mach_traps.h>
#include <CoreFoundation/CoreFoundation.h>
#include <string>

#define DEBUG

#ifdef DEBUG
#define log(...) NSLog(__VA_ARGS__)
#else
#define log(...)
#endif

//HOOK BEGIN
#pragma GCC diagnostic ignored "-Warc-performSelector-leaks"
#pragma GCC diagnostic ignored "-Wunused-function"
#pragma GCC diagnostic ignored "-Wincomplete-implementation"
#pragma GCC diagnostic ignored "-Wdeprecated-declarations"
#pragma GCC diagnostic ignored "-W#warnings"
#pragma GCC diagnostic ignored "-Wunused-variable"
#pragma GCC diagnostic ignored "-Wformat"
#pragma GCC diagnostic ignored "-Wreorder"
#pragma GCC diagnostic ignored "-Wwritable-strings"
#pragma GCC diagnostic ignored "-Wtrigraphs"

#define STATIC_HOOK_CODEPAGE_SIZE PAGE_SIZE
#define STATIC_HOOK_DATAPAGE_SIZE PAGE_SIZE

// C++ version made by Lavochka

uint64_t va2rva(struct mach_header_64* header, uint64_t va)
{
    uint64_t rva = va;
    
    uint64_t header_vaddr = -1;
    struct load_command* lc = (struct load_command*)((UInt64)header + sizeof(*header));
    for (int i = 0; i < header->ncmds; i++) {
        
        if (lc->cmd == LC_SEGMENT_64)
        {
            struct segment_command_64 * seg = (struct segment_command_64 *)lc;
            
            if(seg->fileoff==0 && seg->filesize>0)
            {
                if(header_vaddr != -1) {
                    log(@"multi header mapping! %s", seg->segname);
                    return 0;
                }
                header_vaddr = seg->vmaddr;
            }
        }
        
        lc = (struct load_command *) ((char *)lc + lc->cmdsize);
    }
    
    if(header_vaddr != -1) {
        //log(@"header_vaddr=%p", header_vaddr);
        rva -= header_vaddr;
    }
    
    //log(@"va2rva %p=>%p", va, rva);
    
    return rva;
}
// C++ version made by Lavochka
void* rva2data(struct mach_header_64* header, uint64_t rva)
{
    uint64_t header_vaddr = -1;
    struct load_command* lc = (struct load_command*)((UInt64)header + sizeof(*header));
    for (int i = 0; i < header->ncmds; i++) {
        
        if (lc->cmd == LC_SEGMENT_64)
        {
            struct segment_command_64 * seg = (struct segment_command_64 *)lc;
            
            if(seg->fileoff==0 && seg->filesize>0)
            {
                if(header_vaddr != -1) {
                    log(@"multi header mapping! %s", seg->segname);
                    return NULL;
                }
                header_vaddr = seg->vmaddr;
            }
        }
        
        lc = (struct load_command *) ((char *)lc + lc->cmdsize);
    }
    
    if(header_vaddr != -1) {
        log(@"header_vaddr=%p", header_vaddr);
        rva += header_vaddr;
    }
    
    //struct load_command*
    lc = (struct load_command*)((UInt64)header + sizeof(*header));
    for (int i = 0; i < header->ncmds; i++) {

        if (lc->cmd == LC_SEGMENT_64)
        {
            struct segment_command_64 * seg = (struct segment_command_64 *) lc;
            
            uint64_t seg_vmaddr_start = seg->vmaddr;
            uint64_t seg_vmaddr_end   = seg_vmaddr_start + seg->vmsize;
            if ((uint64_t)rva >= seg_vmaddr_start && (uint64_t)rva < seg_vmaddr_end)
            {
              // some section like '__bss', '__common'
              uint64_t offset = (uint64_t)rva - seg_vmaddr_start;
              if (offset > seg->filesize) {
                return NULL;
              }
                
              log(@"vaddr=%p offset=%p\n", rva, seg->fileoff + offset);
              return (void*)((uint64_t)header + seg->fileoff + offset);
            }
        }

        lc = (struct load_command *) ((char *)lc + lc->cmdsize);
    }
    
    return NULL;
}

// C++ version made by Lavochka
NSMutableData* load_macho_data(NSString* path)
{
    NSMutableData* macho = [NSMutableData dataWithContentsOfFile:path];
    if(!macho) return nil;
    
    UInt32 magic = *(uint32_t*)macho.mutableBytes;
    if(magic==FAT_CIGAM)
    {
        struct fat_header* fathdr = (struct fat_header*)macho.mutableBytes;
        struct fat_arch* archdr = (struct fat_arch*)((UInt64)fathdr + sizeof(*fathdr));
        log(@"add_hook_section nfat_arch=%d", NXSwapLong(fathdr->nfat_arch));
        if(NXSwapLong(fathdr->nfat_arch) != 1) {
            log(@"macho has too many arch!");
            return nil;
        }
        
        if(NXSwapLong(archdr->cputype) != CPU_TYPE_ARM64 || archdr->cpusubtype!=0) {
            log(@"macho arch not support!");
            return nil;
        }
        log(@"subarch=%x %x", NXSwapLong(archdr->offset), NXSwapLong(archdr->size));
        macho = [NSMutableData dataWithData:
                 [macho subdataWithRange:NSMakeRange(NXSwapLong(archdr->offset), NXSwapLong(archdr->size))]];
        
    } else if(magic==FAT_CIGAM_64)
    {
        struct fat_header* fathdr = (struct fat_header*)macho.mutableBytes;
        struct fat_arch_64* archdr = (struct fat_arch_64*)((UInt64)fathdr + sizeof(*fathdr));
        log(@"macho nfat_arch=%d", NXSwapLong(fathdr->nfat_arch));
        if(NXSwapLong(fathdr->nfat_arch) != 1) {
            log(@"macho has too many arch!");
            return nil;
        }
        
        if(NXSwapLong(archdr->cputype) != CPU_TYPE_ARM64 || archdr->cpusubtype!=0) {
            log(@"macho arch not support!");
            return nil;
        }
        log(@"subarch=%x %x", NXSwapLong(archdr->offset), NXSwapLong(archdr->size));
        macho = [NSMutableData dataWithData:
                 [macho subdataWithRange:NSMakeRange(NXSwapLong(archdr->offset), NXSwapLong(archdr->size))]];
        
    } else if(magic != MH_MAGIC_64) {
        log(@"macho arch not support!");
        return nil;
    }
    
    return macho;
}

NSMutableData* add_hook_section(NSMutableData* macho)
{
    struct mach_header_64* header = (struct mach_header_64*)macho.mutableBytes;
    log(@"macho %x %x", header->magic, macho.length);
    
    uint64_t vm_end = 0;
    uint64_t min_section_offset = 0;
    struct segment_command_64* linkedit_seg = NULL;
    
    struct load_command* lc = (struct load_command*)((UInt64)header + sizeof(*header));
    for (int i = 0; i < header->ncmds; i++) {
        log(@"macho load cmd=%d", lc->cmd);
        
        if (lc->cmd == LC_SEGMENT_64)
        {
            struct segment_command_64 * seg = (struct segment_command_64 *) lc;
            
            log(@"segment: %s file=%x:%x vm=%p:%p\n", seg->segname, seg->fileoff, seg->filesize, seg->vmaddr, seg->vmsize);
            
            if(strcmp(seg->segname,SEG_LINKEDIT)==0)
                linkedit_seg = seg;
            else
            if(seg->vmsize && vm_end<(seg->vmaddr+seg->vmsize))
                vm_end = seg->vmaddr+seg->vmsize;
            
            struct section_64* sec = (struct section_64*)((uint64_t)seg+sizeof(*seg));
            for(int j=0; j<seg->nsects; j++)
            {
                log(@"section[%d] = %s/%s offset=%x vm=%p:%p", j, sec[j].segname, sec[j].sectname,
                      sec[j].offset, sec[j].addr, sec[j].size);
                
                if(min_section_offset < sec[j].offset)
                    min_section_offset = sec[j].offset;
            }
        }
        
        lc = (struct load_command *) ((char *)lc + lc->cmdsize);
    }
    
    if(!min_section_offset || !vm_end || !linkedit_seg) {
        log(@"cannot parse macho file!");
        return nil;
    }
    
    log(@"min_section_offset=%x vm_end=%p", min_section_offset, vm_end);
    
    NSRange linkedit_range = NSMakeRange(linkedit_seg->fileoff, linkedit_seg->filesize);
    NSData* linkedit_data = [macho subdataWithRange:linkedit_range];
    [macho replaceBytesInRange:linkedit_range withBytes:nil length:0];
    
    
    struct segment_command_64 text_seg = {
        .cmd = LC_SEGMENT_64,
        .cmdsize=sizeof(struct segment_command_64)+sizeof(struct section_64),
        .segname = {"__HOOK_TEXT"},
        .vmaddr = vm_end,
        .vmsize = STATIC_HOOK_CODEPAGE_SIZE,
        .fileoff = macho.length,
        .filesize = STATIC_HOOK_CODEPAGE_SIZE,
        .maxprot = VM_PROT_READ|VM_PROT_EXECUTE,
        .initprot = VM_PROT_READ|VM_PROT_EXECUTE,
        .nsects = 1,
        .flags = 0
    };
    struct section_64 text_sec = {
        .segname = {"__HOOK_TEXT"},
        .sectname = {"__hook_text"},
        .addr = text_seg.vmaddr,
        .size = text_seg.vmsize,
        .offset = (uint32_t)text_seg.fileoff,
        .align = 0,
        .reloff = 0,
        .nreloc = 0,
        .flags = S_ATTR_PURE_INSTRUCTIONS|S_ATTR_SOME_INSTRUCTIONS,
        .reserved1 = 0, .reserved2 = 0, .reserved3 = 0
    };
    
    struct segment_command_64 data_seg = {
        .cmd = LC_SEGMENT_64,
        .cmdsize=sizeof(struct segment_command_64)+sizeof(struct section_64),
        .segname = {"__HOOK_DATA"},
        .vmaddr = text_seg.vmaddr+text_seg.vmsize,
        .vmsize = STATIC_HOOK_CODEPAGE_SIZE,
        .fileoff = text_seg.fileoff+text_seg.filesize,
        .filesize = STATIC_HOOK_CODEPAGE_SIZE,
        .maxprot = VM_PROT_READ|VM_PROT_WRITE,
        .initprot = VM_PROT_READ|VM_PROT_WRITE,
        .nsects = 1,
        .flags = 0
    };
    struct section_64 data_sec = {
        .segname = {"__HOOK_DATA"},
        .sectname = {"__hook_data"},
        .addr = data_seg.vmaddr,
        .size = data_seg.vmsize,
        .offset = (uint32_t)data_seg.fileoff,
        .align = 0,
        .reloff = 0,
        .nreloc = 0,
        .flags = 0, //S_ZEROFILL,
        .reserved1 = 0, .reserved2 = 0, .reserved3 = 0
    };
    
    uint64_t linkedit_cmd_offset = (uint64_t)linkedit_seg - ((uint64_t)header+sizeof(*header));
    unsigned char* cmds = (unsigned char*)malloc(header->sizeofcmds);
    memcpy(cmds, (unsigned char*)header+sizeof(*header), header->sizeofcmds);
    unsigned char* patch = (unsigned char*)header +sizeof(*header) + linkedit_cmd_offset;
    
    memcpy(patch, &text_seg, sizeof(text_seg));
    patch += sizeof(text_seg);
    memcpy(patch, &text_sec, sizeof(text_sec));
    patch += sizeof(text_sec);

    memcpy(patch, &data_seg, sizeof(data_seg));
    patch += sizeof(data_seg);
    memcpy(patch, &data_sec, sizeof(data_sec));
    patch += sizeof(data_sec);
    
    memcpy(patch, cmds+linkedit_cmd_offset, header->sizeofcmds-linkedit_cmd_offset);
    
    linkedit_seg = (struct segment_command_64*)patch;
    
    header->ncmds += 2;
    header->sizeofcmds += text_seg.cmdsize + data_seg.cmdsize;
    
    linkedit_seg->fileoff = macho.length+text_seg.filesize+data_seg.filesize;
    linkedit_seg->vmaddr = vm_end+text_seg.vmsize+data_seg.vmsize;
    // C++ version made by Lavochka
    // fix load_command
    struct load_command *load_cmd = (struct load_command *)((uint64_t)header + sizeof(*header));
    for (int i = 0; i < header->ncmds;
         i++, load_cmd = (struct load_command *)((uint64_t)load_cmd + load_cmd->cmdsize))
    {
        uint64_t fixoffset = text_seg.filesize+data_seg.filesize;// + linkedit_seg->filesize;
        
      switch (load_cmd->cmd)
      {
          case LC_DYLD_INFO:
          case LC_DYLD_INFO_ONLY:
          {
            struct dyld_info_command *tmp = (struct dyld_info_command *)load_cmd;
            tmp->rebase_off += fixoffset;
            tmp->bind_off += fixoffset;
            if (tmp->weak_bind_off)
              tmp->weak_bind_off += fixoffset;
            if (tmp->lazy_bind_off)
              tmp->lazy_bind_off += fixoffset;
            if (tmp->export_off)
              tmp->export_off += fixoffset;
            log(@"[-] fix LC_DYLD_INFO_ done\n");
          } break;
              
          case LC_SYMTAB:
          {
            struct symtab_command *tmp = (struct symtab_command *)load_cmd;
            if (tmp->symoff)
              tmp->symoff += fixoffset;
            if (tmp->stroff)
              tmp->stroff += fixoffset;
            log(@"[-] fix LC_SYMTAB done\n");
          } break;
              
          case LC_DYSYMTAB:
          {
            struct dysymtab_command *tmp = (struct dysymtab_command *)load_cmd;
            if (tmp->tocoff)
              tmp->tocoff += fixoffset;
            if (tmp->modtaboff)
              tmp->modtaboff += fixoffset;
            if (tmp->extrefsymoff)
              tmp->extrefsymoff += fixoffset;
            if (tmp->indirectsymoff)
              tmp->indirectsymoff += fixoffset;
            if (tmp->extreloff)
              tmp->extreloff += fixoffset;
            if (tmp->locreloff)
              tmp->locreloff += fixoffset;
            log(@"[-] fix LC_DYSYMTAB done\n");
          } break;
              
          case LC_FUNCTION_STARTS:
          case LC_DATA_IN_CODE:
          case LC_CODE_SIGNATURE:
          case LC_SEGMENT_SPLIT_INFO:
          case LC_DYLIB_CODE_SIGN_DRS:
          case LC_LINKER_OPTIMIZATION_HINT:
          case LC_DYLD_EXPORTS_TRIE:
          case LC_DYLD_CHAINED_FIXUPS:
          {
            struct linkedit_data_command *tmp = (struct linkedit_data_command *)load_cmd;
            if (tmp->dataoff) tmp->dataoff += fixoffset;
            log(@"[-] fix linkedit_data_command done\n");
          } break;
      }
    }
    
    if(min_section_offset < (sizeof(struct mach_header_64)+header->sizeofcmds)) {
        log(@"macho header has no enough space!");
        return nil;
    }
    
    unsigned char* codepage = (unsigned char*)malloc(text_seg.vmsize);
    memset(codepage, 0xFF, text_seg.vmsize);
    [macho appendBytes:codepage length:text_seg.vmsize];
    free(codepage);
    
    unsigned char* datapage = (unsigned char*)malloc(data_seg.vmsize);
    memset(datapage, 0, data_seg.vmsize);
    //for(int i=0;i<data_seg.vmsize;i++) datapage[i]=i;
    [macho appendBytes:datapage length:data_seg.vmsize];
    free(datapage);
    
    [macho appendData:linkedit_data];
    
    log(@"macho file size=%x", macho.length);
    
    return macho;
}

bool hex2bytes(char* bytes, unsigned char* buffer)
{
    size_t len=strlen(bytes);
    for(int i=0; i<len; i++) {
        char _byte = bytes[i];
        if(_byte>='0' && _byte<='9')
            _byte -= '0';
        else if(_byte>='a' && _byte<='f')
            _byte -= 'a'-10;
        else if(_byte>='A' && _byte<='F')
            _byte -= 'A'-10;
        else
            return false;
        
        buffer[i/2] &= (i+1)%2 ? 0x0F : 0xF0;
        buffer[i/2] |= _byte << (((i+1)%2)*4);
        
    }
    return true;
}

uint64_t calc_patch_hash(uint64_t vaddr, char* patch)
{
    return [[[NSString stringWithUTF8String:patch] lowercaseString] hash] ^ vaddr;
}

NSString* StaticInlineHookPatch(char* machoPath, uint64_t vaddr, char* patch)
{
    static NSMutableDictionary* gStaticInlineHookMachO = [[NSMutableDictionary alloc] init];
    
    NSString* path = [NSBundle.mainBundle.bundlePath stringByAppendingPathComponent:[NSString stringWithUTF8String:machoPath]];
        
    NSString* newPath = gStaticInlineHookMachO[path];
    
    NSMutableData* macho=nil;

    if(newPath) {
        macho = load_macho_data(newPath);
        if(!macho) return [NSString stringWithFormat:@"?????(can't find file):\n Documents/static-inline-hook/%s", machoPath];
    } else {
        macho = load_macho_data(path);
        if(!macho) return [NSString stringWithFormat:@"??????(can't read file):\n.app/%s", machoPath];
    }
    
    uint32_t cryptid = 0;
    struct mach_header_64* header = NULL;
    struct segment_command_64* text_seg = NULL;
    struct segment_command_64* data_seg = NULL;
    
    while(true) {
        
        header = (struct mach_header_64*)macho.mutableBytes;
        log(@"macho %x %x", header->magic, macho.length);
        
        struct load_command* lc = (struct load_command*)((UInt64)header + sizeof(*header));
        for (int i = 0; i < header->ncmds; i++) {
            if (lc->cmd == LC_SEGMENT_64) {
                struct segment_command_64 * seg = (struct segment_command_64 *) lc;
                if(strcmp(seg->segname,"__HOOK_TEXT")==0)
                    text_seg = seg;
                if(strcmp(seg->segname,"__HOOK_DATA")==0)
                    data_seg = seg;
            }
            if(lc->cmd == LC_ENCRYPTION_INFO_64) {
                struct encryption_info_command_64* info = (struct encryption_info_command_64*)lc;
                if(cryptid==0) cryptid = info->cryptid;
            }
            lc = (struct load_command *) ((char *)lc + lc->cmdsize);
        }
        
        if(text_seg && data_seg) {
            log(@"hook section found!");
            break;
        }
        
        macho = add_hook_section(macho);
        if(!macho) {
            return @"add_hook_section error!";
        }
    }
    
    if(cryptid != 0) {
        return @"?app?????!\nthis app is not decrypted!";
    }
    
    if(!text_seg || !data_seg) {
        return @"????machO??!\ncan not parse machO file!";
    }
    
    uint64_t funcRVA = vaddr & ~(4-1);
    void *funcData = rva2data(header, funcRVA);
    //*(uint32_t*)funcData = 0x58000020; //ldr x0, #4 test
    
    if(!funcData) {
        return @"?????!\nInvalid offset!";
    }
    
    // C++ version made by Lavochka
    void* patch_bytes=NULL; uint64_t patch_size=0;
    
    if(patch && patch[0]) {
        uint64_t patch_end = vaddr + (strlen(patch)+1)/2;
        uint64_t code_end = (patch_end+4-1) & ~(4-1);
        
        patch_size = code_end - funcRVA;
        
        log(@"codepath %p %s : %p~%p~%p %x", vaddr, patch, funcRVA, patch_end, code_end, patch_size);
        
        NSMutableData* patchBytes = [[NSMutableData alloc] initWithLength:patch_size];
        patch_bytes = patchBytes.mutableBytes;
        
        memcpy(patch_bytes, funcData, patch_size);
        
        if(!hex2bytes(patch, (uint8_t*)patch_bytes+vaddr%4))
            return @"?????????!\nThe bytes to patch are incorrect!";

    } else if(vaddr % 4) {
        return @"?????!\nThe offset is not aligned!";
    }
    
    
    uint64_t targetRVA = va2rva(header, text_seg->vmaddr);
    void* targetData = rva2data(header, targetRVA);
    
    
    uint64_t InstrumentBridgeRVA = targetRVA;
    
    uint64_t dataRVA = va2rva(header, data_seg->vmaddr);
    void* dataData = rva2data(header, dataRVA);
    
    StaticInlineHookBlock* hookBlock = (StaticInlineHookBlock*)dataData;
    StaticInlineHookBlock* hookBlockRVA = NULL;
    for(int i=0; i<STATIC_HOOK_CODEPAGE_SIZE/sizeof(StaticInlineHookBlock); i++)
    {
        if(hookBlock[i].hook_vaddr==funcRVA)
        {
            if(patch && patch[0] && hookBlock[i].patch_hash!=calc_patch_hash(vaddr, patch))
                return @"????????, ??????????!\nThe bytes to patch have changed, please revert to original file and try again";
            
            if(newPath)
                return @"??????, ??APP?Documents/static-inline-hook???????????ipa??.app?????????!\nThe offset is already patched! Please replace the patched file in the APP's Documents/static-inline-hook directory to the .app directory in the ipa and re-sign and reinstall!";
            
            return @"?HOOK?????!\nThe offset to hook is already patched!";
        }
        
        if( funcRVA>hookBlock[i].hook_vaddr &&
           ( funcRVA < (hookBlock[i].hook_vaddr+hookBlock[i].hook_size) || funcRVA < (hookBlock[i].hook_vaddr+hookBlock[i].patch_size) )
          ) {
            return @"???????!\nThe offset is occupied!";
        }
        
        if(hookBlock[i].hook_vaddr==0)
        {
            hookBlock = &hookBlock[i];
            hookBlockRVA = (StaticInlineHookBlock*)(dataRVA + i*sizeof(StaticInlineHookBlock));
            
            if(i == 0)
            {
                int codesize = dobby_create_instrument_bridge(targetData);
                
                targetRVA += codesize;
                *(uint64_t*)&targetData += codesize;
            }
            else
            {
                StaticInlineHookBlock* lastBlock = hookBlock - 1;
                targetRVA = lastBlock->code_vaddr + lastBlock->code_size;
                targetData = rva2data(header, targetRVA);
            }
            
            log(@"found empty StaticInlineHookBlock %d %p=>%p\n", i, targetRVA, targetData);
            
            break;
        }
    }
    if(!hookBlockRVA) {
        return @"????????!\nHOOK count full!";
    }
    
    log(@"func: %p=>%p target: %p=>%p\n", funcRVA, funcData, targetRVA, targetData);
    
    if(!dobby_static_inline_hook(hookBlock, hookBlockRVA, funcRVA, funcData, targetRVA, targetData,
                                 InstrumentBridgeRVA, patch_bytes, patch_size))
    {
        return @"???????!\ncan not patch the offset";
    }
    
    if(patch && patch[0]) {
        hookBlock->patch_size = patch_size;
        hookBlock->patch_hash = calc_patch_hash(vaddr, patch);
    }
    

    NSString* savePath = [NSString stringWithFormat:@"%@/Documents/static-inline-hook/%s", NSHomeDirectory(), machoPath];
    [NSFileManager.defaultManager createDirectoryAtPath:[NSString stringWithUTF8String:dirname((char*)savePath.UTF8String)] withIntermediateDirectories:YES attributes:nil error:nil];
    
    if(![macho writeToFile:savePath atomically:NO])
        return @"??????!\ncan not write to file!";
    
    gStaticInlineHookMachO[path] = savePath;
    return @"??????, ????????APP?Documents/static-inline-hook???, ?????????????ipa??.app?????????!\nThe offset has not been patched, the patched file will be generated in the Documents/static-inline-hook directory of the APP, please replace all the files in this directory to the .app directory in the ipa and re-sign and reinstall!";
}



// C++ version made by Lavochka
void* find_module_by_path(char* machoPath)
{
    NSString* path = [NSBundle.mainBundle.bundlePath stringByAppendingPathComponent:[NSString stringWithUTF8String:machoPath]];
    
    for(int i=0; i< _dyld_image_count(); i++) {

        const char* fpath = _dyld_get_image_name(i);
        void* baseaddr = (void*)_dyld_get_image_header(i);
        void* slide = (void*)_dyld_get_image_vmaddr_slide(i); //no use
        
        if([path isEqualToString:[NSString stringWithUTF8String:fpath]])
            return baseaddr;
    }
    
    return NULL;
}

StaticInlineHookBlock* find_hook_block(void* base, uint64_t vaddr)
{
    struct segment_command_64* text_seg = NULL;
    struct segment_command_64* data_seg = NULL;
    
    struct mach_header_64* header = (struct mach_header_64*)base;
    
    struct load_command* lc = (struct load_command*)((UInt64)header + sizeof(*header));
    for (int i = 0; i < header->ncmds; i++) {
        if (lc->cmd == LC_SEGMENT_64) {
            struct segment_command_64 * seg = (struct segment_command_64 *) lc;
            if(strcmp(seg->segname,"__HOOK_TEXT")==0)
                text_seg = seg;
            if(strcmp(seg->segname,"__HOOK_DATA")==0)
                data_seg = seg;
        }
        lc = (struct load_command *) ((char *)lc + lc->cmdsize);
    }
    
    if(!text_seg || !data_seg) {
        NSLog(@"cannot parse hook info!");
        return NULL;
    }
    
    StaticInlineHookBlock* hookBlock = (StaticInlineHookBlock*)((uint64_t)header + va2rva(header, data_seg->vmaddr));
    for(int i=0; i<STATIC_HOOK_CODEPAGE_SIZE/sizeof(StaticInlineHookBlock); i++)
    {
        if(hookBlock[i].hook_vaddr == (uint64_t)vaddr)
        {
            NSLog(@"found hook block %d for %llX", i, vaddr);
            return &hookBlock[i];
        }
    }
    
    return NULL;
}

void* StaticInlineHookFunction(char* machoPath, uint64_t vaddr, void* replace)
{
    void* base = find_module_by_path(machoPath);
    if(!base) {
        log(@"cannot find module!");
        return NULL;
    }
    
    StaticInlineHookBlock* hookBlock = find_hook_block(base, vaddr);
    if(!hookBlock) {
        log(@"cannot find hook block!");
        return NULL;
    }
    
    hookBlock->target_replace = replace;
    return (void*)((uint64_t)base + hookBlock->original_vaddr);
}


BOOL ActiveCodePatch(char* machoPath, uint64_t vaddr, char* patch)
{
    void* base = find_module_by_path(machoPath);
    if(!base) {
        //NSLog(@"cannot find module!");
        NSLog(@"%p cannot find module!", (void *)vaddr);
        return NO;
    }
    
    StaticInlineHookBlock* hookBlock = find_hook_block(base, vaddr&~3);
    if(!hookBlock) {
        // NSLog(@"cannot find hook block!");
        NSLog(@"%p cannot find hook block!", (void *)vaddr);
        return NO;
    }
    
    if(hookBlock->patch_hash != calc_patch_hash(vaddr, patch)) {
        // NSLog(@"code patch bytes changed!");
        NSLog(@"%p code patch bytes changed!", (void *)vaddr);
        return NO;
    }
    
    hookBlock->target_replace = (void*)((uint64_t)base + hookBlock->patched_vaddr);
    
    return YES;
}

BOOL DeactiveCodePatch(char* machoPath, uint64_t vaddr, char* patch)
{
    void* base = find_module_by_path(machoPath);
    if(!base) {
        //NSLog(@"cannot find module!");
        NSLog(@"%p cannot find hook block!", (void *)vaddr);
        return NO;
    }
    
    StaticInlineHookBlock* hookBlock = find_hook_block(base, vaddr&~3);
    if(!hookBlock) {
        //NSLog(@"cannot find hook block!");
        NSLog(@"%p cannot find module!", (void *)vaddr);
        return NO;
    }
    
    if(hookBlock->patch_hash != calc_patch_hash(vaddr, patch)) {
        //NSLog(@"code patch bytes changed!");
        NSLog(@"%p code patch bytes changed!", (void *)vaddr);
        return NO;
    }
    
    hookBlock->target_replace = NULL;
    
    return YES;
}

#define HOOK(x, y, z) \
NSString* result_##y = StaticInlineHookPatch(("Frameworks/UnityFramework.framework/UnityFramework"), x, nullptr); \
if (result_##y) { \
    log(@"Hook result: %s", result_##y.UTF8String); \
    void* result = StaticInlineHookFunction(("Frameworks/UnityFramework.framework/UnityFramework"), x, (void *) y); \
    log(@"Hook result %p", result); \
    *(void **) (&z) = (void*) result; \
}



bool getType(unsigned int data) {
    int a = data & 0xffff8000;
    int b = a + 0x00008000;
    int c = b & 0xffff7fff;
    return c;
}


//Patching section, I just copy and paste it from KittyMemory of Ted2 mod menu cuz I'm lazy :D
struct MemoryFileInfo {
    uint32_t index;
    const struct mach_header *header;
    const char *name;
    long long address;
};

MemoryFileInfo getBaseInfo() {
    MemoryFileInfo _info;
    std::string applicationsPath = "/private/var/containers/Bundle/Application";
    for (uint32_t i = 0; i < _dyld_image_count(); i++)
    {
        const char *name = _dyld_get_image_name(i);
        if (!name) continue;
        std::string fullpath(name);
        if (strncmp(fullpath.c_str(), applicationsPath.c_str(), applicationsPath.size()) == 0)
        {
            _info.index = i;
            _info.header = _dyld_get_image_header(i);
            _info.name = _dyld_get_image_name(i);
            _info.address = _dyld_get_image_vmaddr_slide(i);
            break;
        }
    }
    return _info;
}

MemoryFileInfo getMemoryFileInfo(const std::string& fileName) {
    MemoryFileInfo _info;
    const uint32_t imageCount = _dyld_image_count();
    for (uint32_t i = 0; i < imageCount; i++) {
        const char *name = _dyld_get_image_name(i);
        if (!name)
            continue;
        std::string fullpath(name);
        if (fullpath.length() < fileName.length() || fullpath.compare(fullpath.length() - fileName.length(), fileName.length(), fileName) != 0)
            continue;
        _info.index = i;
        _info.header = _dyld_get_image_header(i);
        _info.name = _dyld_get_image_name(i);
        _info.address = _dyld_get_image_vmaddr_slide(i);
        break;
    }
    return _info;
}

uintptr_t getAbsoluteAddress(const char *fileName, uintptr_t address) {
    MemoryFileInfo info;
    if (fileName)
        info = getMemoryFileInfo(fileName);
    else
        info = getBaseInfo();
    if (info.address == 0)
        return 0;
    return info.address + address;
}

//change getRealOffset to another framework if you want, or NULL
uint64_t getRealOffset(uint64_t offset){
    return getAbsoluteAddress("UnityFramework", offset);
}




























using vec3 = Vector3;
void *(*get_transform)(void *);
vec3 (*get_position)(void *);
void *(*get_main)();
vec3 (*WorldToViewportPoint)(void *, vec3, int);
float (*get_fieldOfView)(void *);

vec3 GetObjectLocation(void *object)
{
    return get_position(get_transform(object));
}


vec3 WorldToScreen(vec3 object)
{
    
    vec3 position = WorldToViewportPoint(get_main(), object, 2);

    vec3 location;
    location.x = ScreenWidth * position.x;
    location.y = ScreenHeight - position.y * ScreenHeight;
    location.z = position.z;

    if (location.x > 0 && location.y > 0 && location.z > 0)
    return location;
    return {0, 0, 0};
}


struct player_t
{
    void *object;
    vec3 position;
    vec3 w2sposition;
}*player;





void (*old_player_update)(void *instance, float deltaTime);
void new_player_update(void *instance, float deltaTime)
{
    [esp setNeedsDisplay];
    
    
    if(instance)
    {

        player->object = instance;
        player->position = GetObjectLocation(player->object);
        player->w2sposition = WorldToScreen(player->position);
    
        float EnemyHeight = 4100 / (player->w2sposition.z / 4) / (get_fieldOfView(get_main()) / 2);
        float EnemyWidth = 840 / (player->w2sposition.z / 4) / (get_fieldOfView(get_main()) / 4);
        

        float EnemyCoordX = player->w2sposition.x - EnemyWidth / 2;
        float EnemyCoordY = player->w2sposition.y - EnemyHeight;

        if ([switches isSwitchOn:NSSENCRYPT("Enemy Line")])
        {
            [esp addEnemyLine:(EnemyCoordX + EnemyWidth / 2) y:EnemyCoordY];
        }
        if ([switches isSwitchOn:NSSENCRYPT("Enemy Box")])
        {
            [esp addEnemyBox:EnemyCoordX y:EnemyCoordY w:EnemyWidth h:EnemyHeight];
        }

        if ([switches isSwitchOn:NSSENCRYPT("Enemy Bounds")])
        {
            [esp addEnemyBounds:EnemyCoordX y:EnemyCoordY w:EnemyWidth h:EnemyHeight];
        }
    }
    
    old_player_update(instance, deltaTime);
}






void setup() {
    
    player = new player_t();
    
    
    HOOK(updatehookfset, new_player_update, old_player_update);
    
    
    *(void **)&get_transform = (void *)getRealOffset(get_transformofset);
    *(void **)&get_position = (void *)getRealOffset(get_positionofset);
    *(void **)&get_main = (void *)getRealOffset(get_mainofset);
    *(void **)&WorldToViewportPoint = (void *)getRealOffset(WorldToViewportPointofset);
    *(void **)&get_fieldOfView = (void *) getRealOffset(get_fieldOfViewofset);

    [switches addSwitch3:NSSENCRYPT("Enemy Line") description:nil];
    [switches addSwitch3:NSSENCRYPT("Enemy Box") description:nil];
    [switches addSwitch3:NSSENCRYPT("Enemy Healthbar") description:nil];
    [switches addSwitch3:NSSENCRYPT("Enemy Bounds") description:nil];

    [switches addSwitch4:NSSENCRYPT("offscreen") description:nil];

}


void setupMenu() {

    [menu setFrameworkName:"UnityFramework"];

    menu = [[Menu alloc]  initWithTitle:@"c-ops no-jb hack"
        titleColor:[UIColor blackColor]
        titleFont:@"Avenir-Black"
        credits:@""
        headerColor:[UIColor whiteColor]
        switchOffColor:[UIColor blackColor]
        switchOnColor:[UIColor colorWithRed:1.0 green:0.35 blue:0.0 alpha:0.60]
        switchTitleFont:@"Avenir-Black"
        switchTitleColor:[UIColor whiteColor]
        infoButtonColor:[UIColor blackColor]
        maxVisibleSwitches:5
        menuWidth:430
        menuIcon:@"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"
        menuButton:@""
    ];
    
    
    espWindow = [UIApplication sharedApplication].keyWindow;
    TextFieldView *textFieldView = [[TextFieldView alloc] initWithFrame:CGRectMake(0, 0, 0, 0)];
    textFieldView.userInteractionEnabled = NO;
    textFieldView.backgroundColor = [UIColor clearColor];
    esp = [[CGView alloc] initWithFrame:espWindow];
    
    if([switches isSwitchOn:@"offscreen"])
    [espWindow addSubview:menu];
    [textFieldView addSubview:esp];
    [espWindow addSubview:textFieldView];
    
    
    
    
    setup();
    
    
    


}

static void didFinishLaunching(CFNotificationCenterRef center, void *observer, CFStringRef name, const void *object, CFDictionaryRef info) {

timer(3) {
setupMenu();
});
}



%ctor {

  CFNotificationCenterAddObserver(CFNotificationCenterGetLocalCenter(), NULL, &didFinishLaunching, (CFStringRef)UIApplicationDidFinishLaunchingNotification, NULL, CFNotificationSuspensionBehaviorDeliverImmediately);

}
