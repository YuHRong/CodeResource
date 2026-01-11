using System;

class Window
{
 public string m_caption;     // 窗口的标题

 public bool IsActive;     // 窗口是否被激活

 public IntPtr m_handle;     // 窗口的句柄

 public static int m_total;     // 当前打开的窗口数目

 public Window(string caption)
 {
  m_caption = caption; // 初始化m_caption
  IsActive = false;
  m_total++;    // 窗口总数加1，创建窗口的一些执行代码
  m_handle = IntPtr.Zero; // 初始化为空句柄
  //return m_handle;   //窗口的返回值作为句柄
 }

 ~Window()
 {
  m_total--;     //窗口总数减 1 // 撤消窗口的一些执行代码 
 }

 public static string GetWindowCaption(Window w)
 {
  return w.m_caption;
 }

 // 窗口的其它成员 } 

 class program
 {
  static void Main()
  {

  }
 }
}