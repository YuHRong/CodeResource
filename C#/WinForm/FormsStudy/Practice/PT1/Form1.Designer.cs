namespace PT1
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
   this.btnOpen = new System.Windows.Forms.Button();
   this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
   this.listView1 = new System.Windows.Forms.ListView();
   this.btnPlay = new System.Windows.Forms.Button();
   this.btnStop = new System.Windows.Forms.Button();
   this.listBox1 = new System.Windows.Forms.ListBox();
   this.SuspendLayout();
   // 
   // btnOpen
   // 
   this.btnOpen.AutoSize = true;
   this.btnOpen.Location = new System.Drawing.Point(0, -6);
   this.btnOpen.Name = "btnOpen";
   this.btnOpen.Size = new System.Drawing.Size(75, 23);
   this.btnOpen.TabIndex = 0;
   this.btnOpen.Text = "打开文件";
   this.btnOpen.UseVisualStyleBackColor = true;
   this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
   // 
   // openFileDialog1
   // 
   this.openFileDialog1.FileName = "openFileDialog1";
   // 
   // listView1
   // 
   this.listView1.HideSelection = false;
   this.listView1.Location = new System.Drawing.Point(0, 0);
   this.listView1.Name = "listView1";
   this.listView1.Size = new System.Drawing.Size(121, 97);
   this.listView1.TabIndex = 1;
   this.listView1.UseCompatibleStateImageBehavior = false;
   // 
   // btnPlay
   // 
   this.btnPlay.Location = new System.Drawing.Point(0, 0);
   this.btnPlay.Name = "btnPlay";
   this.btnPlay.Size = new System.Drawing.Size(75, 23);
   this.btnPlay.TabIndex = 2;
   this.btnPlay.Text = "播放";
   this.btnPlay.UseVisualStyleBackColor = true;
   this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
   // 
   // btnStop
   // 
   this.btnStop.Location = new System.Drawing.Point(8, 8);
   this.btnStop.Name = "btnStop";
   this.btnStop.Size = new System.Drawing.Size(75, 23);
   this.btnStop.TabIndex = 3;
   this.btnStop.Text = "停止";
   this.btnStop.UseVisualStyleBackColor = true;
   // 
   // listBox1
   // 
   this.listBox1.FormattingEnabled = true;
   this.listBox1.ItemHeight = 12;
   this.listBox1.Location = new System.Drawing.Point(8, 8);
   this.listBox1.Name = "listBox1";
   this.listBox1.Size = new System.Drawing.Size(120, 88);
   this.listBox1.TabIndex = 4;
   // 
   // Form1
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(800, 450);
   this.Controls.Add(this.listBox1);
   this.Controls.Add(this.btnStop);
   this.Controls.Add(this.btnPlay);
   this.Controls.Add(this.listView1);
   this.Controls.Add(this.btnOpen);
   this.Name = "Form1";
   this.Text = "Form1";
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Button btnOpen;
  private System.Windows.Forms.OpenFileDialog openFileDialog1;
  private System.Windows.Forms.ListView listView1;
  private System.Windows.Forms.Button btnPlay;
  private System.Windows.Forms.Button btnStop;
  private System.Windows.Forms.ListBox listBox1;
 }
}

