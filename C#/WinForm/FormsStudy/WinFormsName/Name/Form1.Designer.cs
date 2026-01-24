namespace Name
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

  #region Windows Form Designer generated code

  /// <summary>
  ///  Required method for Designer support - do not modify
  ///  the contents of this method with the code editor.
  /// </summary>
  private void InitializeComponent()
  {
   btnAdd = new Button();
   label1 = new Label();
   lstName = new ListBox();
   txtName = new TextBox();
   tableLayoutPanel1 = new TableLayoutPanel();
   SuspendLayout();
   // 
   // btnAdd
   // 
   btnAdd.Location = new Point(138, 55);
   btnAdd.Name = "btnAdd";
   btnAdd.Size = new Size(100, 23);
   btnAdd.TabIndex = 0;
   btnAdd.Text = "AddName";
   btnAdd.UseVisualStyleBackColor = true;
   btnAdd.Click += btnAdd_Click;
   // 
   // label1
   // 
   label1.AutoSize = true;
   label1.Location = new Point(12, 9);
   label1.Name = "label1";
   label1.Size = new Size(49, 17);
   label1.TabIndex = 1;
   label1.Text = "Names";
   // 
   // lstName
   // 
   lstName.FormattingEnabled = true;
   lstName.ItemHeight = 17;
   lstName.Location = new Point(12, 27);
   lstName.Name = "lstName";
   lstName.Size = new Size(120, 89);
   lstName.TabIndex = 2;
   // 
   // txtName
   // 
   txtName.Location = new Point(138, 26);
   txtName.Name = "txtName";
   txtName.Size = new Size(138, 23);
   txtName.TabIndex = 3;
   // 
   // tableLayoutPanel1
   // 
   tableLayoutPanel1.ColumnCount = 2;
   tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
   tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
   tableLayoutPanel1.Location = new Point(20, 35);
   tableLayoutPanel1.Name = "tableLayoutPanel1";
   tableLayoutPanel1.RowCount = 2;
   tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
   tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
   tableLayoutPanel1.Size = new Size(268, 180);
   tableLayoutPanel1.TabIndex = 4;
   // 
   // Form1
   // 
   AutoScaleDimensions = new SizeF(7F, 17F);
   AutoScaleMode = AutoScaleMode.Font;
   ClientSize = new Size(800, 450);
   Controls.Add(tableLayoutPanel1);
   Controls.Add(txtName);
   Controls.Add(lstName);
   Controls.Add(label1);
   Controls.Add(btnAdd);
   Name = "Form1";
   Text = "Form1";
   ResumeLayout(false);
   PerformLayout();
  }

  #endregion

  private Button btnAdd;
  private Label label1;
  private ListBox lstName;
  private TextBox txtName;
  private TableLayoutPanel tableLayoutPanel1;
 }
}
