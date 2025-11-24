#import "x2nios.h"
//#import "APIClient.h"
#include "Obfuscate.h"
#import "Esp/ImGuiDrawView.h"
#import <Metal/Metal.h>
#import <MetalKit/MetalKit.h>
#import <Foundation/Foundation.h>
#include "IMGUI/imgui.h"
#include "IMGUI/imgui_internal.h"
#include "IMGUI/imgui_impl_metal.h"
#import <Foundation/Foundation.h>
#import <os/log.h>
#include "Quaternion.h"
#include "Vector3.h"
#include "UnityStuff.h"  
#include <vector>
#import <dlfcn.h>
#include <map>
//#include <OpenGLES/ES2/gl.h>
//#include <OpenGLES/ES2/glext.h>
#include "mIl2Cpp.h"
#include <unistd.h>
#include <string.h>
#include <pthread.h>
//#import "NSEtcHosts.h"
#import <stdio.h>
#import "UIKit/UIKit.h"
//#import "SCLAlertView/SCLAlertView.h"
#include "Matrix4x4.h"
//#include "fishhook.h"
#include <mach/mach_init.h>
#include <mach/vm_map.h>
//#include "Hooks.h"

uint64_t getRealOffset(uint64_t offset) {
    uint32_t c = _dyld_image_count();
    for (int i = 0; i < c; i++) {
        if (strstr(_dyld_get_image_name(i), "UnityFramework")) {
            return _dyld_get_image_vmaddr_slide(i) + offset;
        }
    }
    // Return a default value (or handle the case where UnityFramework is not found)
    return 0; // or any other suitable value
}

#define screenHeight [UIScreen mainScreen].bounds.size.height
#define screenWidth [UIScreen mainScreen].bounds.size.width

@interface ImGuiDrawView () <MTKViewDelegate>
//@property (nonatomic, strong) IBOutlet MTKView *mtkView;
@property (nonatomic, strong) id <MTLDevice> device;
@property (nonatomic, strong) id <MTLCommandQueue> commandQueue;

@end
@implementation ImGuiDrawView

__attribute__((visibility("hidden"))) static bool MenDeal = true;

#define BundlePath @"/Library/PreferenceBundles/Tweak.bundle"
- (instancetype)initWithNibName:(nullable NSString *)nibNameOrNil bundle:(nullable NSBundle *)nibBundleOrNil
{
    self = [super initWithNibName:nibNameOrNil bundle:nibBundleOrNil];

    _device = MTLCreateSystemDefaultDevice();
    _commandQueue = [_device newCommandQueue];

    if (!self.device) abort();

    IMGUI_CHECKVERSION();
    ImGui::CreateContext();
    ImGuiIO& io = ImGui::GetIO(); (void)io;


    NSString *FontPath = @"/System/Library/Fonts/AppFonts/Charter.ttc";
    io.Fonts->AddFontFromFileTTF(FontPath.UTF8String, 30.f,NULL,io.Fonts->GetGlyphRangesChineseSimplifiedCommon());

    
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

enum BodyPart
{
     LOWERLEG_LEFT = 0,
     LOWERLEG_RIGHT = 1,
     UPPERLEG_LEFT = 2,
     UPPERLEG_RIGHT = 3,
     STOMACH = 4,
     CHEST = 5,
     UPPERARM_LEFT = 6,
     UPPERARM_RIGHT = 7,
     LOWERARM_LEFT = 8,
     LOWERARM_RIGHT = 9,
     HEAD = 10
}; BodyPart parts;

enum TutorialStage {
          OnBoardingStarted = 0,
  	  GameplayStarted = 1,
	  ShootingRangeReached = 2,
	  ShootingRangeCompleted = 3,
	  GrenadeRangeCompleted = 4,
	  BombDefuseCompleted = 5,
	  BombPlantCompleted = 6,
	  GameplayDone = 7,
	  PracticeStarted = 8,
	  PracticeDone = 9,
	  TutorialRewardClaimed = 30,
	  StoreOpened = 48,
	  GetCasesMenu = 49,
	  CasePurchased = 50,
	  OpenCasesMenu = 51,
	  ClickInventoryCase = 52,
	  CaseSelected = 59,
	  CaseOpened = 60,
	  WeaponSkinTapped = 61,
	  PlayMenuOpened = 64,
	  GameModeSelected = 67,
	  ProfileOpened = 70,
	  ProfileClosed = 71,
	  TutorialCompleted = 255
}; TutorialStage tutStage;

enum WallPenetration { 
 none = 0,
 weak = 1,
 strong = 2,
 grenade = 3
 }; WallPenetration penetration;
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

 __attribute__((visibility("hidden"))) void DrawBox(float X, float Y, float W, float H, ImColor Color, float curve, float thickness) {
   ImDrawList *draw_list = ImGui::GetForegroundDrawList();
   draw_list->AddRect(ImVec2(X, Y), ImVec2(X + W, Y + H), Color, curve, thickness);
   }
   void DrawOutlinedBox2(float x, float y, float width, float height, ImColor color, float curve, float thickness)
{
    DrawBox(x-thickness+1, y-thickness+1, width + thickness*2 -2, height + thickness*2 -2, ImColor(0,0,0), 0, 1);
    DrawBox(x, y, width, height, color, 0, thickness);
    DrawBox(x + thickness -1, y + thickness -1, width - thickness*2 + 2, height - thickness*2 +2, ImColor(0,0,0), 0, 1);
}
   
   __attribute__((visibility("hidden"))) void DrawBoxFilled(float X, float Y, float W, float H, ImColor Color, float curve, float thickness) {
   ImDrawList *draw_list = ImGui::GetForegroundDrawList();
   draw_list->AddRectFilled(ImVec2(X, Y), ImVec2(X + W, Y + H), Color, curve, thickness);
   }

#define DrawCircle shadi20198
__attribute__((visibility("hidden"))) void DrawCircle(float X, float Y, float radius, bool filled, ImColor Color)
{
    ImDrawList* draw_list = ImGui::GetForegroundDrawList();
    
    if(filled)
    {
        draw_list->AddCircleFilled(ImVec2(X, Y), radius, Color);
    } 
    else
    {
        draw_list->AddCircle(ImVec2(X, Y), radius, Color);
    }
    
}
   
   __attribute__((visibility("hidden"))) void RenderLine(const ImVec2& from, const ImVec2& to, ImColor Color, float thickness)
{
ImDrawList* draw_list = ImGui::GetForegroundDrawList();

	draw_list->AddLine(from, to, Color, thickness);
} 

Vector3 (*get_Position)(void *) = (Vector3(*)(void *))getRealOffset(ENCRYPTOFFSET("0x2E9A840"));

void *(*get_transform)(void *thiz) = (void *(*)(void *))getRealOffset(ENCRYPTOFFSET("0x2E8BCB4"));

void DrawTriangle(ImVec2 p1, ImVec2 p2, ImVec2 p3, ImColor color) {
    ImDrawList* draw_list = ImGui::GetForegroundDrawList();
    draw_list->AddTriangleFilled(p1, p2, p3, color);
  }
Vector3 getBonePosition(void *character, int bone) {
    void *hitSphere = NULL;
    void *transform = NULL;
    Vector3 bonePos = Vector3(0, 0, 0);

    if (character != nullptr) {
        NSLog(@"Character pointer is valid.");

        // Get the current bone from `character`
        monoArray<void*> *curBone = *( monoArray<void*>**) ((uint64_t) character + 0x100);
        std::vector<void*>trs = curBone->toCPPlist();

        if (curBone != nullptr) {
            NSLog(@"Successfully retrieved curBone.");

            // Retrieve `hitSphere` from `curBone`
            hitSphere = *(void **) ((uint64_t) curBone + 0x28);

            if (hitSphere != nullptr) {
                NSLog(@"Successfully retrieved hitSphere.");

                // Retrieve `transform` from `hitSphere`
                transform = get_transform(hitSphere);

                if (transform != nullptr) {
                    NSLog(@"Successfully retrieved transform.");

                    // Get the position of the bone using `get_Position` function
                    bonePos = get_Position(transform);
                    NSLog(@"Successfully retrieved bone position for bone %d: %.2f, %.2f, %.2f", bone, bonePos.x, bonePos.y, bonePos.z);

                    return bonePos;
                } else {
                    NSLog(@"Failed to retrieve transform from hitSphere.");
                }
            } else {
                NSLog(@"Failed to retrieve hitSphere from curBone.");
            }
        } else {
            NSLog(@"Failed to retrieve curBone from character.");
        }
    } else {
        NSLog(@"Character pointer is null.");
    }

    // Return default Vector3 if any condition fails
    NSLog(@"Returning default bone position (0, 0, 0) for bone %d.", bone);
    return Vector3(0, 0, 0);
}


bool espboxes;
bool ctbox;
bool tbox;
  __attribute__((visibility("hidden"))) static float speed;
  __attribute__((visibility("hidden"))) static bool esplines;
  static bool healthbar;
  __attribute__((visibility("hidden"))) static bool aimbot;
  __attribute__((visibility("hidden"))) static float fov;
  bool espen;
        
      float dist(float x1, float x2, float y1, float y2) {
         return sqrtf( pow(x1 - x2, 2) + pow(y1 - y2, 2) );
      }
      
    struct characterz_t {
     void *object;
     void *transforms;
     int health;
     Vector3 position;
     int team;
     void *player;
     void *teamBoxed;
     bool visible;
     Vector3 screenPos;
     Vector3 rect;
     float opacity = 0.9;
     bool alive;
     bool initialized;
     float color4;
     bool enemy;
     
    bool inside() {
        if(dist([[UIScreen mainScreen]bounds].size.width / 2, this->screenPos.x, [[UIScreen mainScreen]bounds].size.height / 2, this->screenPos.y) < fov)
            return true;
        else
            return false; 
    }
       
    }; __attribute__((visibility("hidden"))) characterz_t characterz[16];
    __attribute__((visibility("hidden"))) float teamColors[3];
     __attribute__((visibility("hidden"))) float enemyColors[3];
     static int counter2;
     Vector3 enemiesposition[16];
     
   
             
    #define localTeam cjdasji
    __attribute__((visibility("hidden"))) int localTeam;
   
   #define teamesp oasdi21390
   #define testvec ch1h9
   #define screenz sdpa90213
   #define counter j09asd
   
__attribute__((visibility("hidden"))) static bool teamesp;
__attribute__((visibility("hidden"))) Vector3 screenz;

__attribute__((visibility("hidden"))) static bool radar;

static int counter;
ImColor CTColor = ImColor(255,255,255);
ImColor TColor = ImColor(255,255,255);
ImColor lineColor = ImColor(0,0,0);
ImColor lineColor1 = ImColor(255,255,255);
ImColor CTlineColor1 = ImColor(255,255,255);
ImColor TlineColor1 = ImColor(255,255,255);

static float aaValue;
static bool aaHack;
static bool tutskip;
static bool noaimpunch;
static bool namespoof;
static int boxMode = 0;
const char* boxtypes[] = { ("none"), ("CT"), ("T")};
bool cheat_on;
Vector3 (*WorldToViewpoint)(void*, Vector3, int) = (Vector3 (*)(void *, Vector3, int ))getRealOffset(ENCRYPTOFFSET("0x2E59160"));
void *(*get_main)() = (void *(*)())getRealOffset(ENCRYPTOFFSET("0x2E5A194"));

ImVec2 world2screen_i(Vector3 pos) {
    auto cam = get_main();
    if (!cam) return {0,0};
    
    Vector3 worldPoint = WorldToViewpoint(cam,pos, 2);
    Vector3 location;
    
    int ScreenWidth = ImGui::GetIO().DisplaySize.x;
    int ScreenHeight = ImGui::GetIO().DisplaySize.y;
    
    location.x = ScreenWidth * worldPoint.x;
    location.y = ScreenHeight - worldPoint.y * ScreenHeight;
    location.z = worldPoint.z;
    
    return {location.x, location.y};
}

ImVec2 world2screen_c(Vector3 pos, bool &checker) {
    auto cam = get_main();
    if (!cam) return {0,0};
    
    Vector3 worldPoint = WorldToViewpoint(cam,pos, 2);
    Vector3 location;
    
    int ScreenWidth = ImGui::GetIO().DisplaySize.x;
    int ScreenHeight = ImGui::GetIO().DisplaySize.y;
    
    location.x = ScreenWidth * worldPoint.x;
    location.y = ScreenHeight - worldPoint.y * ScreenHeight;
    location.z = worldPoint.z;
    
    checker = location.z > 1;
    
    return {location.x, location.y};
}
void *(*get_LocalCharacter)(void *thiz) = (void *(*)(void *))getRealOffset(0x1CA3A28);
/*bool isCharacterVisible(void *character, void *pSys) {
    void *localCharacter = get_LocalCharacter(pSys);
    if (localCharacter) {
        return !isHeadBehindWall(localCharacter, character);
    }
    return 0;
}*/

int valtest;
void DrawHorizontalHealthBar(ImVec2 pos, ImVec2 size, float health, int maxValue, ImColor color)
{
    ImDrawList* drawList = ImGui::GetBackgroundDrawList();

    // Draw the shadow
    //drawList->AddRectFilled(ImVec2(pos.x + 2, pos.y + 2), ImVec2(pos.x + size.x + 2, pos.y + size.y + 2), IM_COL32(0, 0, 0, 100), 0, 0);

    // Draw the health rect
    drawList->AddRectFilled(pos, ImVec2(pos.x + size.x, pos.y + size.y), ImColor(124, 255, 112, 200), 0, 0); // Background for Health
    drawList->AddRectFilled(pos, ImVec2(pos.x + size.x - health, pos.y + size.y), color, 0, 0); // Actual Health

    /*int numBars = 0;
    numBars = (size.x - ((numBars - 1) * 10)) / (2 + 10);

    // Calculate the spacing between each bar
    float actualSpacing = (size.x - (numBars * 2)) / (numBars - 1);

    // Add the black bars
    for (int i = 0; i < numBars; i++)
    {
        float xPos = pos.x + (i * (2 + actualSpacing));
        ImVec2 barPos = ImVec2(xPos, pos.y);
        drawList->AddRectFilled(barPos, ImVec2(barPos.x + 2, barPos.y + size.y), IM_COL32(0, 0, 0, 255), 0, 0);
    }*/
}
void drawRectFilledWithPos(ImVec2 pos, ImVec2 size, ImColor color) {
    ImGui::GetBackgroundDrawList()->AddRectFilled(pos, ImVec2(pos.x + size.x, pos.y + size.y), color, 0, ImDrawCornerFlags_All);
}
void Draw3DBox(Vector3* points, ImColor color, float thickness) {
    for (int i = 0; i < 4; i++) {
        ImGui::GetBackgroundDrawList()->AddLine(ImVec2(points[i].x, points[i].y), ImVec2(points[(i + 1) % 4].x, points[(i + 1) % 4].y), color, thickness);
        ImGui::GetBackgroundDrawList()->AddLine(ImVec2(points[i + 4].x, points[i + 4].y), ImVec2(points[(i + 1) % 4 + 4].x, points[(i + 1) % 4 + 4].y), color, thickness);
        ImGui::GetBackgroundDrawList()->AddLine(ImVec2(points[i].x, points[i].y), ImVec2(points[i + 4].x, points[i + 4].y), color, thickness);
    }
}
void (*SetResolution)(int, int, bool) = (void (*)(int, int, bool))getRealOffset(ENCRYPTOFFSET("0x2E67290"));
bool setresolut = false;
static int resw = 1000;
static int resh = 1000;
void setres(){
    if (setresolut){
    SetResolution(resw, resh, true);

    }
}

void DrawInfoBox(float x, float y, const char* playerName, int health, int team) {
    // Размеры информационного бокса
    float boxWidth = 120.0f;
    float boxHeight = 40.0f;
    float padding = 5.0f;

    // Цвета
    ImColor boxColor = ImColor(0, 0, 0, 128); // Черный фон с прозрачностью
    ImColor textColor = ImColor(255, 255, 255, 255); // Белый текст

    // Рисуем фон бокса
    ImGui::GetBackgroundDrawList()->AddRectFilled(ImVec2(x, y), ImVec2(x + boxWidth, y + boxHeight), boxColor);

    // Позиция текста
    float textX = x + padding;
    float textY = y + padding;

    // Рисуем имя игрока
    ImGui::GetBackgroundDrawList()->AddText(ImVec2(textX, textY), textColor, playerName);

    // Рисуем здоровье
    char healthText[16];
    sprintf(healthText, "HP: %d", health);
    ImGui::GetBackgroundDrawList()->AddText(ImVec2(textX, textY + 15), textColor, healthText);

    // Рисуем команду
    char teamText[16];
    sprintf(teamText, "Team: %d", team);
    ImGui::GetBackgroundDrawList()->AddText(ImVec2(textX, textY + 30), textColor, teamText);
}

void DrawHPBar(float x, float y, float width, float height, float healthPercentage, ImColor bgColor, ImColor fgColor) {
    // Calculate the filled width based on health percentage
    float filledWidth = width * healthPercentage;

    // Draw background bar
    ImGui::GetWindowDrawList()->AddRectFilled(ImVec2(x, y), ImVec2(x + width, y + height), bgColor);

    // Draw foreground bar
    ImGui::GetWindowDrawList()->AddRectFilled(ImVec2(x, y), ImVec2(x + filledWidth, y + height), fgColor);
}
void DrawInfoBoxWithHealthBar(ImDrawList* drawList, float screenPosX, float screenPosY, const char* text, float healthPercentage) {
    // Define the fixed size of the info box
    const float infoBoxWidth = 100.0f;
    const float infoBoxHeight = 30.0f;

    // Define the size of the health bar
    const float healthBarHeight = 5.0f;
    const float healthBarWidth = infoBoxWidth;

    // Position the info box slightly above the screen position
    float infoBoxX = screenPosX - infoBoxWidth / 2;
    float infoBoxY = screenPosY - infoBoxHeight - 10.0f;

    // Position the health bar just below the info box
    float healthBarX = infoBoxX;
    float healthBarY = infoBoxY + infoBoxHeight + 5.0f; // 5 pixels below the info box

    // Define colors
    ImU32 bgColor = IM_COL32(0, 0, 0, 128); // Semi-transparent black background
    ImU32 textColor = IM_COL32(255, 255, 255, 255); // White text
    ImU32 healthBarBgColor = IM_COL32(255, 0, 0, 255); // Red for the health bar background
    ImU32 healthBarFgColor = IM_COL32(0, 255, 0, 255); // Green for the health bar foreground

    // Draw the background rectangle for the info box
    drawList->AddRectFilled(ImVec2(infoBoxX, infoBoxY), ImVec2(infoBoxX + infoBoxWidth, infoBoxY + infoBoxHeight), bgColor);

    // Draw the text inside the info box
    drawList->AddText(ImVec2(infoBoxX + 5, infoBoxY + 5), textColor, text);

    // Draw the background of the health bar
    drawList->AddRectFilled(ImVec2(healthBarX, healthBarY), ImVec2(healthBarX + healthBarWidth, healthBarY + healthBarHeight), healthBarBgColor);

    // Draw the foreground of the health bar based on the health percentage
    float healthBarCurrentWidth = healthBarWidth * healthPercentage;
    drawList->AddRectFilled(ImVec2(healthBarX, healthBarY), ImVec2(healthBarX + healthBarCurrentWidth, healthBarY + healthBarHeight), healthBarFgColor);
}



void addRectFilledMultiColor(float x, float y, float w, float h, ImColor top, ImColor bottom)
{
    ImDrawList *draw_list = ImGui::GetForegroundDrawList();
    draw_list->AddRectFilledMultiColor(ImVec2(x, y), ImVec2(x + w, y + h), top, top, bottom, bottom);
}

  characterz_t closest() {
        characterz_t closest;
           for(int i = 0; i<counter; i++) {
        if(characterz[i].enemy){

                  if(characterz[i].inside()) {
                     closest = characterz[i];
                     
                     }
                  }
              }
                return closest;
              }



uint64_t baseAddrTest;



inline bool in_fov(int fovX, int fovY, int aimFOV, int x, int y)
{
float dist = sqrt(abs(fovX - x) * abs(fovX - x) + abs(fovY - y) * abs(fovY - y));
return (dist < aimFOV) ? true : false;
}
int test1;
int test2;
int ammo;
bool esp3d;
bool infobox;
bool nicknameEnable;
float yAdjustment = 0.0f;
bool espSkeleton;
static bool stw;
float rgba[4];
struct mach_header_64 testHeader;
#define thr G09324832948030294
  
	
#pragma mark - MTKViewDelegate

int returnValue() {
return 10;
}
static float value;
__attribute__((visibility("hidden"))) static bool api = false;

- (void)drawInMTKView:(MTKView*)view
{


    ImGuiIO& io = ImGui::GetIO();
    io.DisplaySize.x = view.bounds.size.width;
    io.DisplaySize.y = view.bounds.size.height;


    CGFloat framebufferScale = view.window.screen.nativeScale ?: UIScreen.mainScreen.nativeScale;
    io.DisplayFramebufferScale = ImVec2(framebufferScale, framebufferScale);
    io.DeltaTime = 1 / float(view.preferredFramesPerSecond ?: 60);
    
    id<MTLCommandBuffer> commandBuffer = [self.commandQueue commandBuffer];
   
        static bool show_line = false; 
        if (MenDeal == true) 
        {
            [self.view setUserInteractionEnabled:YES];
        } 
        else if 
        (MenDeal == false) 
        {
           
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
            font->Scale = 16.f / font->FontSize;
            
            CGFloat x = (([UIApplication sharedApplication].windows[0].rootViewController.view.frame.size.width) - 360) / 2;
            CGFloat y = (([UIApplication sharedApplication].windows[0].rootViewController.view.frame.size.height) - 320) / 2;
            
            ImGui::SetNextWindowPos(ImVec2(x, y), ImGuiCond_FirstUseEver);
            ImGui::SetNextWindowSize(ImVec2(500, 210), ImGuiCond_FirstUseEver);
            
    if (MenDeal == true)
    {
        //ImGui::PushStyleColor(ImGuiCol_Text, ImVec4(ImColor(sinf(ImGui::GetTime()) , sinf(ImGui::GetTime() + 1), cosf(ImGui::GetTime()))));
        
        ImGui::Begin(ENCRYPT("@grapeios 1.45.4"), &MenDeal, ImGuiWindowFlags_None);

    //ImGui::PopStyleColor();
              
    ImGui::BeginTabBar(ENCRYPT("Bar"));
    if (ImGui::BeginTabItem(ENCRYPT("Visual")))
    {


    ImGui::Checkbox(ENCRYPT("Enable cheat"), &cheat_on);  
    ImGui::Combo(ENCRYPT("Show Team"), &boxMode, boxtypes, IM_ARRAYSIZE(boxtypes)); 
    ImGui::Checkbox(ENCRYPT("Boxes"), &espboxes);
    ImGui::SameLine();
    ImGui::Checkbox(ENCRYPT("3D"), &esp3d);
    ImGui::SameLine();
    ImGui::Checkbox(ENCRYPT("Lines"), &esplines);
    ImGui::SameLine();
    ImGui::Checkbox(ENCRYPT("Skeleton"), &espSkeleton);
    ImGui::SameLine();
    ImGui::Checkbox(ENCRYPT("Healthbar"), &healthbar);
    ImGui::SameLine();
    ImGui::Checkbox(ENCRYPT("Nick"), &nicknameEnable);
    /*ImGui::ColorEdit3(ENCRYPT("CT Color Box"), (float*) &CTColor);
    ImGui::ColorEdit3(ENCRYPT("T Color Box"), (float*) &TColor);
    ImGui::ColorEdit3(ENCRYPT("CT Color Line"), (float*) &CTlineColor1);
    ImGui::ColorEdit3(ENCRYPT("T Color Line"), (float*) &TlineColor1); */ 


    ImGui::EndTabItem();
    }
          
    if(ImGui::BeginTabItem(ENCRYPT("Aim")))
    {		     
        ImGui::Checkbox(ENCRYPT("Aimbot"), &aimbot);
        if(aimbot)
        ImGui::SliderFloat(ENCRYPT("fov"), &fov, 0.f, 100.f);
    ImGui::SliderFloat(ENCRYPT("Y-Axis"), &yAdjustment, -2.f, 10.f);

    ImGui::EndTabItem();
    }    

    if(ImGui::BeginTabItem(ENCRYPT("Misc")))
    {

    ImGui::Checkbox(ENCRYPT("Skip Tutorial"), &tutskip);
    ImGui::Checkbox(ENCRYPT("No Aimpunch"), &noaimpunch);
    ImGui::Checkbox(ENCRYPT("Name Spoof"), &namespoof);
    ImGui::Checkbox(ENCRYPT("Set Resolut"), &setresolut);
    ImGui::SliderInt(ENCRYPT("Res width"), &resw, 0, 5000);
    ImGui::SliderInt(ENCRYPT("Res height"), &resh,0,5000);

    ImGui::EndTabItem();
    }
  ImGui::End();

  }

  setres();

if(aimbot)
         DrawCircle([[UIScreen mainScreen] bounds].size.width / 2, [[UIScreen mainScreen] bounds].size.height / 2, fov, 0, ImColor(255,255,255));
  if (cheat_on) {
    void *typeinfo_gmodule = *(void **)getRealOffset(0x3E23BA8);
    void *(*get_localcharacter)(void *thiz) = (void *(*)(void *))getRealOffset(0x1CA3A28);
    void *(*get_localPlayer)(void *thiz) = (void *(*)(void *))getRealOffset(0x1CA3D14);
    void *(*Get_trans)(void *thiz) = (void *(*)(void *))getRealOffset(ENCRYPTOFFSET("0x2E8BCB4"));
    void (*get_pos_inj)(void *thiz, Vector3* output) = (void (*)(void *, Vector3 *))getRealOffset(ENCRYPTOFFSET("0x2E9A8A0"));
    bool (*isEnemyOf)(void*,int a) = (bool (*)(void*, int)) getRealOffset(ENCRYPTOFFSET("0x1C26698"));

    void* local_player = nullptr;
    Vector3 localPos;
    Vector3 pos;
    int enemyteam = -1;
    int localteam = -1;
    ImColor color;

    if (typeinfo_gmodule != nullptr) {
        //NSLog(@"typeinfo_gmodule accessed");
        void *static_gmodule = *(void **)((uint64_t)typeinfo_gmodule + 0xb8);
        if (static_gmodule != nullptr) {
            //NSLog(@"static_gmodule accessed");
            void *GameplayModule = *(void **)((uint64_t)static_gmodule + 0x0);
            if (GameplayModule) {
                void *gameSystem = *(void **)((uint64_t)GameplayModule + 0x10);
                if (gameSystem) {
                    local_player = get_localPlayer(gameSystem);
                    monoList<void**> *characters = *(monoList<void**> **)((uint64_t)gameSystem + 0xC0);
                    if (characters != nullptr) {
                        for (int i = 0; i < characters->getSize(); i++) {
                            void* character = characters->getItems()[i];
                            int teams = -1;
                            if (character != nullptr) {
                                bool isCT = isEnemyOf(character, 1);
                                bool isT = isEnemyOf(character, 0);
                                characterz[i].health = *(int *)((uint64_t)character + 0x13C);
                                int health = *(int *)((uint64_t)character + 0x13C);
                                get_pos_inj(Get_trans(character), &pos);

                                Matrix4x4 (*get_ProjectionMatrix)(void *) = (Matrix4x4 (*)(void *))getRealOffset(ENCRYPTOFFSET("0x2E58A08"));
                                Matrix4x4 (*worldToLocalMatrix)(void *thiz) = (Matrix4x4 (*)(void *))getRealOffset(ENCRYPTOFFSET("0x2E9B564"));
                                Matrix4x4 P = get_ProjectionMatrix(get_main());
                                void *cameraTrans = Get_trans(get_main());
                                Matrix4x4 V = worldToLocalMatrix(cameraTrans);
                                Matrix4x4 VP = P * V;

                                Vector4 point4 = Vector4(pos.x, pos.y + 1.222, pos.z, 1);
                                Vector4 result4 = VP * point4;
                                Vector3 result;
                                result.x = result4.x;
                                result.y = result4.y;
                                result.z = result4.z;
                                result /= -result4.w;
                                result.x = result.x / 2 + 0.5f;
                                result.y = result.y / 2 + 0.5f;
                                result.z = -result4.w;

                                Vector3 screenPos = result;
                                screenPos.x *= [[UIScreen mainScreen]bounds].size.width;
                                screenPos.y = [[UIScreen mainScreen]bounds].size.height - screenPos.y * [[UIScreen mainScreen]bounds].size.height;

                                characterz[i].screenPos = screenPos;
                                Vector3 newvec = characterz[i].screenPos;
                                    float dx = 100.0f / (newvec.z / 4);
                                    float dy = 200.0f / (newvec.z / 4);
                                    float xx = newvec.x - dx / 2;
                                    float yy = newvec.y - dy / 4;
                                    void *localch = get_localcharacter(gameSystem);
if (localch != nullptr) {
    void *localTrans = Get_trans(localch);
    if (localTrans != nullptr) {
        get_pos_inj(localTrans, &localPos);
        if (in_fov(screenWidth/2, screenHeight/2, fov, newvec.x, newvec.y)) {
            Vector3 angles = ToEulerRad(GetRotationToLocation(pos, -0.65f, localPos));
            Vector2 rotation;
            rotation.x = angles.x + yAdjustment;
            rotation.y = angles.y;

            // Logging the values for debugging
            //NSLog(@"angles: (%.2f, %.2f)", angles.x, angles.y);
           // NSLog(@"rotation before adjustments: (%.2f, %.2f)", rotation.x, rotation.y);

            if (rotation.x >= 275.f) { rotation.x -= 360.f; }
            if (rotation.x <= -275.f) { rotation.x += 360.f; }

            // Logging again after adjustments
           // NSLog(@"rotation after adjustments: (%.2f, %.2f)", rotation.x, rotation.y);

            void (*set_rot)(void *thiz, Vector2 rot) = (void (*)(void *, Vector2))getRealOffset(0x1C21BB8);
            if (aimbot) {
                if (boxMode == 1) {
                    if (isT) {
                        set_rot(localch, rotation);
                    }
                } 
                else if (boxMode == 2) {
                    if (isCT) {
                        set_rot(localch, rotation);
                    }
                } 
            }
        }
    }
}
                            if (healthbar && characterz[i].screenPos.z > 0.01 && character != nullptr) {
    float barWidth = dx + 50.0f; // Increased width of the HP bar
    float barHeight = 2.0f; // Height of the HP bar
    float barPosX = xx - (barWidth - dx) / 2.0f; // Adjusted position for increased width to keep it centered
    float rectHeight = 15.0f; // Height of the rectangle
    float rectPosY = yy - rectHeight - 2.0f; // Position directly above the character box, moved higher
    float barPosY = rectPosY + rectHeight - barHeight; // Adjusted to overlap with the rectangle's bottom
    float rounding = 1.5f;
    const char* text = "";
     ImVec2 textSize = ImGui::CalcTextSize(text);
    float textPosX = barPosX + (barWidth - textSize.x) / 2.0f;
    float textPosY = rectPosY + (rectHeight - textSize.y) / 2.0f;
    if (boxMode == 1 && isT) {
        text = "CT";
    } else if (boxMode == 2 && isCT) {
        text = "T";
    }

    // Calculate HP bar color based on health percentage
    ImColor hpColor = ImColor(255 * (100 - health) / 100, 255 * health / 100, 0);
    if (boxMode == 1) {
        if (isT) {
            // Draw the rectangle above the HP bar
    ImGui::GetBackgroundDrawList()->AddRectFilled(ImVec2(barPosX, rectPosY), ImVec2(barPosX + barWidth, rectPosY + rectHeight), ImColor(20, 20, 20, 190), rounding);

    // Draw the HP bar (no background)
    ImGui::GetBackgroundDrawList()->AddRectFilled(ImVec2(barPosX, barPosY), ImVec2(barPosX + (barWidth * health / 100), barPosY + barHeight), hpColor, rounding);
     //ImGui::GetBackgroundDrawList()->AddText(ImVec2(textPosX, textPosY), ImColor(255, 255, 255, 255), text);
        }
    }
    if (boxMode == 2) {
        if (isCT) {
            // Draw the rectangle above the HP bar
    ImGui::GetBackgroundDrawList()->AddRectFilled(ImVec2(barPosX, rectPosY), ImVec2(barPosX + barWidth, rectPosY + rectHeight), ImColor(20, 20, 20, 190), rounding);

    // Draw the HP bar (no background)
    ImGui::GetBackgroundDrawList()->AddRectFilled(ImVec2(barPosX, barPosY), ImVec2(barPosX + (barWidth * health / 100), barPosY + barHeight), hpColor, rounding);
    //ImGui::GetBackgroundDrawList()->AddText(ImVec2(textPosX, textPosY), ImColor(255, 255, 255, 255), text);
        }
    }
}








                                    if (espSkeleton && characterz[i].screenPos.z > 0.01 && character != nullptr) {
    // Здесь `espSkeleton` - флаг для включения отображения скелета

    // Получаем позиции ключевых костей
    Vector3 headPos = getBonePosition(character, HEAD);
    Vector3 chestPos = getBonePosition(character, CHEST);
    Vector3 leftShoulderPos = getBonePosition(character, UPPERARM_LEFT);
    Vector3 rightShoulderPos = getBonePosition(character, UPPERARM_RIGHT);
    Vector3 leftElbowPos = getBonePosition(character, LOWERARM_LEFT);
    Vector3 rightElbowPos = getBonePosition(character, LOWERARM_RIGHT);
    Vector3 leftHipPos = getBonePosition(character, UPPERLEG_LEFT);
    Vector3 rightHipPos = getBonePosition(character, UPPERLEG_RIGHT);
    Vector3 leftKneePos = getBonePosition(character, LOWERLEG_LEFT);
    Vector3 rightKneePos = getBonePosition(character, LOWERLEG_RIGHT);

    // Отрисовка линий между ключевыми костями
    ImGui::GetBackgroundDrawList()->AddLine(ImVec2(headPos.x, headPos.y), ImVec2(chestPos.x, chestPos.y), CTColor, 1.0f);             // Голова -> Грудь
    ImGui::GetBackgroundDrawList()->AddLine(ImVec2(chestPos.x, chestPos.y), ImVec2(leftShoulderPos.x, leftShoulderPos.y), CTColor, 1.0f);     // Грудь -> Левое плечо
    ImGui::GetBackgroundDrawList()->AddLine(ImVec2(chestPos.x, chestPos.y), ImVec2(rightShoulderPos.x, rightShoulderPos.y), CTColor, 1.0f);    // Грудь -> Правое плечо
    ImGui::GetBackgroundDrawList()->AddLine(ImVec2(leftShoulderPos.x, leftShoulderPos.y), ImVec2(leftElbowPos.x, leftElbowPos.y), CTColor, 1.0f); // Левое плечо -> Левый локоть
    ImGui::GetBackgroundDrawList()->AddLine(ImVec2(rightShoulderPos.x, rightShoulderPos.y), ImVec2(rightElbowPos.x, rightElbowPos.y), CTColor, 1.0f); // Правое плечо -> Правый локоть
    ImGui::GetBackgroundDrawList()->AddLine(ImVec2(leftShoulderPos.x, leftShoulderPos.y), ImVec2(leftHipPos.x, leftHipPos.y), CTColor, 1.0f);   // Левое плечо -> Левое бедро
    ImGui::GetBackgroundDrawList()->AddLine(ImVec2(rightShoulderPos.x, rightShoulderPos.y), ImVec2(rightHipPos.x, rightHipPos.y), CTColor, 1.0f); // Правое плечо -> Правое бедро
    ImGui::GetBackgroundDrawList()->AddLine(ImVec2(leftHipPos.x, leftHipPos.y), ImVec2(leftKneePos.x, leftKneePos.y), CTColor, 1.0f);       // Левое бедро -> Левое колено
    ImGui::GetBackgroundDrawList()->AddLine(ImVec2(rightHipPos.x, rightHipPos.y), ImVec2(rightKneePos.x, rightKneePos.y), CTColor, 1.0f);     // Правое бедро -> Правое колено
}



if (esp3d && characterz[i].screenPos.z > 0.01 && character != nullptr) {
    Vector3 boxVertices[8];
    float boxHeight = 1.6f; // Высота бокса
    float boxWidth = 1.0f; // Ширина бокса
    float boxDepth = 1.0f; // Глубина бокса
    
    // Определяем координаты 8 вершин бокса в мировом пространстве
    boxVertices[0] = Vector3(pos.x - boxWidth / 2, pos.y, pos.z - boxDepth / 2);
    boxVertices[1] = Vector3(pos.x + boxWidth / 2, pos.y, pos.z - boxDepth / 2);
    boxVertices[2] = Vector3(pos.x + boxWidth / 2, pos.y, pos.z + boxDepth / 2);
    boxVertices[3] = Vector3(pos.x - boxWidth / 2, pos.y, pos.z + boxDepth / 2);
    boxVertices[4] = Vector3(pos.x - boxWidth / 2, pos.y + boxHeight, pos.z - boxDepth / 2);
    boxVertices[5] = Vector3(pos.x + boxWidth / 2, pos.y + boxHeight, pos.z - boxDepth / 2);
    boxVertices[6] = Vector3(pos.x + boxWidth / 2, pos.y + boxHeight, pos.z + boxDepth / 2);
    boxVertices[7] = Vector3(pos.x - boxWidth / 2, pos.y + boxHeight, pos.z + boxDepth / 2);

    // Проецируем координаты вершин на экран
    Vector3 screenVertices[8];
    for (int j = 0; j < 8; j++) {
        Vector4 point4 = Vector4(boxVertices[j].x, boxVertices[j].y, boxVertices[j].z, 1);
        Vector4 result4 = VP * point4;
        screenVertices[j].x = result4.x / -result4.w;
        screenVertices[j].y = result4.y / -result4.w;
        screenVertices[j].z = result4.z / -result4.w;
        screenVertices[j].x = screenVertices[j].x / 2 + 0.5f;
        screenVertices[j].y = screenVertices[j].y / 2 + 0.5f;
        screenVertices[j].x *= [[UIScreen mainScreen] bounds].size.width;
        screenVertices[j].y = [[UIScreen mainScreen] bounds].size.height - screenVertices[j].y * [[UIScreen mainScreen] bounds].size.height;
    }

    if (boxMode == 1) {
        if (isT) {
            Draw3DBox(screenVertices, TColor, 1.0f);
        }
    } else if (boxMode == 2) {
        if (isCT) {
            Draw3DBox(screenVertices, CTColor, 1.0f);
        }
    }
}

                                    if (esplines && characterz[i].screenPos.z > 0.01 && character != nullptr) {
                                    ImVec2 start = ImVec2([[UIScreen mainScreen]bounds].size.width / 2, 0);
                                    ImVec2 end = ImVec2(xx + dy / 4, yy);

                                    ImColor lineColor = ImColor(0,0,0);
                                    ImColor lineColor1 = ImColor(255,255,255);
                                    if (boxMode == 1){
            if (isT) {
            //ImGui::GetBackgroundDrawList()->AddLine(start, end, lineColor, 2);
            ImGui::GetBackgroundDrawList()->AddLine(start, end, TlineColor1, 1);
        }
    }
        if (boxMode == 2){
            if (isCT) {
                //ImGui::GetBackgroundDrawList()->AddLine(start, end, lineColor, 2);
                ImGui::GetBackgroundDrawList()->AddLine(start, end, CTlineColor1, 1);
            }
        }

                                    //NSLog(@"ESP line drawn for character %d", i);
           
                                }
                                if(espboxes && characterz[i].screenPos.z > 0.01 && character != nullptr){
        if (boxMode == 1){
            if (isT) {
                //if(espout)
                    DrawOutlinedBox2(xx,yy,dx,dy,CTColor,0,2);
            //DrawBox(xx, yy, dx, dy, TColor, 0, 1);
// T
        }
    }
        if (boxMode == 2){
            if (isCT) {
                //if(espout)
                    DrawOutlinedBox2(xx,yy,dx,dy,CTColor,0,2);
            //DrawBox(xx, yy, dx, dy, CTColor, 0, 1);
// CT
            }
        }


                                }
                            }
                        }
                    }
                }
            }
        }
    }
}


/*if (cheat_on) {
    void *typeinfo_gmodule = *(void **)getRealOffset(0x3E23BA8);
    void *(*get_localcharacter)(void *thiz) = (void *(*)(void *))getRealOffset(0x1CA3A28);
    void *(*get_localPlayer)(void *thiz) = (void *(*)(void *))getRealOffset(0x1CA3D14);
    void *(*Get_trans)(void *thiz) = (void *(*)(void *))getRealOffset(ENCRYPTOFFSET("0x2E8BCB4"));
    void (*get_pos_inj)(void *thiz, Vector3* output) = (void (*)(void *, Vector3 *))getRealOffset(ENCRYPTOFFSET("0x2E9A8A0"));
    bool (*isEnemyOf)(int* a) = (bool (*)(int*)) getRealOffset(ENCRYPTOFFSET("0x1C26698"));

    void* local_player = nullptr;
    Vector3 localPos;
    Vector3 pos;

    if (typeinfo_gmodule != nullptr) {
        NSLog(@"typeinfo_gmodule accessed");
        void *static_gmodule = *(void **)((uint64_t)typeinfo_gmodule + 0xb8);
        if (static_gmodule != nullptr) {
            NSLog(@"static_gmodule accessed");
            void *GameplayModule = *(void **)((uint64_t)static_gmodule + 0x0);
            if (GameplayModule) {
                void *gameSystem = *(void **)((uint64_t)GameplayModule + 0x10);
                if (gameSystem) {
                    local_player = get_localPlayer(gameSystem);
                    if (local_player != nullptr){
                        void *playerProps = *(void **)((uint64_t)local_player + 0xC8);
                        if (playerProps != nullptr){
                            void *boxedValue = *(void **)((uint64_t)playerProps + 0xC8);
                            if (boxedValue != nullptr){
                                localTeam = *(int *)((uint64_t)boxedValue + 0x10);
                            }
                        }
                    }
                    monoList<void**> *characters = *(monoList<void**> **)((uint64_t)gameSystem + 0xC0);
                    if (characters != nullptr) {
                        for (int i = 0; i < characters->getSize(); i++) {
                            void* character = characters->getItems()[i];
                            if (character != nullptr) {
                                if (radar)
                                    *(bool *)((uint64_t)character + 0x20) = true;
                                characterz[i].player = *(void **)((uint64_t)character + 0x130);
                                if(characterz[i].player != nullptr){
                                    characterz[i].teamBoxed = *(void **)((uint64_t)characterz[i].player + 0xC8);
                                    if(characterz[i].teamBoxed != nullptr){
                                        characterz[i].team = *(int *)((uint64_t)characterz[i].teamBoxed + 0x10);
                                        if(characterz[i].team != localTeam){
                                            characterz[i].enemy = true;
                                        }else{
                                            characterz[i].enemy = false;
                                        }
                                    }
                                }
                                get_pos_inj(Get_trans(character), &pos);
                                Matrix4x4 (*get_ProjectionMatrix)(void *) = (Matrix4x4 (*)(void *))getRealOffset(ENCRYPTOFFSET("0x2E58A08"));
                                Matrix4x4 (*worldToLocalMatrix)(void *thiz) = (Matrix4x4 (*)(void *))getRealOffset(ENCRYPTOFFSET("0x2E9B564"));
                                Matrix4x4 P = get_ProjectionMatrix(get_main());
                                void *cameraTrans = Get_trans(get_main());
                                Matrix4x4 V = worldToLocalMatrix(cameraTrans);
                                Matrix4x4 VP = P * V;

                                Vector4 point4 = Vector4(pos.x, pos.y + 1.222, pos.z, 1);
                                Vector4 result4 = VP * point4;
                                Vector3 result;
                                result.x = result4.x;
                                result.y = result4.y;
                                result.z = result4.z;
                                result /= -result4.w;
                                result.x = result.x / 2 + 0.5f;
                                result.y = result.y / 2 + 0.5f;
                                result.z = -result4.w;

                                Vector3 screenPos = result;
                                screenPos.x *= [[UIScreen mainScreen]bounds].size.width;
                                screenPos.y = [[UIScreen mainScreen]bounds].size.height - screenPos.y * [[UIScreen mainScreen]bounds].size.height;

                                characterz[i].screenPos = screenPos;

                                if (esplines && character != nullptr) {
                                    Vector3 newvec = characterz[i].screenPos;
                                    float dx = 100.0f / (newvec.z / 4);
                                    float dy = 200.0f / (newvec.z / 4);
                                    float xx = newvec.x - dx / 2;
                                    float yy = newvec.y - dy / 4;

                                    ImVec2 start = ImVec2([[UIScreen mainScreen]bounds].size.width / 2, 0);
                                    ImVec2 end = ImVec2(xx + dy / 4, yy);

                                    ImColor lineColor;
                                    if (characterz[i].enemy) {
                                        lineColor = ImColor(255,255,255);
                                    } else {
                                        lineColor = ImColor(0,0,0);
                                    }

                                    ImGui::GetBackgroundDrawList()->AddLine(start, end, lineColor, 0.9);

                                    NSLog(@"ESP line drawn for character %d", i);
                                }

                                if (espboxes && characterz[i].screenPos.z > 0.01 && character != nullptr){
                                    Vector3 newvec = characterz[i].screenPos;
                                    float dx = 100.0f / (newvec.z / 4);
                                    float dy = 200.0f / (newvec.z / 4);
                                    float xx = newvec.x - dx / 2;
                                    float yy = newvec.y - dy / 4;

                                    if (characterz[i].enemy){
                                        DrawBox(xx, yy, dx, dy, ImColor(255,255,255), 1, 1);
                                    } else {
                                        DrawBox(xx, yy, dx, dy, ImColor(0,0,0), 1, 1);
                                        DrawBox(xx, yy, dx, dy, ImColor(0,0,0), 1, 1);
                                        DrawBox(xx, yy, dx, dy, ImColor(0,0,255), 1, 1);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}*/




/*if (cheat_on) {
    void *typeinfo_gmodule = *(void **)getRealOffset(0x3E23BA8);
    void *(*get_localcharacter)(void *thiz) = (void *(*)(void *))getRealOffset(0x1CA3A28);
    void *(*get_localPlayer)(void *thiz) = (void *(*)(void *))getRealOffset(0x1CA3D14);

    void* local_player = nullptr;
    Vector3 localPos;

    if (typeinfo_gmodule != nullptr) {
        NSLog(@"typeinfo_gmodule accessed");
        void *static_gmodule = *(void **)((uint64_t)typeinfo_gmodule + 0xb8);
        if (static_gmodule != nullptr) {
            NSLog(@"static_gmodule accessed");
            void *GameplayModule = *(void **)((uint64_t)static_gmodule + 0x0);
            if (GameplayModule) {
                void *gameSystem = *(void **)((uint64_t)GameplayModule + 0x10);
                if (gameSystem) {
                    local_player = get_localcharacter(gameSystem);
                    monoList<void**> *characters = *(monoList<void**> **)((uint64_t)gameSystem + 0xC0);
                    if (characters != nullptr) {
                        for (int i = 0; i < characters->getSize(); i++) {
                            void* character = characters->getItems()[i];
                            if (character != nullptr) {
                                if (radar)
                                    *(bool *)((uint64_t)character + 0x20) = true;
                            }
                            counter = characters->getSize();
                            characterz[i].object = characters->getItems()[i];
                            if (characterz[i].object != nullptr) {
                                characterz[i].health = *(int *)((uint64_t)characterz[i].object + 0x13C);
                                characterz[i].initialized = *(int *)((uint64_t)characterz[i].object + 0xF8);
                                if (characterz[i].initialized) {
                                    if (character != nullptr) {
                                        Vector3 localPos;
                                        void *localPlayer = get_localPlayer(gameSystem);
                                        if (localPlayer != nullptr) {
                                            // void *boxedValue = *(void **)((uint64_t))getRealOffset(0x20654CC);
                                        }
                                        void *(*Get_trans)(void *thiz) = (void *(*)(void *))getRealOffset(ENCRYPTOFFSET("0x2E8BCB4"));
                                        if ((void*)Get_trans != nullptr) {
                                            characterz[i].transforms = Get_trans(characterz[i].object);
                                            void (*get_pos_inj)(void *thiz, Vector3* output) = (void (*)(void *, Vector3 *))getRealOffset(ENCRYPTOFFSET("0x2E9A8A0"));
                                            if ((void*)get_pos_inj != nullptr) {
                                                get_pos_inj(characterz[i].transforms, &characterz[i].position);
                                                void *(*get_main)() = (void *(*)())getRealOffset(ENCRYPTOFFSET("0x2E5A194"));
                                                void *localch = get_localcharacter(gameSystem);
                                                if (localch != nullptr) {
                                                    void *localTrans = Get_trans(localch);
                                                    if (localTrans != nullptr) {
                                                        get_pos_inj(localTrans, &localPos);
                                                        if (characterz[i].inside()) {
                                                            Vector3 angles = ToEulerRad(GetRotationToLocation(characterz[i].position, -0.65f, localPos));
                                                            Vector2 rotation;
                                                            rotation.x = angles.x;
                                                            rotation.y = angles.y;
                                                            if (rotation.x >= 275.f)
                                                                rotation.x -= 360.f;
                                                            if (rotation.x <= -275.f)
                                                                rotation.x += 360.f;
                                                        }
                                                    }
                                                }
                                                Matrix4x4 (*get_ProjectionMatrix)(void *) = (Matrix4x4 (*)(void *))getRealOffset(ENCRYPTOFFSET("0x2E58A08"));
                                                Matrix4x4 (*worldToLocalMatrix)(void *thiz) = (Matrix4x4 (*)(void *))getRealOffset(ENCRYPTOFFSET("0x2E9B564"));
                                                Matrix4x4 P = get_ProjectionMatrix(get_main());
                                                void *cameraTrans = Get_trans(get_main());
                                                Matrix4x4 V = worldToLocalMatrix(cameraTrans);
                                                Matrix4x4 VP = P * V;
                                                Vector4 point4 = Vector4(characterz[i].position.x, characterz[i].position.y + 1.222, characterz[i].position.z, 1);
                                                Vector4 result4 = VP * point4;
                                                Vector3 result;
                                                result.x = result4.x;
                                                result.y = result4.y;
                                                result.z = result4.z;
                                                result /= -result4.w;
                                                result.x = result.x / 2 + 0.5f;
                                                result.y = result.y / 2 + 0.5f;
                                                result.z = -result4.w;
                                                screenz = result;
                                                screenz.x *= [[UIScreen mainScreen]bounds].size.width;
                                                screenz.y = [[UIScreen mainScreen]bounds].size.height - screenz.y * [[UIScreen mainScreen]bounds].size.height;
                                                characterz[i].screenPos = screenz;
                                            }
                                        }
                                    }
                                }
                            }
                            // Adding the new block here inside the loop
                            NSLog(@"Character %d: esplines = %d, screenPos.z = %f, object = %p", i, esplines, characterz[i].screenPos.z, characterz[i].object);
                            if (esplines && characterz[i].screenPos.z > 0.01 && characterz[i].object != nullptr) {
    Vector3 newvec = characterz[i].screenPos;
    NSLog(@"Drawing line for character %d at screen position: (%f, %f, %f)", i, newvec.x, newvec.y, newvec.z);
    float dx = 100.0f / (newvec.z / 4);
    float dy = 200.0f / (newvec.z / 4);
    float xx = newvec.x - dx / 2;
    float yy = newvec.y - dy / 4;
    if (characterz[i].enemy)
        ImGui::GetWindowDrawList()->AddLine(
            ImVec2([[UIScreen mainScreen] bounds].size.width / 2, 0),
            ImVec2(xx + dy / 4, yy),
            ImColor(enemyColors[0], enemyColors[1], enemyColors[2], characterz[i].color4),
            0.9f
        );
    else
        ImGui::GetWindowDrawList()->AddLine(
            ImVec2([[UIScreen mainScreen] bounds].size.width / 2, 0),
            ImVec2(xx + dy / 4, yy),
            ImColor(teamColors[0], teamColors[1], teamColors[2], characterz[i].color4),
            0.9f
        );
}
        if(espboxes && characterz[i].screenPos.z > 0.01 && characterz[i].object != nullptr){
        
        Vector3 newvec = characterz[i].screenPos;
        float dx = 100.0f/(newvec.z/4);
        float dy = 200.0f/(newvec.z/4);
        float xx = newvec.x-dx/2;
        float yy = newvec.y-dy/4;
          DrawBox(xx, yy, dx, dy, ImColor(enemyColors[0], enemyColors[1], enemyColors[2], characterz[i].color4), 1, 1);
        }
                        }
                        NSLog(@"gamesystem accessed");
                    }
                }
            }
        }
    }
}


*/


/*void *typeinfo_gmodule = *(void **)getRealOffset(0x1CB0D60);
  if(typeinfo_gmodule != nullptr) {
    void *static_gmodule = *(void **)((uint64_t)typeinfo_gmodule + 0xb8);
    if(static_gmodule != nullptr) {
        void *gamesystem = *(void **)((uint64_t)static_gmodule + 0x10);
      if(gmodule)
{
        monoList<void**> *characters = *(monoList<void**> **)((uint64_t)gamesystem + 0xC0);
        if(characters != nullptr) {
            for(int i = 0; i<characters->getSize(); i++) {
                void* character = characters->getItems()[i];
                if(character != nullptr) {
                    if (radar) {
                        *(bool *)((uint64_t)character + 0x20) = true;
                    }
                }
            }
        }
    }
  }*/
              
    

        
            ImDrawList* draw_list = ImGui::GetForegroundDrawList();

            
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


