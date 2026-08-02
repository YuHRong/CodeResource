// Write a C++ program to create a class called Car that has private member variables for company, model, and year. Implement member functions to get and set these variables.
#include <iostream>
#include <string>

class Car
{
private: // 私有成员
 std::string company;
 std::string model;
 std::string year;

public: // 公有成员
 // 构造函数
 Car(std::string fN, std::string cT, std::string dOM)
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
 void setyear(const std::string dOM)
 {
  year = dOM;
 }

 // getter 成员函数
 // 返回公司名称
 std::string getcompany() const
 {
  return company;
 }

 // 返回车型
 std::string getmodel() const
 {
  return model;
 }
 // 返回生产日期
 std::string getyear() const
 {
  return year;
 }
};

int main()
{
 std::string company, model, year;
 std::cout << "输入汽车公司名称: ";
 std::cin >> company;
 std::cout << "输入汽车型号: ";
 std::cin >> model;
 std::cout << "输入生产日期: ";
 std::cin >> year;

 Car car(company, model, year);

 // 打印信息
 std::cout << "汽车型号： " << car.getmodel() << std::endl;
 std::cout << "生产日期： " << car.getyear() << std::endl;
 std::cout << "所属公司： " << car.getcompany() << std::endl;

 return 0;
}