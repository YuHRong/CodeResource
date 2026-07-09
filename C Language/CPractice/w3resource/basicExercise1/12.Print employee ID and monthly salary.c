// Write a C program that accepts an employee's ID, total worked hours in a month and the amount he received per hour. Print the ID and salary (with two decimal places) of the employee for a particular month.

#include <stdio.h>

int main(void)
{
 char employee_id[11];          // 申明存储员工 ID 变量，最大只能存储 10
 int work_hours;                // 申明工作时间变量
 float amount_hours, total = 0; // 申明每小时的金额以及总金额变量，将总金额赋值0

 // 提示用户输入员工 ID
 printf("Input the Employees ID(Max. 10 chars): ");
 scanf("%s", &employee_id);

 // 提示用户输入每天工作时间
 printf("Input the working hrs: ");
 scanf("%d", &work_hours);

 // 提示用户输入每小时所获得的金额
 printf("Salary amount/hr: ");
 scanf("%f", &amount_hours);

 // 计算总金额
 total = work_hours * amount_hours;

 // 打印员工ID,打印总金额
 printf("Employees ID = %s\n", employee_id);
 printf("Salary = U$ %.2f\n", total);

 return 0;
}