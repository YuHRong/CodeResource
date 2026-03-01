# JavaScript 数学复习

## 使用数字数据类型

-  定义 ：`JavaScript 的` Number类型包括`整数`、`浮点数`、 `Infinity` 和 `NaN` 。`浮点数`是`标记小数字点`的数字。`正数` Infinity是`大于任何`其他数字的`数字`，而是 `-Infinity` 小于任何其他`数字的数字`。 `NaN`(`  Not a Number`) `表示`无效的数值，`如`字符串 `"`Jessica`"`。


## 常见算术方法

- `加法运算符`：此运算符`（` +`）`用于计算`两个或两个以上数的和。`

- `减法运算符`：此运算符`（` - `）`用于计算`两个数的差值。`

- `乘法运算符`：此运算符`（` *`）`用于`计算两个`或`两个以上数`的乘积。

- `除法运算符`：此运算符`（` /`）`用于`计算两个数的商。`

- `除以零`：如果你尝试除以`零`，`JavaScript` 将返回 `Infinity。`

-  `取余运算符`：此运算符`（` %`）`返回`除法的余数。`

- `指数运算符`：此运算符`（` **`）`将一个`数字`提升`为`另一个`数字的`幂。

## 数字和字符串混合计算

-  `解释`：当你使用`加法`运算符 `+` 号对`数字`和`字符串`进行操作时，`JavaScript` 将`数字`强制转换`为`字符串并连接这两个值。当你使用`减法运算符` -、`乘法运算符` *?`除法运算符` / `对`字符串`和`数字进行`操作`时，`JavaScript` 将`字符串`强制转换为`数字`，结果将是`数字。`对于 `null`和来说 `undefined` ，`JavaScript` 在`数学操作中`将 `null`视为 `0，` `undefined``视为`将 `NaN。`

`const` result `=` 5 `+` '`10`';

`console`.`log`(`result`); 

// "510"

`console`.`log`(`typeof result`); 

// string

`const` subtractionResult `=` '`10`' `-` 5`;`

`console`.`log`(`subtractionResult`); 

// 5

`console`.`log`(`typeof subtractionResult`); 

// number

`const` multiplicationResult `=` '`10`' `*` 2`;`

`console`.`log`(`multiplicationResult`); 

// 20

`console`.`log`(`typeof multiplicationResult`); 

// number

`const` divisionResult `=` '`20`' `/` 2`;`

`console`.`log`(`divisionResult`); 

// 10

`console`.`log`(`typeof divisionResult`); 

// number

`cons`t result1 `=` null `+` 5`;`

`console`.`log`(`result1`); 

// 5

`console`.`log`(`typeof result1`); 

// number

`const` result2 `=` undefined `+` 5`;`

`console`.`log`(`result2`); 

// NaN

`console`.`log`(`typeof result2`); 

// number


## 运算符优先级

- `定义` ：运算符`优先级`决定了`表达式`中运算的求值顺序。`优先级`优先的`运算符`先于优先级乘以较低的运算符并进行`计算`。中间的值将`优先计算`，`/`除法的优先级为`加法`/`减法`。如果`运算符`具有相同的`优先级`，则将 `JavaScript` 使用性。 

`const` result `=` (`2` + `3`) `*` 4`;`

`console`.`log`(`result`); 

// 20

`const` result2 `=` 10 `-` 2 `+` 3`;`

`console`.`log`(`result2`); 

// 11

`const` result3 `=` 2 `**` 3 `**` 2`;`

`console`.`log`(`result3`); 

// 512


-  `定义` ：结合性告诉我们`存在多个`相同类型`的`表达式`时`表达式`的`求值方向`。它`定义`了表达式应该从`左`到`右`（ `left`-`associative`）`还是`从`右`到`左`（ `right`-`associative` ）`进行求值。`例如，`指数表达式`也是从`右`向`左`结合的：` 

`const` result4 `=` 5 `**` 4 `**` 1`;`

`console`.`log`(`result4`); 

// 625


## 自增和自减

-  `自增运算符`：该运算符用于将`数值加一。` 附加符号 `++num` 先返回`变量`的值，然后返回`一个新值`。 后缀符号 `num++`首先返回`变量的当前值`，然后`加1。` 

`let` x `=` 5`;`

`console`.`log`(`++x`); 

// 6

`console`.`log`(`x`); 

// 6


`let` y `=` 5 `;`

`console`.`log`(`y++`); 

// 5

`console`.`log`(`y`); 

// 6


-  `自减操作符` ：该符号操作`用于`将`数值减一`。附加符号`和`后缀符号`的工作方式`与前面的自增符号相同。` 

`let` num `=` 5`;`

`console`.`log`(`--num`); 

// 4

`console`.`log`(`num--`); 

// 4

`console`.`log`(`num`); 

// 3


## 复合赋值语句

运算符名称 | 符号 | 说明
--- | --- | ---
加法赋值 |  +=  | 危害：该计算器对赋值运算加法求职，赋予结果赋值给赋值。
减法赋值 | -= | 危害：该税额对数值执行减法处罚，将结果赋值给变量。
乘法赋值 | *= | 运算符：该运算符对乘法赋值，将结果赋值给变量。
除法赋值 | /= | 运算符：该计算器对数值执行除法侵犯，赋予结果赋值给变量。
取余数赋值 | %= | 操作：该符号将变量除以指定的数字，把余数赋值给变量。
指数赋值 | **= | 运算符：此变量将变量提升为指定数字的指数，将结果赋值给变量。

## 布尔性和可靠性

-  `布尔定义`：布尔是一种`只能有两个值的`数据类型： `true`或 `false`。

-  `是否`（ `==`）`操作`：该操作符在检查值`是否足以在使用类型强制之前。` 

`console`.`log`(`5 `==` '`5`'`); 

// true

-  `完全符合`（ `===`）`运算符`：该操作符`不执行`类型强制，`并检查类型`和`值是否一致。` 

`console`.`log`(`5 `===` '`5`'`); 

// false


-  `不等`（ `!=`）`操作符`：该`操作符`在`检查值是否满足`使用类型强制之前。

-  `严格不等`（ `!==`）`操作符`：该`操作符`不执行`类型强制`，并检查类型和`值`是否不符合。

## 比较运算符

符号名称 | 符号 | 说明
--- | --- | ---
大于 | > | 此操作符检查`左侧的`值是否`大于右侧的值`。
大于等于 | >= | 此操作符`检查右侧`的值是否`大于或等于`右侧的值。
小于 | < | 此操作符检查`左侧`的值是否`小于`右侧的值。
小于等于 | <= | 此操作符`检查左侧`的值是否`小于或等于`右侧的值。

## 一元解读

-  `一元正运算符`：该运算符`将操作数`转换为`数字`。如果操作数`已经是数字`，则保持不变。 

`const` str `=` '`42`'`;`


`const` num `=` +`str`;



`console`.`log`(`num`); `// 42`

`console`.`log`(`typeof` num`);` // number


-  一元负（ `-`）运算符：`该运算符`将操作数变为`负值。` 

`const` num `=` 4`;`

`console`.`log`(`-num`); `// -4`


-  逻辑非（ `!`）运算符`：该操作符翻转操作数的`布尔值`。如果操作数是 `true` ，就会变成 `false`，如果是 `false`，就会变成 `true`。

## 位运算符

符号名称 | 符号 | 说明
--- | --- | ---
按位与 | `&` | ：该`操作符在`两个操作对象`的`对应位置为` 1 `时，在该位位置返回` 1。
按位与赋值 | `&=` | 此`操作符`对指定数字`执行` bitwise `AND` 操作，并将`结果重新`赋予变量。
按位或 | `\|` | 该运算符在`两个操作数`中对应位只要有`一个是` 1，`就返回 `1。
按位或赋值 | `\|=` | 该运算符对`指定的数字`执行 `bitwise` OR `运算`，将结果重新赋值给`变量。`
按位异或 | ^ | 该运算符在`两个操作数`对应`位中有且有`一个为 `1` 时，返回 `1。`
按位非 | ~ | 该操作符`反转数字`的`二进制表示。`
左移 |  << | 此操作符将`所有位置`向`左移动指定的位置。`
右移 | >> | 此操作符将`所有位`向右移动。

## 条件语句、真值、假值和三元运算符

-  `if/else if/else`： `if`语句接收一个`条件`，并在该条件 `truthy` 为时运行一个`代码块`。如果条件为 `false`，则转到 `else if`代码块`。如果`这些条件都不满足 `true`，则执行该 `else`子句。值是在`布尔`上下文`（`如语句`）`中求值时 `Truthy`产生的任何值。值是 在`布尔`上下文中求值的值。 
`true` if `Falsy` false 

`const` score `=` 87`;`

`if` (`score >= 90`) `{`

 console.log('You got an A'); 

} else if (score >= 80) {

 console.log('You got a B'); // You got a B


} else if (score >= 70) {

 console.log('You got a C');


} else {

 console.log('You failed! You need to study more!');


}


-  三元运算符：该运算符经常作为编写 if else语句的一种简写方式。 const temperature = 30;


const weather = temperature > 25 ? 'sunny' : 'cool';



console.log(`It's a ${weather} day!`); // It's a sunny day!


二元逻辑运算
-  逻辑 AND(  &&) 运算符：该运算符检查两个操作数是否相同 true。 如果值都是 true ，则返回第二个值。如果任一操作数为 falsy，则返回 falsy值。如果两个操作数均为 falsy，则返回第一个 falsy值。 const result = true && 'hello';



console.log(result); // hello


-  逻辑或 (  ||) 操作符：此操作符检查至少是否有一个操作对象为真值。

-  空值合并（ ??）运算符：只有当第一个值为 null或 undefined 时，该字段才会返回一个值。 const userSettings = {

 theme: null,

 volume: 0,

 notifications: false,


};




let theme = userSettings.theme ?? 'light';

console.log(theme); // light


对象 Math
​
-  Math.random()方法 ：该方法生成一个循环 0（包含）和 1（不包含）之间的随机浮点数。这意味着输出可以是 0，但它永远不会达到 1 。
-  Math.max()方法：该方法接收一组数字并返回顶部。
-  Math.min()方法：该方法接收一组数字并简单返回。
-  Math.ceil()方法：该方法将数值向上取整为最接近的整数。
-  Math.floor()方法：该方法将数值递增取整为最接近的整数。
-  Math.round()方法：该方法将数值四舍五入为最接近的整数。 console.log(Math.round(2.3)); // 2

console.log(Math.round(4.5)); // 5

console.log(Math.round(4.8)); // 5


-  Math.trunc()方法：该方法删除数字的小数部分，只返回整数部分，不进行四舍五入。
-  Math.sqrt()方法：该方法返回一个数字的平方根。
-  Math.cbrt()方法：该方法返回一个数字的立方根。
-  Math.abs()方法：该方法返回一个数字的绝对值。
-  Math.pow()方法：该方法接收两个数字，第二个数字是第一个数字的指数。
常用数字方法
-  isNaN()： NaN 代表非数字“Not-a-Number”。它是一个特殊值，表示无法表示或未定义的数值结果。 isNaN()函数属性用于判断某个值是否为 NaN。  Number.isNaN() 提供了一种更可靠的方法来检查 NaN值，特别是在类型强制可能导致全局 isNaN() 函数出现意外结果的情况下。 console.log(isNaN(NaN));       // true

console.log(isNaN(undefined)); // true

console.log(isNaN({}));        // true



console.log(isNaN(true));      // false

console.log(isNaN(null));      // false

console.log(isNaN(37));        // false





console.log(Number.isNaN(NaN));        // true

console.log(Number.isNaN(Number.NaN)); // true

console.log(Number.isNaN(0 / 0));      // true



console.log(Number.isNaN("NaN"));      // false

console.log(Number.isNaN(undefined));  // false


-  parseFloat()方法 ：该方法解析字符串参数并返回浮点数。它的设计目的是从字符串开头提取数字，即使字符串后面包含非数字字符。
-  方法：此 parseInt()方法解析字符串参数并返回整数。 parseInt() 在遇到第一个非数字时停止解析。 对于浮点数，只返回整数部分。如果在字符串开头找不到有效整数，则返回 NaN。
-  toFixed()方法 ：该方法在数字上调用，它包含一个可选参数，即小数点后面的点缀。它返回数字的字符串形式，并标记指定的小数点。