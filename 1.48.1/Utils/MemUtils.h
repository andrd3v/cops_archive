class MemoryInfoI {
    public:
        uint32_t index;
        const mach_header *header;
        const char *name;
        intptr_t address;
};

MemoryInfoI getMemoryFileInfo(const char *fileName){
    MemoryInfoI _info;
    int imageCount = _dyld_image_count();

    for(int i = 0; i < imageCount; i++) {
        const char *name = _dyld_get_image_name(i);
        const mach_header *header = _dyld_get_image_header(i);
        if(!strstr(name, fileName)) continue;

        MemoryInfoI new_info = {
            static_cast<uint32_t>(i), header, name, _dyld_get_image_vmaddr_slide(i)
        };

        _info = new_info;
    }
    return _info;
}

MemoryInfoI getBaseInfo(){
    MemoryInfoI _info = {
        0,
        _dyld_get_image_header(0),
        _dyld_get_image_name(0),
        _dyld_get_image_vmaddr_slide(0)
    };
    return _info;
}

uint64_t getRealOffset(uint64_t address, const char *fileName = _("UnityFramework")){
    MemoryInfoI info;
    if(fileName != NULL) info = getMemoryFileInfo(fileName);
    else info = getBaseInfo();
    if(info.address == 0) return 0;
    return info.address + address;
}