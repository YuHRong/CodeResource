using System;

class Window
{
 public Window[] m_ChildWindow = new Window[5];
 public bool IsHaveChild = false; //是否拥有子窗口 
 public bool IsActive; //窗口是否被激活 
 public Window GetActiveWindow()
 {
  if (IsHaveChild == false)
  {
   IsActive = true;
   return this; //返回窗口自身
  }
  else
  {
   for (int i = 0; i < 5; i++)
   {
    if (m_ChildWindow[i].IsActive == true)
    {
     return m_ChildWindow[i];
     //返回激活的子窗口
    }
   }
  }
  return this;
 }
}
//子窗口 
