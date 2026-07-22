from math import pi

圆心角 = float(input('请输入扇形夹角角度'))
半径 = float(input('请输入半径'))

面积 = (圆心角 / 360) * pi * 半径 ** 2

print(f'圆心角为： {圆心角},半径为： {半径},面积为: {面积}')

input('回车退出')