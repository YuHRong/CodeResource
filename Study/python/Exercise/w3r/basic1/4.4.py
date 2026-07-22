from math import sqrt

center_x = float(input('请输入圆中心 x 坐标'))
center_y = float(input('请输入圆中心 y 坐标'))
radius = float(input('请输入圆半径'))
point_x = float(input('请输入 x 点'))
point_y = float(input('请输入 y 点'))

distance = sqrt((point_x - center_x) ** 2 + (point_y - center_y) ** 2)

if distance < radius:
    print('在圆内')
elif distance == radius:
    print(('在圆周上'))
else:
    print('不在圆内')

input('回车退出')