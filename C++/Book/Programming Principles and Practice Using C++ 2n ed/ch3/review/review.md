1. What is meant by the term prompt?

`prompt`一词语的信息是提示用户输入需要读取的信息。

2. Which operator do you use to read into a variable? 

使用 `>>`运算符读取用户输入。

3. If you want the user to input an integer value into your program for a variable named number, what are two lines of code you could write to ask the user to do it and to input the value into your program? 

第一行使用 `cout`提示用户输入`number`，第二行使用`cin`读取用户输入。

4. What is \n called and what purpose does it serve? 

`\n`是转义字符，意思是将光标移动到下一行的开始处，打印换行符。

5. What terminates input into a string? 

通常是`空白符`，可以回车中止输入字符串并写入字符串变量中。

6. What terminates input into an integer? 

输入完成之后使用回车确定输入。

7. How would you write 
cout << "Hello, ";
cout << first_name;
cout << "!\n"; 
as a single line of code? 

将这段代码写入一行可以只使用一个 `cout`，中间用`<<`运算符分开字符串与字符串变量。  

```
cout << "Hello, " << first_name << "!\n";
```

8. What is an object? 

为了读取某些内容，我们需要从某个地方读取；我们需要在计算机内存中的某个地方放置读取的内容。我们将这样一个“地方”称为一个对象。

9. What is a literal? 

`字面值常量`是直接写在代码中的固定值，他们在程序运行期间不会也不允许改变。

10. What kinds of literals are there? 
- `整数字面值常量`：表示一个整数数值
- `浮点数字面值常量`：表示实数类型的常量。
- `字符字面值常量`：用单引号括起来的单个字符，或者转义字符。
- `字符串字面值常量`：用双引号括住，表示一组字符，最终类型为 const char[]。
- `布尔字面值常量`：表示布尔型的常量。
- `指针字面值常量`：表示空指针的常量。

11. What is a variable? 

