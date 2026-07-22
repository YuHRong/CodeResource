# Write a Python program that calculates the area of a circle based on the radius entered by the user.
# import math
from math import pi

radius = input('Enter radius')

try:
    r = float(radius)

    area = pi * r ** 2

    print('R = ', r)
    print('Area = ', area)

except ValueError:
    print('输入错误！ 请输入一个数字')

input("回车退出")