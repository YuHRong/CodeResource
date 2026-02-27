/*
JavaScript 是一种动态类型语言，这意味着在声明变量时无需指定其数据类型。 相反，类型是根据程序运行时分配给变量的值确定的。
这允许你在整个程序中更改变量的类型。
*/

//示例代码
 let example = "Hello";

example = 42;

/*
在这个示例中，我们有一个名为  example  的变量，其数据类型为字符串。 但随后我们将其值更新为了一个数值。
动态类型的灵活性使 JavaScript 更宽松，易于快速编写脚本，但它也可能带来更难捕捉的错误，尤其是当程序变大时。
在像 C# 或 C++ 这样的静态类型语言中，你必须在创建变量时声明变量的数据类型，并且该类型不能更改。
例如，如果你将一个变量声明为  integer  ，则只能为其赋值整数值。 如果尝试为其赋值不同的类型，程序会报错。
这是一个 C# 语言的示例：
int data = 42; // data must always be an integer

data = "Hello"; // This would cause an error in C#


动态类型和静态类型的区别在于代码的灵活性和安全性。 动态类型语言具有灵活性，但代价是运行时可能出错。
静态类型语言执行更严格的规则，可以防止某些错误，但需要更多的前期声明，更改类型的灵活性较低。
下面是另一个示例，创建一个类型为  number 的变量，然后将其改为  string 类型：
*/
// 示例代码 
let data = 100;  // Initially a number

data = "New data";  // Dynamically changes to a string

/*
在静态类型语言中，这种更改是不允许的，因为数据类型是固定的。
总结一下，JavaScript 的动态类型允许变量自由改变类型，这提供了灵活性，但也可能在执行过程中导致意想不到的错误。
像 Java 这样的静态类型语言要求你预先指定变量类型，这有助于在程序运行前捕捉错误，但灵活性较低。
*/

/*
typeof 操作符是如何工作的，JavaScript 中的 typeof null 错误是什么？
JavaScript 中的  typeof  操作符是一个简单而强大的工具，可让你查看变量或值的数据类型。 它总是返回一个表示类型的字符串。
让我们来看几个例子：
*/
 let num = 42;
console.log(typeof num); // "number"

/*
在第一个例子中，我们创建了一个名为  num 的变量，并赋予其数值  42。 当你在名为  num  的变量上使用  typeof 操作符时，它将返回字符串  number。
下面是在名为  isUserLoggedIn 的变量上使用  typeof 操作符的另一个例子：
*/
let isUserLoggedIn = true;
console.log(typeof isUserLoggedIn); // "boolean"

/*
在  isUserLoggedIn 变量上使用  typeof 操作符时，将返回字符串  boolean，因为布尔值  true 已被赋值给该变量。
在调试或试图了解代码中的数据类型时，使用  typeof 操作符尤其有用。
不过，JavaScript 在处理  null 时有一个众所周知的怪异行为。
让我们来看一个例子：
*/
let exampleVariable = null;
console.log(typeof exampleVariable);  // "object"

/*
在本例中，我们有一个名为  exampleVariable 的变量，并为其赋值  null 。 但是，当我们对其使用  typeof 操作符时，会返回字符串  object 。
这被普遍认为是 JavaScript 中的一个错误，可以追溯到 JavaScript 诞生之初。 造成这种行为的原因在于 JavaScript 最初的设计方式。
在该语言最初实现时，像  null  这样的值被表示为一种特殊类型的对象，从而导致了这种意想不到的结果。
不幸的是，这已成为语言的一部分，虽然令人困惑，但这是你需要注意的
*/