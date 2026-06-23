
# 内置函数 range() 用于生成等差数列：

for i in range(5):
    
    print(i)
'''1
2
3
4
'''

print(list(range(5, 10)))    # [5, 6, 7, 8, 9]

print(list(range(0, 10, 3)))    # [0, 3, 6, 9]

print(list(range(-10, -100, -30)))    # [-10, -40, -70]


# 使用 range() 和 len() 按索引迭代序列

a = ['Mary', 'had', 'a', 'little', 'lamb']
print(type(a))

for i in range(len(a)):
    print(i, a[i])

'''
    1 had
2 a
3 little
4 lamb
'''

