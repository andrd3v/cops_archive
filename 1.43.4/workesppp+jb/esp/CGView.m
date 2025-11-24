#import "CGView.h"
#import <Foundation/Foundation.h>

@implementation CGView

unsigned int (*enemyboxes)[4];
unsigned int enemyboxesCount;


unsigned int (*enemyBounds)[4];
unsigned int enemyBoundsCount;



unsigned int (*enemylines)[2];
unsigned int enemylinesCount;


unsigned int (*enemyhbars)[5];
unsigned int enemyhbarsCount;






unsigned int (*teamboxes)[4];
unsigned int teamboxesCount;


unsigned int (*teamBounds)[4];
unsigned int teamBoundsCount;




unsigned int (*teamlines)[2];
unsigned int teamlinesCount;


unsigned int (*teamhbars)[5];
unsigned int teamhbarsCount;




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
        enemyhbars = (unsigned int (*)[5])malloc(0);
        enemyhbarsCount = 0;
        
        
        
        
        teamboxes = (unsigned int (*)[4])malloc(0);
        teamboxesCount = 0;
        teamBounds = (unsigned int (*)[4])malloc(0);
        teamBoundsCount = 0;
        teamlines = (unsigned int (*)[2])malloc(0);
        teamlinesCount = 0;
        teamhbars = (unsigned int (*)[5])malloc(0);
        teamhbarsCount = 0;
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
        [[UIColor redColor] setStroke];
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
        [[UIColor redColor] setStroke];
        [topLeftCorner stroke];

        UIBezierPath *topRightCorner = [UIBezierPath bezierPath];
        [topRightCorner moveToPoint:CGPointMake(x + w - cornerSize, y)];
        [topRightCorner addLineToPoint:CGPointMake(x + w, y)];
        [topRightCorner addLineToPoint:CGPointMake(x + w, y + cornerSize)];
        [[UIColor redColor] setStroke];
        [topRightCorner stroke];

        UIBezierPath *bottomLeftCorner = [UIBezierPath bezierPath];
        [bottomLeftCorner moveToPoint:CGPointMake(x, y + h - cornerSize)];
        [bottomLeftCorner addLineToPoint:CGPointMake(x, y + h)];
        [bottomLeftCorner addLineToPoint:CGPointMake(x + cornerSize, y + h)];
        [[UIColor redColor] setStroke];
        [bottomLeftCorner stroke];

        UIBezierPath *bottomRightCorner = [UIBezierPath bezierPath];
        [bottomRightCorner moveToPoint:CGPointMake(x + w - cornerSize, y + h)];
        [bottomRightCorner addLineToPoint:CGPointMake(x + w, y + h)];
        [bottomRightCorner addLineToPoint:CGPointMake(x + w, y + h - cornerSize)];
        [[UIColor redColor] setStroke];
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
        [[UIColor redColor] setStroke];
        [path stroke];
    }

    for (int i = 0; i < enemyhbarsCount; i++) {
        float health = enemyhbars[i][4];
        UIColor *fillColor;
        
        
        if (health > 70) {
            fillColor = [UIColor greenColor];
        } else if (health >= 40) {
            fillColor = [UIColor yellowColor];
        } else {
            fillColor = [UIColor redColor];
        }


        UIBezierPath *path = [UIBezierPath bezierPathWithRect:CGRectMake(enemyhbars[i][0], enemyhbars[i][1], enemyhbars[i][2], enemyhbars[i][3] * enemyhbars[i][4] / 100.f)];
        path.lineWidth = [[UIScreen mainScreen] bounds].size.width * 1/600;
        [fillColor setFill];
        [path fill];
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    for (int i = 0; i < teamboxesCount; i++) {


        UIBezierPath *path = [UIBezierPath bezierPathWithRect:CGRectMake(teamboxes[i][0], teamboxes[i][1], teamboxes[i][2], teamboxes[i][3])];
        path.lineWidth = ([[UIScreen mainScreen] bounds].size.width * 1/600);
        [[UIColor blueColor] setStroke];
        [path stroke];
        
        
        
        NSString *text = @"TG: @andrhackios"; // Текст, который хочешь отображать
        UIFont *font = [UIFont systemFontOfSize:7.0]; // Размер шрифта
        UIColor *textColor = [UIColor blackColor]; // Цвет текста
        
        NSDictionary *attributes = @{
            NSFontAttributeName: font,
            NSForegroundColorAttributeName: textColor
        };
        
        CGSize textSize = [text sizeWithAttributes:attributes];
        CGPoint textOrigin = CGPointMake(teamboxes[i][0], teamboxes[i][1] + teamboxes[i][3] + 4); // Подстроить отступ по желанию
        
        [text drawAtPoint:textOrigin withAttributes:attributes];

    }

    for (int i = 0; i < teamBoundsCount; i++) {
        float x = teamBounds[i][0];
        float y = teamBounds[i][1];
        float w = teamBounds[i][2];
        float h = teamBounds[i][3];
        float cornerSize = 6.0; // Размер углов

        UIBezierPath *topLeftCornert = [UIBezierPath bezierPath];
        [topLeftCornert moveToPoint:CGPointMake(x, y + cornerSize)];
        [topLeftCornert addLineToPoint:CGPointMake(x, y)];
        [topLeftCornert addLineToPoint:CGPointMake(x + cornerSize, y)];
        [[UIColor blueColor] setStroke];
        [topLeftCornert stroke];

        UIBezierPath *topRightCornert = [UIBezierPath bezierPath];
        [topRightCornert moveToPoint:CGPointMake(x + w - cornerSize, y)];
        [topRightCornert addLineToPoint:CGPointMake(x + w, y)];
        [topRightCornert addLineToPoint:CGPointMake(x + w, y + cornerSize)];
        [[UIColor blueColor] setStroke];
        [topRightCornert stroke];

        UIBezierPath *bottomLeftCornert = [UIBezierPath bezierPath];
        [bottomLeftCornert moveToPoint:CGPointMake(x, y + h - cornerSize)];
        [bottomLeftCornert addLineToPoint:CGPointMake(x, y + h)];
        [bottomLeftCornert addLineToPoint:CGPointMake(x + cornerSize, y + h)];
        [[UIColor blueColor] setStroke];
        [bottomLeftCornert stroke];

        UIBezierPath *bottomRightCornert = [UIBezierPath bezierPath];
        [bottomRightCornert moveToPoint:CGPointMake(x + w - cornerSize, y + h)];
        [bottomRightCornert addLineToPoint:CGPointMake(x + w, y + h)];
        [bottomRightCornert addLineToPoint:CGPointMake(x + w, y + h - cornerSize)];
        [[UIColor blueColor] setStroke];
        [bottomRightCornert stroke];
        
        
        
        NSString *textt = @"TG: @andrhackios"; // Текст, который хочешь отображать
        UIFont *fontt = [UIFont systemFontOfSize:7.0]; // Размер шрифта
        UIColor *textColort = [UIColor blackColor]; // Цвет текста
        
        NSDictionary *attributest = @{
            NSFontAttributeName: fontt,
            NSForegroundColorAttributeName: textColort
        };
        
        CGSize textSizet = [textt sizeWithAttributes:attributest];
        CGPoint textOrigint = CGPointMake(teamBounds[i][0], teamBounds[i][1] + teamBounds[i][3] + 5); // Подстроить отступ по желанию
        
        [textt drawAtPoint:textOrigint withAttributes:attributest];
    }
    
    
    
    



    
    
    for (int i = 0; i < teamlinesCount; i++)
    {



        UIBezierPath *path = [UIBezierPath bezierPath];
        [path moveToPoint:CGPointMake([[UIScreen mainScreen] bounds].size.width / 2, [[UIScreen mainScreen] bounds].size.height * 0)];
        [path addLineToPoint:CGPointMake(teamlines[i][0], teamlines[i][1])];
        path.lineWidth = [[UIScreen mainScreen] bounds].size.width * 1/600;
        [[UIColor blueColor] setStroke];
        [path stroke];
    }
    
    
    
    
    

    for (int i = 0; i < teamhbarsCount; i++) {
        float health = teamhbars[i][4];
        UIColor *fillColor;
        
        
        if (health > 70) {
            fillColor = [UIColor greenColor];
        } else if (health >= 40) {
            fillColor = [UIColor yellowColor];
        } else {
            fillColor = [UIColor redColor];
        }


        UIBezierPath *path = [UIBezierPath bezierPathWithRect:CGRectMake(teamhbars[i][0], teamhbars[i][1], teamhbars[i][2], teamhbars[i][3] * teamhbars[i][4] / 100.f)];
        path.lineWidth = [[UIScreen mainScreen] bounds].size.width * 1/600;
        [fillColor setFill];
        [path fill];
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


-(void) addTeamBox:(float)x y:(float)y w:(float)w h:(float)h {
    teamboxesCount++;
    teamboxes = (unsigned int (*)[4])realloc(teamboxes, teamboxesCount*sizeof(unsigned int[4]));
    teamboxes[teamboxesCount-1][0] = x;
    teamboxes[teamboxesCount-1][1] = y;
    teamboxes[teamboxesCount-1][2] = w;
    teamboxes[teamboxesCount-1][3] = h;
}





- (void)addEnemyBounds:(float)x y:(float)y w:(float)w h:(float)h {
    enemyBoundsCount++;
    enemyBounds = (unsigned int (*)[4])realloc(enemyBounds, enemyBoundsCount * sizeof(unsigned int[4]));
    enemyBounds[enemyBoundsCount - 1][0] = x;
    enemyBounds[enemyBoundsCount - 1][1] = y;
    enemyBounds[enemyBoundsCount - 1][2] = w;
    enemyBounds[enemyBoundsCount - 1][3] = h;
}


- (void)addTeamBounds:(float)x y:(float)y w:(float)w h:(float)h {
    teamboxesCount++;
    teamBounds = (unsigned int (*)[4])realloc(teamBounds, teamBoundsCount*sizeof(unsigned int[4]));
    teamBounds[teamBoundsCount-1][0] = x;
    teamBounds[teamBoundsCount-1][1] = y;
    teamBounds[teamBoundsCount-1][2] = w;
    teamBounds[teamBoundsCount-1][3] = h;
}









-(void) addEnemyLine:(float)x y:(float)y {
    enemylinesCount++;
    enemylines = (unsigned int (*)[2])realloc(enemylines, enemylinesCount*sizeof(unsigned int[2]));
    enemylines[enemylinesCount-1][0] = x;
    enemylines[enemylinesCount-1][1] = y;
}


-(void) addTeamLine:(float)x y:(float)y {
    teamlinesCount++;
    teamlines = (unsigned int (*)[2])realloc(teamlines, teamlinesCount*sizeof(unsigned int[2]));
    teamlines[teamlinesCount-1][0] = x;
    teamlines[teamlinesCount-1][1] = y;
}

-(void) addEnemyHealthbar:(float)x y:(float)y w:(float)w h:(float)h health:(float)health {
    enemyhbarsCount++;
    enemyhbars = (unsigned int (*)[5])realloc(enemyhbars, enemyhbarsCount*sizeof(unsigned int[5]));
    enemyhbars[enemyhbarsCount-1][0] = x;
    enemyhbars[enemyhbarsCount-1][1] = y;
    enemyhbars[enemyhbarsCount-1][2] = w;
    enemyhbars[enemyhbarsCount-1][3] = h;
    enemyhbars[enemyhbarsCount-1][4] = health;
}


-(void) addTeamHealthbar:(float)x y:(float)y w:(float)w h:(float)h health:(float)health {
    teamhbarsCount++;
    teamhbars = (unsigned int (*)[5])realloc(teamhbars, teamhbarsCount*sizeof(unsigned int[5]));
    teamhbars[teamhbarsCount-1][0] = x;
    teamhbars[teamhbarsCount-1][1] = y;
    teamhbars[teamhbarsCount-1][2] = w;
    teamhbars[teamhbarsCount-1][3] = h;
    teamhbars[teamhbarsCount-1][4] = health;
}



-(void)clearDraw {
    enemyboxesCount = 0;
    enemyboxes = (unsigned int (*)[4])realloc(enemyboxes, enemyboxesCount*sizeof(unsigned int[4]));


    
    enemyBoundsCount = 0;
    enemyBounds = (unsigned int (*)[4])realloc(enemyBounds, enemyBoundsCount*sizeof(unsigned int[4]));
    
    
    
    
    
    enemylinesCount = 0;
    enemylines = (unsigned int (*)[2])realloc(enemylines, enemylinesCount*sizeof(unsigned int[2]));

    
    
    enemyhbarsCount = 0;
    enemyhbars = (unsigned int (*)[5])realloc(enemyhbars, enemyhbarsCount*sizeof(unsigned int[5]));
    
    
    
    
    
    
    
    
    
    
    teamboxesCount = 0;
    teamboxes = (unsigned int (*)[4])realloc(teamboxes, teamboxesCount*sizeof(unsigned int[4]));


    
    teamBoundsCount = 0;
    teamBounds = (unsigned int (*)[4])realloc(teamBounds, teamBoundsCount*sizeof(unsigned int[4]));
    
    
    
    teamlinesCount = 0;
    teamlines = (unsigned int (*)[2])realloc(teamlines, teamlinesCount*sizeof(unsigned int[2]));

    
    
    teamhbarsCount = 0;
    teamhbars = (unsigned int (*)[5])realloc(teamhbars, teamhbarsCount*sizeof(unsigned int[5]));
    
    
    
    
}

@end
