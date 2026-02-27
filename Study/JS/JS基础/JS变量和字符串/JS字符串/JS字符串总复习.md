/*
# JavaScript 字符串复习

## 字符串基础
- `定义 ：` `字符串`是用`单引号`、`双引号`或`反封装`的`字符序列`。 `字符串`是`原始数据类型`，且`不可变`。 不变性是指`字符串一旦创建`，`就不能更改`。

- `访问字符串中的字符 ：`要访问`字符串`中的`字符`，可以使用`方括号`并输入`索引值`。`索引表示`字符在`字符串`中的`位置`，从`零`开始的`计数`。 

`const` developer `=` "`Jessica`";

`console`.`log`(`developer`[`0`]`)`; `// J`


- `\n`（换行符）：`您可以使用` \n`换行符`在`字符串`中创建`换行`。 

`const` poem `=` "`Roses are red,`\n`Violets are blue,`\n`JavaScript is fun,`\n`And so are you.`";

`console`.`log`(`poem`);


- `转义字符串：`你可以通过在`引号`前添加`反斜线`（ `\`）`来转义字符串`中的`字符`。 

`const` statement `=` "`She said,` \\"`Hello!`\\"`"`;

`console`.`log`(`statement`); `// She said, "Hello!"`


## 模板字面量（模板字符串）和字符串插值

- 它们可以使`字符串`操作变得`更 简单`，包括`直接在字符串`中嵌入`标记`，这种特性被称为`字符串插值`。 

`const` name `=` "`Jessica`";


`const` greeting `=` Hello, `$`{`name`}`!;`  

`console`.`log`(`greeting`); 

// "Hello, Jessica!"


## ASCII、 `charCodeAt()`方法和 `fromCharCode()`方法

- `ASCII ：`ASCII（美国信息交换标准代码）`是一种`字符编码标准`，用于使用`数字值表达基本的英文字符`。前面的课程通过 `ASCII` 示例介绍了 `charCodeAt()`和 `fromCharCode()`。

- `Unicode ：`JavaScript 字符串`在内部使用` Unicode，具体为 `UTF-16` 编码。对于前面 `128` 个字符`（`基本拉丁字母`、`数字和常用符号`）`，`Unicode` 值与 `ASCII` 代码相匹配。这就是基于 `ASCII` 的示例。在 `JavaScript` 中`仍然有效的原因`。

- `charCodeAt()`方法 ：`此方法`返回`指定索引处字符的`UTF-16`代码单元`。`对于基本`拉丁字符`，该值与`ASCII`码匹配。 

`const` letter `=` "`A`";

`console`.`log`(`letter`.`charCodeAt`(`0`)`);`

// 65

- `fromCharCode()`方法：`该方法`将`ASCII`码转换为相应的`字符`。 

`const` char `=` String`.`fromCharCode`(`65`)`;

`console`.`log`(`char`);  

// A


## 其他常用字符串方法

### indexOf()方法：

该方法用于`查找字符串`中的`子字符串`。如果找到`子字符串`， `indexOf` 将返回该`子字符串第一次出现的索引`（`或位置`）。如果未找到`子字符串`， `indexOf` 将返回`-1`，表示查找`失败`。 

`const` text `=` "`The quick brown fox jumps over the lazy dog.`";

`console`.`log`(`text`.`indexOf`(`"`fox`"`)`);` 

// 16

`console`.`log`(`text`.`indexOf`(`"`cat`"`)`);` 

// -1


### includes()方法 ：

该方法`用于`检查字符串`是否包含`特定子字符串`。如果在`字符串`中找到`子字符串`，`该方法`返回 `true`。否则，返回 `false`。 

`const` text `=` "`The quick brown fox jumps over the lazy dog.`";

`console`.`log`(`text`.`includes`(`"`fox`"`)`);` 

// true

`console`.`log`(`text`.`includes`(`"`cat`"`)`);` 

// false


### slice()方法 ：

该方法提取`字符串`的一部分，并返回一个新的`字符串`，而不需要修改`原始字符串`。它的两个参数：`开始索引`和`选填的索引`结束。 

`const` text `=` "`freeCodeCamp`";

`console`.`log`(`text`.`slice`(`0`, `4`)`);`  

// "free"

`console`.`log`(`text`.`slice`(`4`, `8`)`);`  

// "Code"

`console`.`log`(`text`.`slice`(`8`, `12`)`);` 

// "Camp"


### toUpperCase()方法 ：

该方法将所有`字符转换`为`大写字母`，并返回一个`包含所有大写字母`的`新字符串`。 

`const` text `=` "`Hello, world!`";

`console`.`log`(`text`.`toUpperCase`(`)`); 

// "HELLO, WORLD!"


### toLowerCase()方法：

该方法将`所有字符转换`为`小写字母`。 

`const` text `=` "`HELLO, WORLD!`";

`console`.`log`(`text`.`toLowerCase`(`)`); 

// "hello, world!"


### replace()方法 ：

此方法允许你在`字符串`中查找`指定的值`（`如单词或字符`）`并将其替换`为`另一个值`。该方法返回一个`包含替换内容的新字符串`，且`不会改变原始字符串`，因为`JavaScript`字符串是`不可修改`的。 

`const` text `=` "`I like cats`";

`console`.`log`(`text`.`replace`(`"`cats`"`, `"`dogs`"`)`);` 

// "I like dogs"


### replaceAll()方法 ：

此方法允许您`查找字符串`中`值`指定`（`一个单词`、`字符或模式`）`的`所有出现`，并`将它们`替换为`另一个值`。它的工作方式`类似` replace() `，`但不是在`找到`第一个`匹配`后停止，而是`更新字符串`中找到的`每个匹配`。 

`const` text `=` "`I love cats and cats are so much fun!`";

`console`.`log`(`text`.`replaceAll`(`"`cats`"`, `"`dogs`"`)`);` 

// "I love dogs and dogs are so much fun!"


### repeat()方法：

该方法`用于`将`字符串重复打印`。 

`const` text `=` "`Hello`";

`console`.`log`(`text`.`repeat`(`3`)`);` 

// "HelloHelloHello"


### trim()方法：

该方法`用于`删除`字符串首尾的空格`。 

`const` text `=` "`  Hello, world!  `";

`console`.`log`(`text`.`trim`(`)`); 

// "Hello, world!"


### trimStart()方法：

该方法`删除`字符串`开头`（`或“起始”`）的`空白`。 

`const` text `=` "`  Hello, world!  `";

`console`.`log`(`text`.`trimStart`(`)`); 

// "Hello, world!  "


### trimEnd()方法：

该方法`删除`字符串补充`的空格。 

`const` text `=` "` Hello, world! `";

`console`.`log`(`text`.`trimEnd`(`)`); 

// "  Hello, world!"


### prompt()方法：

window` 这种方法用于`通过对话框`的形式从`用户处获取信息`。该方法`接受两个参数`。第一个`只要出现`在`对话框中`的`信息，`通常`是`提示用户`输入`信息`。第二个是`默认值`，是`可选的`，将`作为填充输入字段`的初始值。

`const` answer `=` window`.`prompt`(`"`What's your favorite animal?`"`);` 
 
 // This will change depending on what the user answers

*/