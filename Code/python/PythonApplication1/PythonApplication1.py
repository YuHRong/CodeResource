from pyexpat.errors import messages
from shlex import quote


my_str_1 = 'Hello'
my_str_2 = "World!"
my_str_3 = """Multiline
string"""
my_str_4 = '''Another
multiline
string'''
msg = 'It\'s a sunny day'
quote = "She said, \"Hello World!\""
my_str = 'Hello world!'
greeting = 'hi'
greeting = 'hello'

print(my_str_1 + ' ' + my_str_2)
print(my_str_3)
print(my_str_4)
print(msg)
print(quote)
print('Hello' in my_str)
print('hy' in my_str)

print(len(my_str))
print(my_str[6])
print(my_str[-1])
print(greeting)