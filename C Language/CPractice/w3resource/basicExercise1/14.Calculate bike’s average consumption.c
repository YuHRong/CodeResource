// Write a C program to calculate a bike’s average consumption from the given total distance (integer value) travelled (in km) and spent fuel (in litters, float number – 2 decimal points).

#include <stdio.h>

int main(void)
{
 float total_km, total_fuel, avg_consumption = 0;

 // 输入行驶总距离
 printf("Input total distance in km: ");
 scanf("%f", &total_km);

 // 输入总消耗燃油量（生）
 printf("Input total fuel spent in liters: ");
 scanf("%f", &total_fuel);

 // 计算平均油耗
 avg_consumption = total_km / total_fuel;

 printf("Average consumption (km/lt) %.2f\n", avg_consumption);

 return 0;
}