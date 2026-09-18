// Write a C# Sharp program to sort a list of elements using Shell sort.
// According to Wikipedia "Shell sort or Shell's method, is an in-place comparison sort. It can be seen as either a generalization of sorting by exchange (bubble sort) or sorting by insertion (insertion sort). The method starts by sorting pairs of elements far apart from each other, then progressively reducing the gap between elements to be compared. Starting with far apart elements can move some out-of-place elements into position faster than a simple nearest neighbour exchange."

using ex1;
using static System.Console;
using static ex1.SortShell;

// 初始化一个整数数组
int[] arr = new int[] { 5, -4, 11, 0, 18, 22, 67, 51, 6 };
int n = arr.Length; ;    // 确定数组的长度

WriteLine("Original Array Elements :");
ShellArrayElements(arr);    // 显示原始数组元素
ShellSort(arr, n);    // 调用 Shell 排序函数
WriteLine("\nSorted Array Elements :");
ShellArrayElements(arr);    // 显示排序后的数组元素
