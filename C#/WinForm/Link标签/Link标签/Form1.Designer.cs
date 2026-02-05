namespace Link标签
{
 partial class Form1
 {
  /// <summary>
  /// 必需的设计器变量。
  /// </summary>
  private System.ComponentModel.IContainer components = null;

  /// <summary>
  /// 清理所有正在使用的资源。
  /// </summary>
  /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
  protected override void Dispose(bool disposing)
  {
   if (disposing && (components != null))
   {
    components.Dispose();
   }
   base.Dispose(disposing);
  }

  #region Windows 窗体设计器生成的代码

  /// <summary>
  /// 设计器支持所需的方法 - 不要修改
  /// 使用代码编辑器修改此方法的内容。
  /// </summary>
  private void InitializeComponent()
  {
   this.linkLabel1 = new System.Windows.Forms.LinkLabel();
   this.listView1 = new System.Windows.Forms.ListView();
   this.SuspendLayout();
   // 
   // linkLabel1
   // 
   this.linkLabel1.AutoSize = true;
   this.linkLabel1.LinkVisited = true;
   this.linkLabel1.Location = new System.Drawing.Point(0, 0);
   this.linkLabel1.Name = "linkLabel1";
   this.linkLabel1.Size = new System.Drawing.Size(65, 12);
   this.linkLabel1.TabIndex = 0;
   this.linkLabel1.TabStop = true;
   this.linkLabel1.Text = "linkLabel1";
   this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
   // 
   // listView1
   // 
   this.listView1.HideSelection = false;
   this.listView1.Location = new System.Drawing.Point(0, 0);
   this.listView1.Name = "listView1";
   this.listView1.Size = new System.Drawing.Size(121, 97);
   this.listView1.TabIndex = 1;
   this.listView1.UseCompatibleStateImageBehavior = false;
   this.listView1.Click += new System.EventHandler(this.listView1_Click);
   // 
   // Form1
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(800, 450);
   this.Controls.Add(this.listView1);
   this.Controls.Add(this.linkLabel1);
   this.Name = "Form1";
   this.Text = "Form1";
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.LinkLabel linkLabel1;
  private System.Windows.Forms.ListView listView1;
 }
}

