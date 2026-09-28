// Create a structure named "Employee" to store employee details such as employee ID, name, and salary. Write a program to input data for three employees, find the highest salary employee, and display their information.

#include <stdio.h>

#define NUM 40

struct Employee
{
 int employeeID;
 char name[NUM];
 float salary;
};

int main(void)
{
 // 申明三个结构变量存储三个员工信息
 struct Employee employee1, employee2, employee3;

 // 获取第一个员工的信息
 printf("Imput details for Employee 1:\n");
 printf("Employee ID: ");
 scanf("%d", &employee1.employeeID);
 printf("Name: ");
 scanf("%s", &employee1.name);
 printf("Salary: ");
 scanf("%f", &employee1.salary);

 // 第二个员工的信息
 printf("Input details for Employee 2:\n");
 printf("Employee ID: ");
 scanf("%d", &employee2.employeeID);
 printf("Name: ");
 scanf("%s", &employee2.name);
 printf("Salary: ");
 scanf("%f", &employee2.salary);

 // 第三个员工的信息
 printf("Input details for Employee 3:\n");
 printf("Employee ID: ");
 scanf("%d", &employee3.employeeID);
 printf("Name: ");
 scanf("%s", &employee3.name);
 printf("Salary: ");
 scanf("%f", &employee3.salary);

 // 找到最高工资的员工
 // 创建结构变量保存最高工资
 struct Employee highestSalaryEmployee;
 if (employee1.salary >= employee2.salary && employee1.salary >= employee3.salary)
  highestSalaryEmployee = employee1;
 else if (employee2.salary >= employee1.salary && employee2.salary >= employee3.salary)
  highestSalaryEmployee = employee2;
 else
  highestSalaryEmployee = employee3;

 // 显示工资最高的员工信息
 printf("\nEmployee with the Highest Salary:\n");
 printf("Employee ID: %d\n", highestSalaryEmployee.employeeID);
 printf("Name: %s\n", highestSalaryEmployee.name);
 printf("Salary: %.2f\n", highestSalaryEmployee.salary);

 return 0;
}