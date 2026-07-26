#include <iostream>

const double KILOMETER_TO_MILE_FACTOR = 0.621371;

class KilometerToMile
{
private:
 double kilometer;

public:
 KilometerToMile(double k) : kilometer(k) {}

 // setter 函数
 void setKilometer(double k)
 {
  kilometer = k;
 }

 // getter 函数
 double getterKilometer() const
 {
  return kilometer;
 }

 // 公里转英里函数
 double kilometer_convert_mile() const
 {
  return kilometer * KILOMETER_TO_MILE_FACTOR;
 }
};

// << 运算符重在
std::ostream &operator<<(std::ostream &os, const KilometerToMile &kilometer)
{
 os << kilometer.getterKilometer() << " 公里每小时等于： " << std::endl;
 os << kilometer.kilometer_convert_mile() << " 英里每小时。";
 return os;
}

int main()
{
 double km_h;

 std::cout << "输入以公里每小时为单位的速度\n";
 std::cin >> km_h;

 if (km_h <= 0)
 {
  std::cerr << "值不能小于等于 0，请重新输入\n";
  return 1;
 }

 // 定义类并转换
 KilometerToMile km(km_h);

 std::cout << km << std::endl;

 return 0;
}