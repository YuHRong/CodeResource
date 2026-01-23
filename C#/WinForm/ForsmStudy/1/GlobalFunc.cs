using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyWinform
{
 public class GlobalFunc
 {
  //单例模式
  private static GlobalFunc Instance = null;
  public static GlobalFunc _Instance
  {
   get
   {
    if (Instance == null)
    {
     Instance = new GlobalFunc();
    }
    return Instance;
   }
  }

//  private GlobalFunc() { }

  public string Name = "abc";
  public Form formLogin = null;
  public string AccountG = null;
 }
}
