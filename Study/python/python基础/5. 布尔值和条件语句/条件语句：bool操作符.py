print('and 短路操作符，\n只有当所有条件都为True 时，整个表达式才会返回True')

is_citizen = True

age = 25
print(is_citizen and age)

if is_citizen and age >= 18:
    print('You are eligible to vote') # You are eligible to vote
else:
    print('You are not eligible to vote')


print('or 短路操作符，\n只要其中一个条件位True 时，整个表达式就会返回True')

age = 19

is_employed = False
print(age or is_employed)

age = 19

is_student = True
if age < 18 or is_student:
    print('You are eligible for a student discount') # You are eligible for a student discount
else:
    print('You are not eligible for a student discount')


print('not 逻辑非操作符，\n用于取反一个布尔值，如果条件为True，则返回False；如果条件为False，则返回True')

print(not '') # True, because empty string is falsy
print(not 'Hello') # False, because non-empty string is truthy
print(not 0) # True, because 0 is falsy
print(not 1) # False, because 1 is truthy
print(not False) # True, because False is falsy
print(not True) # False, because True is truthy


print('在 条件语句中使用 not 操作符')

is_admin = False

if is_admin:
    print('Access denied for non-administrators.') # Access denied for non-administrators.
else:
    print('Welcome, Administrator!')

