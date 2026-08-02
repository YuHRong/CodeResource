// Write a C++ program to implement a Car class with private members for company, model, and year, and include methods to update and display these attributes.

#include <iostream>
#include <string>

class Car
{
private: // 私有成员
 std::string company;
 std::string model;
 int year;

public: // 公有成员
 // 构造函数
 Car(const std::string &fN, const std::string &cT, int dOM)
     : company(fN), model(cT), year(dOM) {}

 // setter, getter 成员函数
 // setter成员函数
 // 获取公司名称
 void setcompany(const std::string fN)
 {
  company = fN;
 }

 // 获取汽车型号
 void setmodel(const std::string cT)
 {
  model = cT;
 }

 // 获取生产日期
 void setYear(const int dOM)
 {
  year = dOM;
 }

 // 显示属性方法
 void displayInfo() const
 {
  std::cout << "车型： " << model << std::endl;
  std::cout << "生产日期： " << year << std::endl;
  std::cout << "所属公司： " << company << std::endl;
 }
};

int main()
{
 Car car("Aodi", "a6-l", 2023);

 std::cout << "车辆信息： " << std::endl;
 car.displayInfo();

 car.setcompany("mobil");
 car.setmodel("l2");
 car.setYear(2020);
 car.displayInfo();
 return 0;
}