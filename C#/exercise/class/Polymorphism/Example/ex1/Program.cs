using ex1;

Console.WriteLine("请输入举行的长");
double rLen = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("请输入举行的宽 ");
double rWid = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("请输入三角形边长");
double tSide = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("请输入三角形的高 ");
double tHeigh = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(("请输入圆的半径:"));
double cR = Convert.ToDouble(Console.ReadLine());

Rectangle r = new Rectangle(rLen, rWid);
Triangle t = new Triangle(tSide, tHeigh);
Circle circle = new Circle(cR);

Caller c = new Caller();

c.CallerArea(r);
c.CallerArea(t);
c.CallerArea(circle);

