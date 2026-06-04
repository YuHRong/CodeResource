/*
必须使用  do-while  语句或  while  语句作为外部游戏循环。
英雄和怪物在开始时的生命值都为 10。
所有攻击的值都介于 1 到 10 之间。
英雄先发起攻击。
打印怪物损失的生命值，以及剩余的生命值。
如果怪物的生命值大于 0，则它会攻击英雄。
打印打印英雄损失的生命值，以及剩余的生命值。
继续此攻击顺序，直到怪物或英雄任意一方的生命值为零或更低。
打印胜利者。
*/

Random random = new Random();
int heroHealth = 10;
int monsterHealth = 10;

do
{
 int heroAttack = random.Next(1, 11);
 monsterHealth -= heroAttack;

 Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {monsterHealth} health.");

 if (monsterHealth > 0)
 {
int monsterAttack = random.Next(1, 11);
 heroHealth -= monsterAttack;
 Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and now has {heroHealth} health.");
 }
} while (heroHealth > 0 && monsterHealth > 0);

if(monsterHealth <=0)
Console.WriteLine("Hero wins!");
else
Console.WriteLine("Monster wins!");

/*
参考答案：
int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
*/