# 比较运算符
            
## ==, 相等，比较两个值是否相等，返回布尔值 True 或 False
## !=, 不相等，比较两个值是否不相等，返回布尔值 True 或 False
## >, 大于，比较左边的值是否大于右边的值，返回布尔值 True 或 False
## <, 小于，比较左边的值是否小于右边的值，返回布尔值 True 或 False
## >=, 大于等于，比较左边的值是否大于或等于右边的值，返回布尔值 True 或 False
## <=, 小于等于，比较左边的值是否小于或等于右边的值，返回布尔值 True 或 False

print(3 > 4)     # False
print(3 < 4)     # True
print(3 == 4)    # False
print(4 == 4)    # True
print(3 != 4)    # True
print(3 >= 4)    # False
print(3 <= 4)    # True


# if 条件语句
#if condition: pass
    # 当条件为 True 时执行的代码块

age = 20
if age >= 18:
    print("You are an adult.")
else:
    print("You are a minor.")

# 多重条件语句
score = 85
if score >= 90:
    print("Grade: A")
elif score >= 80:
    print("Grade: B")
elif score >= 70:
    print("Grade: C")
else:
    print("Grade: F")