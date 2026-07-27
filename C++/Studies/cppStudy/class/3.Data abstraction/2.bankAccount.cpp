#include <iostream>

class BankAccount
{
private:
 /* data */
 double balance; // 私有数据成员
public:
 BankAccount(/* args */) : balance(0.0) {} // 构造函数

 // 公有接口
 void deposit(double amount)
 {
  balance += amount;
 }

 void withdraw(double amount)
 {
  if (amount <= balance)
  {
   balance -= amount;
  }
  else
   std::cout << "Insufficient funds!" << std::endl;
 }

 double getBalance() const
 {
  return balance; // 仅提供读取余额的接口
 }
};
