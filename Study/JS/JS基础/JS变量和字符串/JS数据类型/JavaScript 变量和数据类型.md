
# JavaScript 变量和数据类型复习

## 使用 HTML、CSS 和 JavaScript

`HTML` 和 `CSS` 提供了网站结构，而 `JavaScript` 则通过实现复杂的功能（如`处理用户输入`、`动画元素`，甚至`构建完整`的`网络应用程序`）为网站带来了`交互性`。

## JavaScript 中的数据类型

`数据类型`可以帮助`程序`理解所处理的`数据`的`类型`，无论是`数值`、`文本`还是`其他数据`。

### 数值：

`数值`代表`整数`和`浮点数`。 `整数`的`例子包括` `7`、`19` 和 `90`。

### 浮点数：

`浮点数`是带有`小数点`的`数值`。 例子包括 `3.14`、`0.5` 和 `0.0001`。

### 字符串：

`字符串`是由`字符`或`文本`组成的`序列`，包含在`引号`中。 `"`I like coding`"` 和  `'`JavaScript is fun`'` 是`字符串`的`例子`。

### 布尔：

`布尔`代表两种`可能`之一： `true` 或  `false`。 你可以使用`布尔`来表示`条件`，例如  

`isLoggedIn` = `true`;

### 未定义和空：

`undefined` 值是一个`已声明`但`未赋值`的`变量`。  `null`  值是`空值`，或者是`故意赋值`为  `null` 的`变量`。

### 对象：

`对象`是`键值对`的`集合`。 `键`是`属性`名称，`值`是`属性`值。

这里， `pet` 对象`有三个`属性`或`键： `name`、 `age` 和  `type`。 `值`分别是  `Fluffy`、 `3` 和  `dog`。 

`let` pet `=` {

`name`: `"Fluffy"`,

`age`: `3`,

`type`: `"dog"`
};

### 符号：

`符号数据类型`是`唯一`且`不可变的`值`，可用作`对象属性`的标识符`。

在下面的`示例`中，`创建`了两个具有`相同描述`的`符号`，但它们并不`相等`。 

`const` crypticKey1 `=` Symbol`(`"saltNpepper"`)`;

`const` crypticKey2 `=` Symbol`(`"saltNpepper"`)`;

`console`.`log`(`crypticKey1 `===` crypticKey2`)`; `// false


### 大整数：

当`数字`对于  `Number`  数据类型来说`太大`时，你可以使用`大整数`数据类型`来表示`任意长度的`整数`。

通过在`数字`末尾添加  `n` 可以创建`大整数`。 

`const` veryBigNumber `=` 1234567890123456789012345678901234567890`n`;


## JavaScript 中的变量

- `变量`可使用  `let` 关键字`声明`。

`let` cityName`;`


- 要给`变量赋值`，可使用`赋值`运算符  `=` 。 

`cityName` = `"`New York`"`;


- 使用  `let` 声明的`变量`可以`重新赋值`。 

`let` cityName `=` "`New York`";

`cityName` = `"`Los Angeles`"`;

`console`.`log`(`cityName`); `// Los Angeles`


- 除了  `let`，你也可以使用  `const` 来`声明变量`。 但是， `const` 变量`不能`重新赋值。 

`const` cityName `=` "`New York`";

`cityName` = `"`Los Angeles`"`; 
// TypeError: Assignment to constant variable.


- 使用  `const` 声明`变量`在`声明`常量`时`使用，`常量`在`整个代码`中`不可更改`，如  `PI` 或  `MAX_SIZE`。

## 变量命名准则

- `变量名`应具有`描述性`和`意义`。

- `变量名`应为`小驼峰`，如  `cityName`、 `isLoggedIn` 和  `veryBigNumber`。

- `变量名`不应以`数字`开头。 必须以`字母`、 `_` 或  `$` 开头。

- `变量名`不得包含`空格`或`特殊字符`， `_` `和`  `$` 除外。

- `变量名`不应是`保留关键字`。

- `变量名`区分`大小写`。 `age` 和  `Age` 是`不同`的`变量`。

## JavaScript 中的字符串和字符串不可变性

- `字符串`是用`引号`括起来的`一串字符`。 它们可以使用`单引号`和`双引号`创建。 

`let` correctWay `=` '`This is a string`';

`let` alsoCorrect `=` "`This is also a string`";

- 在 `JavaScript` 中，`字符串`是`不可变`的。 这意味着一旦创建了`字符串`，就不能`修改字符串`中的`字符`。 不过，你仍可以将`字符串`重新`赋值`。 

`let` firstName `=` "`John`";

`firstName` = `"`Jane`"`; `// Reassigning the string to a new value`


## JavaScript 中的字符串连接

- `连接`是将`多个`字符串`连接起来`或将`字符串`与`包含文本`的`变量`结合起来的`过程`。  `+`  操作符是`最简单`、`最常用`的`字符串`连接方法`之一`。 

`let` studentName `=` "`Asad`";

`let` studentAge `=` 25`;`

`let` studentInfo `=` studentName `+` "` is `" `+` studentAge `+` "` years old.`";

`console`.`log`(`studentInfo`); `// Asad is 25 years old.`


- 如果需要`添加`或`追加`到`现有字符串`，则可使用  `+=`  操作符。 当你想在`一个字符串`的`基础`上`逐渐添加`更多`文字`时，这`很有帮助`。 

`let` message `=` "`Welcome to programming, `";

`message` += `"`Asad!`"`;

`console`.`log`(`message`)`; `// Welcome to programming, Asad!`


- `另一种`连接`字符串`的方式是使用  `concat()`  方法。 `这种方法`是`将两个`或`多个字符串`连接在一起。 

`let` firstName `=` "`John`";


`let` lastName `=` "`Doe`";


`let` fullName `=` firstName`.`concat`(`" ", `lastName`);

`console`.`log`(`fullName`); `// John Doe`


## console.log() 记录信息

- `console.log()` 方法`用于`将消息`记录到控制台`。 它是`调试`和`测试代码`的`有用工具`。 

`console`.`log`(`"`Hello, World!`"`);


// Output: Hello, World!


## JavaScript 中的分号

- `分号`主要用于`标记`语句的`结束`。 这有助于 `JavaScript` 引擎`理解单个指令`之间的`分离`，这对`正确执行`至关重要。 

`let` message `=` "`Hello, World!`"; `// first statement ends here`


`let` number `=` 42`;` // second statement starts here


- `分号`有助于`防止`代码`执行`中的`歧义`，并确保语句正确`终止`。

## JavaScript 中的注释

- 任何`注释`掉的`代码行`都会被 `JavaScript` 引擎`忽略`。 `注释`用于`解释代码`、`做备注`或`暂时禁用代码`。

- `单行注释`使用  `//` 创建。 

// This is a single-line comment and will be ignored by the JavaScript engine


- `多行注释`使用  `/*` 开始  `*/` 结束`来创建`。 

`/*`
    This is a multi-line comment.
It can span multiple lines.
`*/`


## 作为动态类型语言的 JavaScript

- `JavaScript` 是一种动态类型`语言`，这意味着在声明`变量`时不必`指定其数据类型`。 `JavaScript` 引擎会`根据`分配给`变量`的`值`自动`确定`数据`类型`。 

`let` error `=` 404`;` // JavaScript treats error as a number

`error` = `"`Not Found`"`; `// JavaScript now treats error as a string`


- `其他语言`，如 `C#`，由于不是`动态类型`，会`导致误差`： 

`int` error `=` 404`;` `//` value must always be an integer

`error` = `"`Not Found`"`; `// This would cause an error in C#`


## 使用  typeof 操作符

`typeof` 操作符用于`检查变量`的`数据类型`。 它返回一个`字符串`，表示`变量`的`类型`。 

`let` age `=` 25`;`

`console`.`log`(`typeof age`)`;` // "number"



`let` isLoggedIn `=` true`;`

`console`.`log`(`typeof isLoggedIn`)`;` // "boolean"


- 不过，`JavaScript` 在`处理`  `null` 时有一个众所周知的`怪异行为`。  `typeof` 操作符会为  `null` 值返回  `"`object`"`。 

`let` user `=` null`;`

`console`.`log`(`typeof user`)`;` // "object
