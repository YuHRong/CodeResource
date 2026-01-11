namespace forum
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
   this.splitContainer1 = new System.Windows.Forms.SplitContainer();
   this.dgvPosts = new System.Windows.Forms.DataGridView();
   this.标题 = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.回复数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.作者 = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.最后更新 = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.rtbContent = new System.Windows.Forms.RichTextBox();
   this.toolStrip1 = new System.Windows.Forms.ToolStrip();
   this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
   this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
   this.tsbPrev = new System.Windows.Forms.ToolStripButton();
   this.tsbNext = new System.Windows.Forms.ToolStripButton();
   this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
   this.tstSearch = new System.Windows.Forms.ToolStripTextBox();
   this.tsbSearch = new System.Windows.Forms.ToolStripButton();
   this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
   this.statusStrip1 = new System.Windows.Forms.StatusStrip();
   ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
   this.splitContainer1.Panel1.SuspendLayout();
   this.splitContainer1.Panel2.SuspendLayout();
   this.splitContainer1.SuspendLayout();
   ((System.ComponentModel.ISupportInitialize)(this.dgvPosts)).BeginInit();
   this.toolStrip1.SuspendLayout();
   this.statusStrip1.SuspendLayout();
   this.SuspendLayout();
   // 
   // splitContainer1
   // 
   this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
   this.splitContainer1.Location = new System.Drawing.Point(0, 0);
   this.splitContainer1.Name = "splitContainer1";
   this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
   // 
   // splitContainer1.Panel1
   // 
   this.splitContainer1.Panel1.Controls.Add(this.dgvPosts);
   // 
   // splitContainer1.Panel2
   // 
   this.splitContainer1.Panel2.Controls.Add(this.rtbContent);
   this.splitContainer1.Size = new System.Drawing.Size(984, 661);
   this.splitContainer1.SplitterDistance = 300;
   this.splitContainer1.TabIndex = 0;
   // 
   // dgvPosts
   // 
   this.dgvPosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.dgvPosts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.标题,
            this.回复数,
            this.作者,
            this.最后更新});
   this.dgvPosts.Dock = System.Windows.Forms.DockStyle.Fill;
   this.dgvPosts.Location = new System.Drawing.Point(0, 0);
   this.dgvPosts.Name = "dgvPosts";
   this.dgvPosts.ReadOnly = true;
   this.dgvPosts.RowTemplate.Height = 23;
   this.dgvPosts.Size = new System.Drawing.Size(984, 300);
   this.dgvPosts.TabIndex = 0;
   // 
   // 标题
   // 
   this.标题.DataPropertyName = "Title";
   this.标题.HeaderText = "Column1";
   this.标题.Name = "标题";
   this.标题.ReadOnly = true;
   // 
   // 回复数
   // 
   this.回复数.DataPropertyName = "ReplyCount";
   this.回复数.HeaderText = "Column1";
   this.回复数.Name = "回复数";
   this.回复数.ReadOnly = true;
   this.回复数.Width = 80;
   // 
   // 作者
   // 
   this.作者.DataPropertyName = "Author";
   this.作者.HeaderText = "Column1";
   this.作者.Name = "作者";
   this.作者.ReadOnly = true;
   // 
   // 最后更新
   // 
   this.最后更新.DataPropertyName = "LastUpdate";
   this.最后更新.HeaderText = "Column1";
   this.最后更新.Name = "最后更新";
   this.最后更新.ReadOnly = true;
   this.最后更新.Width = 120;
   // 
   // rtbContent
   // 
   this.rtbContent.BackColor = System.Drawing.Color.White;
   this.rtbContent.Dock = System.Windows.Forms.DockStyle.Fill;
   this.rtbContent.Location = new System.Drawing.Point(0, 0);
   this.rtbContent.Name = "rtbContent";
   this.rtbContent.ReadOnly = true;
   this.rtbContent.Size = new System.Drawing.Size(984, 357);
   this.rtbContent.TabIndex = 2;
   this.rtbContent.Text = "";
   // 
   // toolStrip1
   // 
   this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRefresh,
            this.toolStripSeparator1,
            this.tsbPrev,
            this.tsbNext,
            this.toolStripSeparator2,
            this.tstSearch,
            this.tsbSearch});
   this.toolStrip1.Location = new System.Drawing.Point(0, 0);
   this.toolStrip1.Name = "toolStrip1";
   this.toolStrip1.Size = new System.Drawing.Size(984, 25);
   this.toolStrip1.TabIndex = 1;
   this.toolStrip1.Text = "toolStrip1";
   // 
   // tsbRefresh
   // 
   this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
   this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
   this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
   this.tsbRefresh.Name = "tsbRefresh";
   this.tsbRefresh.Size = new System.Drawing.Size(23, 22);
   this.tsbRefresh.Text = "刷新";
   // 
   // toolStripSeparator1
   // 
   this.toolStripSeparator1.Name = "toolStripSeparator1";
   this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
   // 
   // tsbPrev
   // 
   this.tsbPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
   this.tsbPrev.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrev.Image")));
   this.tsbPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
   this.tsbPrev.Name = "tsbPrev";
   this.tsbPrev.Size = new System.Drawing.Size(23, 22);
   this.tsbPrev.Tag = "上一页";
   this.tsbPrev.Text = "toolStripButton1";
   // 
   // tsbNext
   // 
   this.tsbNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
   this.tsbNext.Image = ((System.Drawing.Image)(resources.GetObject("tsbNext.Image")));
   this.tsbNext.ImageTransparentColor = System.Drawing.Color.Magenta;
   this.tsbNext.Name = "tsbNext";
   this.tsbNext.Size = new System.Drawing.Size(23, 22);
   this.tsbNext.Text = "下一页";
   // 
   // toolStripSeparator2
   // 
   this.toolStripSeparator2.Name = "toolStripSeparator2";
   this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
   // 
   // tstSearch
   // 
   this.tstSearch.Name = "tstSearch";
   this.tstSearch.Size = new System.Drawing.Size(200, 25);
   // 
   // tsbSearch
   // 
   this.tsbSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
   this.tsbSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearch.Image")));
   this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
   this.tsbSearch.Name = "tsbSearch";
   this.tsbSearch.Size = new System.Drawing.Size(23, 22);
   this.tsbSearch.Text = "搜索";
   // 
   // tsslStatus
   // 
   this.tsslStatus.Name = "tsslStatus";
   this.tsslStatus.Size = new System.Drawing.Size(32, 17);
   this.tsslStatus.Text = "就绪";
   // 
   // statusStrip1
   // 
   this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus});
   this.statusStrip1.Location = new System.Drawing.Point(0, 639);
   this.statusStrip1.Name = "statusStrip1";
   this.statusStrip1.Size = new System.Drawing.Size(984, 22);
   this.statusStrip1.TabIndex = 2;
   this.statusStrip1.Text = "statusStrip1";
   // 
   // Form1
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(984, 661);
   this.Controls.Add(this.statusStrip1);
   this.Controls.Add(this.toolStrip1);
   this.Controls.Add(this.splitContainer1);
   this.Name = "Form1";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "论坛";
   this.splitContainer1.Panel1.ResumeLayout(false);
   this.splitContainer1.Panel2.ResumeLayout(false);
   ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
   this.splitContainer1.ResumeLayout(false);
   ((System.ComponentModel.ISupportInitialize)(this.dgvPosts)).EndInit();
   this.toolStrip1.ResumeLayout(false);
   this.toolStrip1.PerformLayout();
   this.statusStrip1.ResumeLayout(false);
   this.statusStrip1.PerformLayout();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.SplitContainer splitContainer1;
  private System.Windows.Forms.DataGridView dgvPosts;
  private System.Windows.Forms.DataGridViewTextBoxColumn 标题;
  private System.Windows.Forms.DataGridViewTextBoxColumn 回复数;
  private System.Windows.Forms.DataGridViewTextBoxColumn 作者;
  private System.Windows.Forms.DataGridViewTextBoxColumn 最后更新;
  private System.Windows.Forms.RichTextBox rtbContent;
  private System.Windows.Forms.ToolStrip toolStrip1;
  private System.Windows.Forms.ToolStripButton tsbRefresh;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
  private System.Windows.Forms.ToolStripButton tsbPrev;
  private System.Windows.Forms.ToolStripButton tsbNext;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
  private System.Windows.Forms.ToolStripTextBox tstSearch;
  private System.Windows.Forms.ToolStripButton tsbSearch;
  private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
  private System.Windows.Forms.StatusStrip statusStrip1;
 }
}

