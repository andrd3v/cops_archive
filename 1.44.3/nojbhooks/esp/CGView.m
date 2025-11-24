#import "CGView.h"
#import <Foundation/Foundation.h>

@implementation CGView

unsigned int (*enemyboxes)[4];
unsigned int enemyboxesCount;


unsigned int (*enemyBounds)[4];
unsigned int enemyBoundsCount;



unsigned int (*enemylines)[2];
unsigned int enemylinesCount;



unsigned int waterCount;


- (id)initWithFrame:(UIWindow *)drawWindow
{

    self = [super initWithFrame:drawWindow.frame];
    self.userInteractionEnabled = false;
    self.backgroundColor = [UIColor clearColor];
    
    if (self) {
        enemyboxes = (unsigned int (*)[4])malloc(0);
        enemyboxesCount = 0;
        enemyBounds = (unsigned int (*)[4])malloc(0);
        enemyBoundsCount = 0;
        enemylines = (unsigned int (*)[2])malloc(0);
        enemylinesCount = 0;
    }

    [drawWindow addSubview: self];
    return self;
}








-(void)drawRect:(CGRect)rect
{

CGContextRef context = UIGraphicsGetCurrentContext();
CGContextSetAlpha(context, 255);

    
    for (int i = 0; i < enemyboxesCount; i++) {


        UIBezierPath *path = [UIBezierPath bezierPathWithRect:CGRectMake(enemyboxes[i][0], enemyboxes[i][1], enemyboxes[i][2], enemyboxes[i][3])];
        path.lineWidth = ([[UIScreen mainScreen] bounds].size.width * 1/600);
        [[UIColor whiteColor] setStroke];
        [path stroke];
        
        
        NSString *text = @"TG: @andrhackios"; // Текст, который хочешь отображать
        UIFont *font = [UIFont systemFontOfSize:7.0]; // Размер шрифта
        UIColor *textColor = [UIColor blackColor]; // Цвет текста
        
        NSDictionary *attributes = @{
            NSFontAttributeName: font,
            NSForegroundColorAttributeName: textColor
        };
        
        CGSize textSize = [text sizeWithAttributes:attributes];
        CGPoint textOrigin = CGPointMake(enemyboxes[i][0], enemyboxes[i][1] + enemyboxes[i][3] + 4); // Подстроить отступ по желанию
        
        [text drawAtPoint:textOrigin withAttributes:attributes];

    }

    for (int i = 0; i < enemyBoundsCount; i++) {
        float x = enemyBounds[i][0];
        float y = enemyBounds[i][1];
        float w = enemyBounds[i][2];
        float h = enemyBounds[i][3];
        float cornerSize = 6.0; // Размер углов

        UIBezierPath *topLeftCorner = [UIBezierPath bezierPath];
        [topLeftCorner moveToPoint:CGPointMake(x, y + cornerSize)];
        [topLeftCorner addLineToPoint:CGPointMake(x, y)];
        [topLeftCorner addLineToPoint:CGPointMake(x + cornerSize, y)];
        [[UIColor whiteColor] setStroke];
        [topLeftCorner stroke];

        UIBezierPath *topRightCorner = [UIBezierPath bezierPath];
        [topRightCorner moveToPoint:CGPointMake(x + w - cornerSize, y)];
        [topRightCorner addLineToPoint:CGPointMake(x + w, y)];
        [topRightCorner addLineToPoint:CGPointMake(x + w, y + cornerSize)];
        [[UIColor whiteColor] setStroke];
        [topRightCorner stroke];

        UIBezierPath *bottomLeftCorner = [UIBezierPath bezierPath];
        [bottomLeftCorner moveToPoint:CGPointMake(x, y + h - cornerSize)];
        [bottomLeftCorner addLineToPoint:CGPointMake(x, y + h)];
        [bottomLeftCorner addLineToPoint:CGPointMake(x + cornerSize, y + h)];
        [[UIColor whiteColor] setStroke];
        [bottomLeftCorner stroke];

        UIBezierPath *bottomRightCorner = [UIBezierPath bezierPath];
        [bottomRightCorner moveToPoint:CGPointMake(x + w - cornerSize, y + h)];
        [bottomRightCorner addLineToPoint:CGPointMake(x + w, y + h)];
        [bottomRightCorner addLineToPoint:CGPointMake(x + w, y + h - cornerSize)];
        [[UIColor whiteColor] setStroke];
        [bottomRightCorner stroke];
        
        
        
        NSString *text = @"TG: @andrhackios"; // Текст, который хочешь отображать
        UIFont *font = [UIFont systemFontOfSize:7.0]; // Размер шрифта
        UIColor *textColor = [UIColor blackColor]; // Цвет текста
        
        NSDictionary *attributes = @{
            NSFontAttributeName: font,
            NSForegroundColorAttributeName: textColor
        };
        
        CGSize textSize = [text sizeWithAttributes:attributes];
        CGPoint textOrigin = CGPointMake(enemyBounds[i][0], enemyBounds[i][1] + enemyBounds[i][3] + 5); // Подстроить отступ по желанию
        
        [text drawAtPoint:textOrigin withAttributes:attributes];
    }
    
    
    
    

    
    
    for (int i = 0; i < enemylinesCount; i++)
    {



        UIBezierPath *path = [UIBezierPath bezierPath];
        [path moveToPoint:CGPointMake([[UIScreen mainScreen] bounds].size.width / 2, [[UIScreen mainScreen] bounds].size.height * 0)];
        [path addLineToPoint:CGPointMake(enemylines[i][0], enemylines[i][1])];
        path.lineWidth = [[UIScreen mainScreen] bounds].size.width * 1/600;
        [[UIColor whiteColor] setStroke];
        [path stroke];
    }

    
    
    
    [self clearDraw];
}






-(void) addEnemyBox:(float)x y:(float)y w:(float)w h:(float)h {
    enemyboxesCount++;
    enemyboxes = (unsigned int (*)[4])realloc(enemyboxes, enemyboxesCount*sizeof(unsigned int[4]));
    enemyboxes[enemyboxesCount-1][0] = x;
    enemyboxes[enemyboxesCount-1][1] = y;
    enemyboxes[enemyboxesCount-1][2] = w;
    enemyboxes[enemyboxesCount-1][3] = h;
}





- (void)addEnemyBounds:(float)x y:(float)y w:(float)w h:(float)h {
    enemyBoundsCount++;
    enemyBounds = (unsigned int (*)[4])realloc(enemyBounds, enemyBoundsCount * sizeof(unsigned int[4]));
    enemyBounds[enemyBoundsCount - 1][0] = x;
    enemyBounds[enemyBoundsCount - 1][1] = y;
    enemyBounds[enemyBoundsCount - 1][2] = w;
    enemyBounds[enemyBoundsCount - 1][3] = h;
}








-(void) addEnemyLine:(float)x y:(float)y {
    enemylinesCount++;
    enemylines = (unsigned int (*)[2])realloc(enemylines, enemylinesCount*sizeof(unsigned int[2]));
    enemylines[enemylinesCount-1][0] = x;
    enemylines[enemylinesCount-1][1] = y;
}






-(void)clearDraw {
    enemyboxesCount = 0;
    enemyboxes = (unsigned int (*)[4])realloc(enemyboxes, enemyboxesCount*sizeof(unsigned int[4]));


    
    enemyBoundsCount = 0;
    enemyBounds = (unsigned int (*)[4])realloc(enemyBounds, enemyBoundsCount*sizeof(unsigned int[4]));
    
    
    
    
    
    enemylinesCount = 0;
    enemylines = (unsigned int (*)[2])realloc(enemylines, enemylinesCount*sizeof(unsigned int[2]));

    


    
}

@end
