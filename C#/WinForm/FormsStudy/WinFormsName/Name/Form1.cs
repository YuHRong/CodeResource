namespace Name
{
 public partial class Form1 : Form
 {
  public Form1()
  {
   InitializeComponent();
  }

  private void btnAdd_Click(object sender, EventArgs e)
  {
   if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstName.Items.Contains(txtName.Text))
    lstName.Items.Add(txtName.Text);  
  }
 }
}
