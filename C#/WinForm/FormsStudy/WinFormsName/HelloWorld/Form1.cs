namespace HelloWorld
{
 public partial class Form1 : Form
 {
  public Form1()
  {
   InitializeComponent();
   //   lblHelloWorld.Text = "Hello World!";
  }

  private void btnClickThis_Click(object sender, EventArgs e)
  {
   lblHelloWorld.Text = "Hello World!";
  }
 }
}
