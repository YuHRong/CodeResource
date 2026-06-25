using System.Windows.Forms;

namespace WinFormApp 
{
 public partial class Form1 : Form
 {
  public Form1()
  {
   InitializeComponent();
  }

  private void btnOpen_Click(object sender, EventArgs e)
  {
   //dialog.Multiselect = true;     // 确定可以多选文件
   //dialog.Title = "请选择文件夹";
   //dialog.Filter = "所有文件 (*.*)*.*";
   //dialog.InitialDirectory = Application.StartupPath;      // 初始目录为 .exe 所在目录
   var fileContent = string.Empty;
   var filePath = string.Empty;

   using (OpenFileDialog dialog = new OpenFileDialog())
   {
    //openFileDialog.InitialDirectory = "c:\\";
    dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
    dialog.FilterIndex = 2;
    dialog.RestoreDirectory = true;

if(dialog.ShowDialog() == DialogResult.OK)
    {
     // 获取指定文件的路径
     filePath = dialog.FileName;

     //将文件内容读入 Stream
     var fileStream = dialog.OpenFile();

     using(StreamReader reader = new StreamReader(fileStream))
     {
      fileContent = reader.ReadToEnd();
     }
    }
   }


  }
 }
}