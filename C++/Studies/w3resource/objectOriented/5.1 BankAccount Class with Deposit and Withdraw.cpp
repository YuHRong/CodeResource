// Write a C++ program to implement a class called BankAccount that has private member variables for account number and balance. Include member functions to deposit and withdraw money from the account.

#include <iostream>
#include <string>

class BankAccount
{
private:
 std::string accountNum;
 double balance;

public: // 构造函数
 BankAccount(const std::string accNum, double initialBalance)
     : accountNum(accNum), balance(initialBalance) {}

 // 存款成员函数
 void deposit(double amount)
 {
  balance += amount; // 将存款金额添加到当前余额
  std::cout << "Deposit successful. Current balance: " << balance << '\n';
 }

 // 取款成员函数
 void withdraw(double amount)
 {
  if (amount <= balance)
  {                   // 检查取款余额是否小于当前金额
   balance -= amount; // 扣除取款金额
   std::cout << "Withdrawal successful. Current balance: " << balance << '\n';
  }
  else
   std::cout << "Insufficient balance. Cannot withdraw." << '\n';
 }
};

int main()
{
 // 创建 BankAccount 对象
 std::string saccno{"SB-123"};                        // 定义银行账号
 double openBalance, depositAmount, withdrawalAmount; // 定义当前金额，存款和取款变量
 openBalance = 100.00;

 std::cout << "A/c. No." << saccno << " balance: " << openBalance << '\n';
 BankAccount account(saccno, openBalance); // 使用初始余额和初始账号创建 BankAccount 对象

 // 存款
 depositAmount = 1500; // 定义存款金额
 std::cout << "Deposit Amount: " << depositAmount << '\n';
 account.deposit(depositAmount); // 调用对象的存款方法

 // 从账户中取款
 withdrawalAmount = 750; // 定义取款金额
 std::cout << "Withdrawal Amount: " << withdrawalAmount << '\n';
 account.withdraw(withdrawalAmount); // 调用 account 的取款方法

 // 尝试取款超出金额
 withdrawalAmount = 1800;
 account.withdraw(withdrawalAmount);
 std::cout << "Attempt to withdrawal Amount: " << withdrawalAmount << '\n';
 account.withdraw(withdrawalAmount); // 调用取款方法

 return 0;
}