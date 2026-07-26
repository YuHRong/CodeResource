// 将 练习 52 使用 OOP 进行编写

#include <iostream>
#include <cmath>
#include <string>

const double ANGLE_TOTAL = 180.0;
const double EPSILON = 0.0001;

class Triangle
{
private: // 私有成员
 double angle1, angle2;

public:
 // 构造函数
 Triangle(double an1, double an2) : angle1(an1), angle2(an2) {}

 // getter setter 函数
 // setter 函数
 void setAngle1(double an1)
 {
  angle1 = an1;
 }

 void setAngle2(double an2)
 {
  angle2 = an2;
 }

 // getter 函数
 double getAngle1() const
 {
  return angle1;
 }

 double getAngle2() const
 {
  return angle2;
 }

 // 计算第三个角的函数
 double tAngle3() const
 {
  return ANGLE_TOTAL - (angle1 + angle2);
 }

 // 判断是否为退化三角形
 bool is_degenerate() const
 {
  double a = angle1;
  double b = angle2;
  double c = tAngle3();
  // 返回退化值
  return a <= EPSILON || b <= EPSILON || c <= EPSILON;
 }

 // 判断三角形类型
 std::string getTriangleType() const
 {
  double a = angle1;
  double b = angle2;
  double c = tAngle3();

  if (abs(a - 90.0) < EPSILON || abs(b - 90.0) < EPSILON || abs(c - 90.0) < EPSILON)
   return "这是一个直角三角形。";
  else if (a > (90.0 + EPSILON) || b > (90.0 + EPSILON) || c > (90.0 + EPSILON))
   return "这是一个钝角三角形。";
  else
   return "这是一个锐角三角形。";
 }
};

// << 运算符重在
std::ostream &operator<<(std::ostream &p, const Triangle &t)
{
 p << "三角形信息： " << std::endl;
 p << "--------------------------------------------------\n";
 p << "三角形的第一个角 = " << t.getAngle1() << std::endl;
 p << "第二个角 = " << t.getAngle2() << std::endl;
 p << "第三个角 = " << t.tAngle3() << "。\n";

 if (t.is_degenerate())
 {
  p << "  警告！这是一个几乎退化的三角形。\n";
 }

 p << t.getTriangleType() << "";

 return p;
}

int main()
{
 double angle1, angle2;

 std::cout << "输入三角形的第一个角 ";
 std::cin >> angle1;
 if (std::cin.fail())
 {
  std::cerr << "第一个值输入错误！请输入一个大于 0 的整数\n";
  return 1;
 }

 std::cout << "请输入三角形的第二个角 ";
 std::cin >> angle2;
 if (std::cin.fail())
 {
  std::cerr << "第二个值输入错误，请输入一个大于 0 的整数\n";
  return 1;
 }

 // 检查两个角的值
 if (angle1 <= 0 || angle2 <= 0)
 { // 检查获取的两个角度是否小于等于 0
  std::cerr << "错误，三角形的角不能小于或等于 0\n";
  return 1;
 }

 if ((angle1 + angle2) >= ANGLE_TOTAL)
 {
  std::cerr << "错误！两个角之和不能大于或等于 180\n";
  return 1;
 }

 // 创建三角形对象
 Triangle t(angle1, angle2);

 // 打印三角形信息
 std::cout << t << std::endl;

 return 0;
}
