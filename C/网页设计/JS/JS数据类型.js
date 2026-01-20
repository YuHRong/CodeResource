// Examples of integers

console.log(3);

console.log(5.5);

console.log(-67);

// Examples of floating point numbers

console.log(3.14);

console.log(7.2);

console.log(-14.5);

console.log("hello")

//AString  是一串字符或文本，用引号括起来。以下是一个使用双引号的字符串示例：
console.log("I love to code!");
//以下是一个使用单引号的示例：
console.log('I love to code!');

// let
//let age;

//console.log(age);  // undefined

//let age = 25;

//console.log(age); // 25

//let age = 25 ;

//console.log(age);  // 25

//age = 30;

console.log(age); // 30
// Bad variable names
let x = 10;
let y = "John";
// Good variable names
let age = 10;
//JavaScript 中的变量必须以字母、下划线 (  _ ) 或美元符号 (  $ ) 开头，不能以数字开头。

// Valid variable names
//let age;
let _score;
let $total;
// Invalid variable names
//let 1stPlace; // starts with a number
//变量名区分大小写，也就是说，全小写的单词和全大写的 age 单词被视为不同的变量。 Age  A 


//以下是使用驼峰命名法命名变量的示例：
let thisIsCamelCase;
let anotherExampleVariable;
let freeCodeCampStudents;
//JavaScript 中有一些关键字不能用作变量名，例如 let `var`、 const `var`  function 、`var` 或
//return  `var`，因为它们是该语言本身保留的。
//此外，在变量名中应避免使用感叹号 (  ! ) 或 at @  符号 ( ) 等特殊字符。为了保持变量名的可读性，最好使用字母、数字、下划线或美元符号。


// 在现代 JavaScript 中， let `var` 和 `var` const  是声明变量的首选方式，但它们在处理值赋值和重新赋值的方式上有所不同。
let score = 10;
console.log(score); // 10
score = 20;
console.log(score); // 20


const maxScore = 100;
console.log(maxScore); // 100


//let age;
console.log(age); // undefined
age = 25;
console.log(age); // 25