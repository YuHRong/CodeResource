using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudyWinform;

namespace _1
{
 internal static class Program
 {
  /// <summary>
  /// 应用程序的主入口点。
  /// </summary>
  [STAThread]
  static void Main()
  {
   Application.EnableVisualStyles();
   Application.SetCompatibleTextRenderingDefault(false);
   Form1 form1 = new Form1();
   GlobalFunc._Instance.formLogin = form1;
   Application.Run(form1);
   //Index index = new Index(string);
   //Application.Run(index);
  }
 }
}
