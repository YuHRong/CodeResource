namespace player
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
   this.components = new System.ComponentModel.Container();
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
   this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
   this.listBox1 = new System.Windows.Forms.ListBox();
   this.panel1 = new System.Windows.Forms.Panel();
   this.trackBar1 = new System.Windows.Forms.TrackBar();
   this.trackBar2 = new System.Windows.Forms.TrackBar();
   this.checkBox1 = new System.Windows.Forms.CheckBox();
   this.本地文件ToolStripMenuItem = new System.Windows.Forms.MenuStrip();
   this.label1 = new System.Windows.Forms.Label();
   this.label2 = new System.Windows.Forms.Label();
   this.btn_Playe = new System.Windows.Forms.Button();
   this.btn_Stop = new System.Windows.Forms.Button();
   this.button3 = new System.Windows.Forms.Button();
   this.button4 = new System.Windows.Forms.Button();
   this.button5 = new System.Windows.Forms.Button();
   this.button6 = new System.Windows.Forms.Button();
   this.button7 = new System.Windows.Forms.Button();
   this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
   this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
   this.timer1 = new System.Windows.Forms.Timer(this.components);
   ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
   this.panel1.SuspendLayout();
   ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
   ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
   this.SuspendLayout();
   // 
   // axWindowsMediaPlayer1
   // 
   this.axWindowsMediaPlayer1.Enabled = true;
   this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
   this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
   this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
   this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
   this.axWindowsMediaPlayer1.TabIndex = 0;
   // 
   // listBox1
   // 
   this.listBox1.FormattingEnabled = true;
   this.listBox1.ItemHeight = 12;
   this.listBox1.Location = new System.Drawing.Point(0, 0);
   this.listBox1.Name = "listBox1";
   this.listBox1.Size = new System.Drawing.Size(120, 88);
   this.listBox1.TabIndex = 1;
   // 
   // panel1
   // 
   this.panel1.Controls.Add(this.button7);
   this.panel1.Controls.Add(this.button6);
   this.panel1.Controls.Add(this.button5);
   this.panel1.Controls.Add(this.button4);
   this.panel1.Controls.Add(this.button3);
   this.panel1.Controls.Add(this.btn_Stop);
   this.panel1.Controls.Add(this.btn_Playe);
   this.panel1.Controls.Add(this.label2);
   this.panel1.Controls.Add(this.label1);
   this.panel1.Controls.Add(this.本地文件ToolStripMenuItem);
   this.panel1.Controls.Add(this.checkBox1);
   this.panel1.Controls.Add(this.trackBar2);
   this.panel1.Controls.Add(this.trackBar1);
   this.panel1.Location = new System.Drawing.Point(300, 175);
   this.panel1.Name = "panel1";
   this.panel1.Size = new System.Drawing.Size(200, 100);
   this.panel1.TabIndex = 3;
   // 
   // trackBar1
   // 
   this.trackBar1.Location = new System.Drawing.Point(16, 16);
   this.trackBar1.Name = "trackBar1";
   this.trackBar1.Size = new System.Drawing.Size(104, 45);
   this.trackBar1.TabIndex = 2;
   // 
   // trackBar2
   // 
   this.trackBar2.Location = new System.Drawing.Point(24, 24);
   this.trackBar2.Name = "trackBar2";
   this.trackBar2.Size = new System.Drawing.Size(104, 45);
   this.trackBar2.TabIndex = 3;
   // 
   // checkBox1
   // 
   this.checkBox1.AutoSize = true;
   this.checkBox1.Location = new System.Drawing.Point(61, 42);
   this.checkBox1.Name = "checkBox1";
   this.checkBox1.Size = new System.Drawing.Size(78, 16);
   this.checkBox1.TabIndex = 4;
   this.checkBox1.Text = "checkBox1";
   this.checkBox1.UseVisualStyleBackColor = true;
   // 
   // 本地文件ToolStripMenuItem
   // 
   this.本地文件ToolStripMenuItem.Location = new System.Drawing.Point(0, 0);
   this.本地文件ToolStripMenuItem.Name = "本地文件ToolStripMenuItem";
   this.本地文件ToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
   this.本地文件ToolStripMenuItem.TabIndex = 5;
   this.本地文件ToolStripMenuItem.Text = "menuStrip1";
   this.本地文件ToolStripMenuItem.Click += new System.EventHandler(this.本地文件ToolStripMenuItem_Click);
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(24, 24);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(41, 12);
   this.label1.TabIndex = 6;
   this.label1.Text = "label1";
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(32, 32);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(41, 12);
   this.label2.TabIndex = 7;
   this.label2.Text = "label2";
   // 
   // btn_Playe
   // 
   this.btn_Playe.Location = new System.Drawing.Point(40, 40);
   this.btn_Playe.Name = "btn_Playe";
   this.btn_Playe.Size = new System.Drawing.Size(75, 23);
   this.btn_Playe.TabIndex = 8;
   this.btn_Playe.Text = "button1";
   this.btn_Playe.UseVisualStyleBackColor = true;
   this.btn_Playe.Click += new System.EventHandler(this.btn_Playe_Click);
   // 
   // btn_Stop
   // 
   this.btn_Stop.Location = new System.Drawing.Point(48, 48);
   this.btn_Stop.Name = "btn_Stop";
   this.btn_Stop.Size = new System.Drawing.Size(75, 23);
   this.btn_Stop.TabIndex = 9;
   this.btn_Stop.Text = "停止";
   this.btn_Stop.UseVisualStyleBackColor = true;
   this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
   // 
   // button3
   // 
   this.button3.Location = new System.Drawing.Point(56, 56);
   this.button3.Name = "button3";
   this.button3.Size = new System.Drawing.Size(75, 23);
   this.button3.TabIndex = 10;
   this.button3.Text = "button3";
   this.button3.UseVisualStyleBackColor = true;
   // 
   // button4
   // 
   this.button4.Location = new System.Drawing.Point(64, 64);
   this.button4.Name = "button4";
   this.button4.Size = new System.Drawing.Size(75, 23);
   this.button4.TabIndex = 11;
   this.button4.Text = "button4";
   this.button4.UseVisualStyleBackColor = true;
   // 
   // button5
   // 
   this.button5.Location = new System.Drawing.Point(72, 72);
   this.button5.Name = "button5";
   this.button5.Size = new System.Drawing.Size(75, 23);
   this.button5.TabIndex = 12;
   this.button5.Text = "button5";
   this.button5.UseVisualStyleBackColor = true;
   // 
   // button6
   // 
   this.button6.Location = new System.Drawing.Point(0, 0);
   this.button6.Name = "button6";
   this.button6.Size = new System.Drawing.Size(75, 23);
   this.button6.TabIndex = 13;
   this.button6.Text = "button6";
   this.button6.UseVisualStyleBackColor = true;
   // 
   // button7
   // 
   this.button7.Location = new System.Drawing.Point(8, 8);
   this.button7.Name = "button7";
   this.button7.Size = new System.Drawing.Size(75, 23);
   this.button7.TabIndex = 14;
   this.button7.Text = "button7";
   this.button7.UseVisualStyleBackColor = true;
   // 
   // openFileDialog1
   // 
   this.openFileDialog1.FileName = "openFileDialog1";
   // 
   // Form1
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(800, 450);
   this.Controls.Add(this.listBox1);
   this.Controls.Add(this.axWindowsMediaPlayer1);
   this.Controls.Add(this.panel1);
   this.Name = "Form1";
   this.Text = "Form1";
   ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
   this.panel1.ResumeLayout(false);
   this.panel1.PerformLayout();
   ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
   ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
   this.ResumeLayout(false);

        }

  #endregion

  private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
  private System.Windows.Forms.ListBox listBox1;
  private System.Windows.Forms.Panel panel1;
  private System.Windows.Forms.Button button7;
  private System.Windows.Forms.Button button6;
  private System.Windows.Forms.Button button5;
  private System.Windows.Forms.Button button4;
  private System.Windows.Forms.Button button3;
  private System.Windows.Forms.Button btn_Stop;
  private System.Windows.Forms.Button btn_Playe;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.MenuStrip 本地文件ToolStripMenuItem;
  private System.Windows.Forms.CheckBox checkBox1;
  private System.Windows.Forms.TrackBar trackBar2;
  private System.Windows.Forms.TrackBar trackBar1;
  private System.Windows.Forms.OpenFileDialog openFileDialog1;
  private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
  private System.Windows.Forms.Timer timer1;
 }
}

