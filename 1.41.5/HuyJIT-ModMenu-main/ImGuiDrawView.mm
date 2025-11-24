//Require standard library
#import <Metal/Metal.h>
#import <MetalKit/MetalKit.h>
#import <Foundation/Foundation.h>
//Imgui library
#import "Esp/CaptainHook.h"
#import "Esp/ImGuiDrawView.h"
#import "IMGUI/imgui.h"
#import "IMGUI/imgui_impl_metal.h"
#import "IMGUI/Honkai.h"
//Patch library
#import "5Toubun/NakanoIchika.h"
#import "5Toubun/NakanoNino.h"
#import "5Toubun/NakanoMiku.h"
#import "5Toubun/NakanoYotsuba.h"
#import "5Toubun/NakanoItsuki.h"
#import "5Toubun/dobby.h"
#include "Macros.h"

#define kWidth  [UIScreen mainScreen].bounds.size.width
#define kHeight [UIScreen mainScreen].bounds.size.height
#define kScale [UIScreen mainScreen].scale

@interface ImGuiDrawView () <MTKViewDelegate>
@property (nonatomic, strong) id <MTLDevice> device;
@property (nonatomic, strong) id <MTLCommandQueue> commandQueue;
@end

@implementation ImGuiDrawView

//I usually let the function for hooking in here...
void (*huy)(void *instance);
void _huy(void *instance)
{
huy(instance);
}

static bool MenDeal = true;


- (instancetype)initWithNibName:(nullable NSString *)nibNameOrNil bundle:(nullable NSBundle *)nibBundleOrNil
{
    self = [super initWithNibName:nibNameOrNil bundle:nibBundleOrNil];

    _device = MTLCreateSystemDefaultDevice();
    _commandQueue = [_device newCommandQueue];

    if (!self.device) abort();

    IMGUI_CHECKVERSION();
    ImGui::CreateContext();
    ImGuiIO& io = ImGui::GetIO(); (void)io;

    ImGui::StyleColorsClassic();
    
    ImFont* font = io.Fonts->AddFontFromMemoryCompressedTTF((void*)Honkai_compressed_data, Honkai_compressed_size, 45.0f, NULL, io.Fonts->GetGlyphRangesDefault());
    
    ImGui_ImplMetal_Init(_device);

    return self;
}

+ (void)showChange:(BOOL)open
{
    MenDeal = open;
}

- (MTKView *)mtkView
{
    return (MTKView *)self.view;
}

- (void)loadView
{

 

    CGFloat w = [UIApplication sharedApplication].windows[0].rootViewController.view.frame.size.width;
    CGFloat h = [UIApplication sharedApplication].windows[0].rootViewController.view.frame.size.height;
    self.view = [[MTKView alloc] initWithFrame:CGRectMake(0, 0, w, h)];
}

- (void)viewDidLoad {
    [super viewDidLoad];
    
    self.mtkView.device = self.device;
    self.mtkView.delegate = self;
    self.mtkView.clearColor = MTLClearColorMake(0, 0, 0, 0);
    self.mtkView.backgroundColor = [UIColor colorWithRed:0 green:0 blue:0 alpha:0];
    self.mtkView.clipsToBounds = YES;

}



#pragma mark - Interaction

- (void)updateIOWithTouchEvent:(UIEvent *)event
{
    UITouch *anyTouch = event.allTouches.anyObject;
    CGPoint touchLocation = [anyTouch locationInView:self.view];
    ImGuiIO &io = ImGui::GetIO();
    io.MousePos = ImVec2(touchLocation.x, touchLocation.y);

    BOOL hasActiveTouch = NO;
    for (UITouch *touch in event.allTouches)
    {
        if (touch.phase != UITouchPhaseEnded && touch.phase != UITouchPhaseCancelled)
        {
            hasActiveTouch = YES;
            break;
        }
    }
    io.MouseDown[0] = hasActiveTouch;
}

- (void)touchesBegan:(NSSet<UITouch *> *)touches withEvent:(UIEvent *)event
{
    [self updateIOWithTouchEvent:event];
}

- (void)touchesMoved:(NSSet<UITouch *> *)touches withEvent:(UIEvent *)event
{
    [self updateIOWithTouchEvent:event];
}

- (void)touchesCancelled:(NSSet<UITouch *> *)touches withEvent:(UIEvent *)event
{
    [self updateIOWithTouchEvent:event];
}

- (void)touchesEnded:(NSSet<UITouch *> *)touches withEvent:(UIEvent *)event
{
    [self updateIOWithTouchEvent:event];
}



#pragma mark - MTKViewDelegate

- (void)drawInMTKView:(MTKView*)view
{
   
    
    ImGuiIO& io = ImGui::GetIO();
    io.DisplaySize.x = view.bounds.size.width;
    io.DisplaySize.y = view.bounds.size.height;

    CGFloat framebufferScale = view.window.screen.scale ?: UIScreen.mainScreen.scale;
    io.DisplayFramebufferScale = ImVec2(framebufferScale, framebufferScale);
    io.DeltaTime = 1 / float(view.preferredFramesPerSecond ?: 120);
    
    id<MTLCommandBuffer> commandBuffer = [self.commandQueue commandBuffer];
    

//Define your bool/function in here
    static bool show_s0 = false;    
    static bool show_s1 = false;    
    static bool show_s2 = false;    
    static bool show_s3 = false;    
    static bool show_s4 = false;    
    static bool show_s5 = false;    
    static bool show_s6 = false;                    
    static bool show_s7 = false;        
    static bool show_s8 = false;      
    static bool show_s9 = false;     
    static bool show_s10 = false;     
    static bool show_s11 = false;     
    static bool show_s12 = false;
    static bool bypass = false;

//Define active function
    static bool show_s0_active = false;
    
        
        if (MenDeal == true) {
            [self.view setUserInteractionEnabled:YES];
        } else if (MenDeal == false) {
            [self.view setUserInteractionEnabled:NO];
        }

        MTLRenderPassDescriptor* renderPassDescriptor = view.currentRenderPassDescriptor;
        if (renderPassDescriptor != nil)
        {
            id <MTLRenderCommandEncoder> renderEncoder = [commandBuffer renderCommandEncoderWithDescriptor:renderPassDescriptor];
            [renderEncoder pushDebugGroup:@"ImGui Jane"];

            ImGui_ImplMetal_NewFrame(renderPassDescriptor);
            ImGui::NewFrame();
            
            ImFont* font = ImGui::GetFont();
            font->Scale = 15.f / font->FontSize;
            
            CGFloat x = (([UIApplication sharedApplication].windows[0].rootViewController.view.frame.size.width) - 360) / 2;
            CGFloat y = (([UIApplication sharedApplication].windows[0].rootViewController.view.frame.size.height) - 300) / 2;
            
            ImGui::SetNextWindowPos(ImVec2(x, y), ImGuiCond_FirstUseEver);
            ImGui::SetNextWindowSize(ImVec2(400, 300), ImGuiCond_FirstUseEver);
            
            if (MenDeal == true)
            {                
                ImGui::Begin("andr hack 1.41.5 ipa", &MenDeal);
                ImGui::Text("Use 3 Fingers Click 3 Times Open Menu\n2 Finger Tap Screen 2 Times Hide Menu\n\nOpen In Lobby");
                
                ImGui::TableNextColumn();
                ImGui::Checkbox("ANTI-BAN", &bypass);
                ImGui::Checkbox("Nick indicators", &show_s0);
                ImGui::Checkbox("Radar", &show_s1);
                ImGui::Checkbox("Legit rain", &show_s2);
                ImGui::Checkbox("Rain", &show_s3);
                //ImGui::Checkbox("Crosshair", &show_s4);
                ImGui::Checkbox("No granage", &show_s5);
                ImGui::Checkbox("Wallbang", &show_s6);
                //ImGui::Checkbox("No Sniper Blur", &show_s7);
                //ImGui::Checkbox("Walk Through Walls", &show_s8);
                //ImGui::Checkbox("Walk on Air", &show_s9);
                ImGui::Checkbox("Aim", &show_s10);
                ImGui::Checkbox("Tutorial bypass", &show_s11);


                ImGui::Text("Contact me on Telegram: @andrhackerrr");


                ImGui::End();
                
            }
            ImDrawList* draw_list = ImGui::GetBackgroundDrawList();



//Okay so this is the space we place our cheat function
//This function below maybe outdated, idk. But it's an example how we can use
            if(bypass){
                static dispatch_once_t onceToken;
                dispatch_once(&onceToken, ^{
                vm_unity(ENCRYPTOFFSET("0x517A154"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x19DB280"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x19F56C8"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x19F58D4"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x19F58C4"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x19F5638"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x19F4264"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x175C41C"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                
                
                
                vm_unity(ENCRYPTOFFSET("0x18EC668"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x190CCE0"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x190BB28"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x190BA84"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x190B984"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x190B680"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x190B48C"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                
                
                
                
                vm_unity(ENCRYPTOFFSET("0x190AA40"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x19DB4FC"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x19f4628"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x19f461c"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x19f4618"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x19f45e8"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x19f4574"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                
                vm_unity(ENCRYPTOFFSET("0x19f48d8"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x19f49d4"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x19f4a94"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x19f4a98"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x19f4aa0"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x19f4b6c"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x19f4bc8"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                
                
                vm_unity(ENCRYPTOFFSET("0x19f4fc8"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x19f5024"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x19f2960"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x19f2958"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x19f2940"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x19f293c"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x19f2904"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                
                vm_unity(ENCRYPTOFFSET("0x1A242E4"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x1A1D844"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x1a1d84c"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x1a1d8b8"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x1f54598"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x1f545a0"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x1f54590"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                
                vm_unity(ENCRYPTOFFSET("0x1f5458c"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x1f5456c"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                });
            }
            
            if(show_s0){
                static dispatch_once_t onceToken;
                dispatch_once(&onceToken, ^{
                vm_unity(ENCRYPTOFFSET("0x1672ADC"), strtoul(ENCRYPTHEX("0x200080D2"), nullptr, 0));
                });
            } else {
                static dispatch_once_t onceToken;
                dispatch_once(&onceToken, ^{
                vm_unity(ENCRYPTOFFSET("0x1672ADC"), strtoul(ENCRYPTHEX("0xE10300AA"), nullptr, 0));
                });
            }
                    
                    
                    
                    
                    
                    
            if(show_s1){
                static dispatch_once_t onceToken;
                dispatch_once(&onceToken, ^{
                vm_unity(ENCRYPTOFFSET("0x18652EC"), strtoul(ENCRYPTHEX("0xC8008052"), nullptr, 0));
                });
            } else {
                static dispatch_once_t onceToken;
                dispatch_once(&onceToken, ^{
                vm_unity(ENCRYPTOFFSET("0x18652EC"), strtoul(ENCRYPTHEX("0xC8098052"), nullptr, 0));
                });
            }
                    
                    
                    
            if(show_s2){
                static dispatch_once_t onceToken;
                dispatch_once(&onceToken, ^{
                vm_unity(ENCRYPTOFFSET("0x13d3b58"), strtoul(ENCRYPTHEX("0x00102C1E"), nullptr, 0));
                });
            } else {
                static dispatch_once_t onceToken;
                dispatch_once(&onceToken, ^{
                vm_unity(ENCRYPTOFFSET("0x13d3b58"), strtoul(ENCRYPTHEX("0x01102E1E"), nullptr, 0));
                });
            }
                    
                    
                    
            if(show_s3){
                static dispatch_once_t onceToken;
                dispatch_once(&onceToken, ^{
                vm_unity(ENCRYPTOFFSET("0x13d3b98"), strtoul(ENCRYPTHEX("0x0090261E"), nullptr, 0));
                });
            } else {
                static dispatch_once_t onceToken;
                dispatch_once(&onceToken, ^{
                vm_unity(ENCRYPTOFFSET("0x13d3b98"), strtoul(ENCRYPTHEX("0x0820201E"), nullptr, 0));
                });
            }
                    
                    
            if(show_s4){
                static dispatch_once_t onceToken;
                dispatch_once(&onceToken, ^{
                vm_unity(ENCRYPTOFFSET("0x143E964"), strtoul(ENCRYPTHEX("0x200080D2"), nullptr, 0));
                });
            } else {
                static dispatch_once_t onceToken;
                dispatch_once(&onceToken, ^{
                vm_unity(ENCRYPTOFFSET("0x143E964"), strtoul(ENCRYPTHEX("0x00804239"), nullptr, 0));
                });
            }
                    
            if(show_s5){
                static dispatch_once_t onceToken;
                dispatch_once(&onceToken, ^{
                vm_unity(ENCRYPTOFFSET("0x165ABD8"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                });
            } else {
                static dispatch_once_t onceToken;
                dispatch_once(&onceToken, ^{
                vm_unity(ENCRYPTOFFSET("0x165ABD8"), strtoul(ENCRYPTHEX("0xFF8302D1"), nullptr, 0));
                });
            }
                    
                    
                    
                    
                    
            if(show_s6){
                static dispatch_once_t onceToken;
                dispatch_once(&onceToken, ^{
                vm_unity(ENCRYPTOFFSET("0x13d6fb8"), strtoul(ENCRYPTHEX("0xD503201F"), nullptr, 0));
                });
            } else {
                static dispatch_once_t onceToken;
                dispatch_once(&onceToken, ^{
                vm_unity(ENCRYPTOFFSET("0x13d6fb8"), strtoul(ENCRYPTHEX("0x1F03086B"), nullptr, 0));
                });
            }
                    
                    
            if(show_s7){
                static dispatch_once_t onceToken;
                dispatch_once(&onceToken, ^{
                vm_unity(ENCRYPTOFFSET("0x18C57A8"), strtoul(ENCRYPTHEX("0xC0035FD6"), nullptr, 0));
                });
            } else {
                static dispatch_once_t onceToken;
                dispatch_once(&onceToken, ^{
                vm_unity(ENCRYPTOFFSET("0x18C57A8"), strtoul(ENCRYPTHEX("0xEB2BBB6D"), nullptr, 0));
                });
            }
                    
                    
            if(show_s8){
                static dispatch_once_t onceToken;
                dispatch_once(&onceToken, ^{
                vm_unity(ENCRYPTOFFSET("0x23ACED0"), strtoul(ENCRYPTHEX("0x0090341EC0035FD6"), nullptr, 0));
                });
            } else {
                static dispatch_once_t onceToken;
                dispatch_once(&onceToken, ^{
                vm_unity(ENCRYPTOFFSET("0x23ACED0"), strtoul(ENCRYPTHEX("0xF44FBEA9"), nullptr, 0));
                });
            }
                    
                    
                    
            if(show_s9){
                static dispatch_once_t onceToken;
                dispatch_once(&onceToken, ^{
                vm_unity(ENCRYPTOFFSET("0x23ACF10"), strtoul(ENCRYPTHEX("0x0010221EC0035FD6"), nullptr, 0));
                });
            } else {
                static dispatch_once_t onceToken;
                dispatch_once(&onceToken, ^{
                vm_unity(ENCRYPTOFFSET("0x23ACF10"), strtoul(ENCRYPTHEX("0xF44FBEA9"), nullptr, 0));
                });
            }
                    
                    
                    
            if(show_s10){
                static dispatch_once_t onceToken;
                dispatch_once(&onceToken, ^{
                vm_unity(ENCRYPTOFFSET("0x191DBF0"), strtoul(ENCRYPTHEX("0x0010201EC0035FD6"), nullptr, 0));
                });
            } else {
                static dispatch_once_t onceToken;
                dispatch_once(&onceToken, ^{
                vm_unity(ENCRYPTOFFSET("0x191DBF0"), strtoul(ENCRYPTHEX("0x004840F9"), nullptr, 0));
                });
            }
                    
                    
            if(show_s11){
                static dispatch_once_t onceToken;
                dispatch_once(&onceToken, ^{
                vm_unity(ENCRYPTOFFSET("0x17CA458"), strtoul(ENCRYPTHEX("0x68018052"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x17CA758"), strtoul(ENCRYPTHEX("0x68018052"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x17CB5B4"), strtoul(ENCRYPTHEX("0x68018052"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x17CAD9C"), strtoul(ENCRYPTHEX("0x68018052"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x17CB254"), strtoul(ENCRYPTHEX("0x68018052"), nullptr, 0));
                
                vm_unity(ENCRYPTOFFSET("0x17CA7E0"), strtoul(ENCRYPTHEX("0x68018052"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x17CAD8C"), strtoul(ENCRYPTHEX("0x68018052"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x17CB244"), strtoul(ENCRYPTHEX("0x68018052"), nullptr, 0));
                });
            } else {
                static dispatch_once_t onceToken;
                dispatch_once(&onceToken, ^{
                vm_unity(ENCRYPTOFFSET("0x18C9E5C"), strtoul(ENCRYPTHEX("0xFF4301D1"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x18CA078"), strtoul(ENCRYPTHEX("0xFF4301D1"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x18BB470"), strtoul(ENCRYPTHEX("0xFF4301D1"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x18C9CD8"), strtoul(ENCRYPTHEX("0xFF4301D1"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x18CA3A0"), strtoul(ENCRYPTHEX("0xFF4301D1"), nullptr, 0));
                    
                vm_unity(ENCRYPTOFFSET("0x17CA7E0"), strtoul(ENCRYPTHEX("0xFF4301D1"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x17CAD8C"), strtoul(ENCRYPTHEX("0xFF4301D1"), nullptr, 0));
                vm_unity(ENCRYPTOFFSET("0x17CB244"), strtoul(ENCRYPTHEX("0xFF4301D1"), nullptr, 0));
                });
            }
//Hook function example
            /*
    static dispatch_once_t onceToken;
            dispatch_once(&onceToken, ^{
                //use DobbyHook, same kind of MSHookFunction but working on JIT, Dopamine!
                DobbyHook((void *)(getRealOffset(ENCRYPTOFFSET("0x5F145F8"))), (void *)_huy, (void **)&huy);
            });

*/
            ImGui::Render();
            ImDrawData* draw_data = ImGui::GetDrawData();
            ImGui_ImplMetal_RenderDrawData(draw_data, commandBuffer, renderEncoder);
          
            [renderEncoder popDebugGroup];
            [renderEncoder endEncoding];

            [commandBuffer presentDrawable:view.currentDrawable];
        }

        [commandBuffer commit];
}

- (void)mtkView:(MTKView*)view drawableSizeWillChange:(CGSize)size
{
    
}

@end

