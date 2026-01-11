namespace zdsr
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
   System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("最新帖子");
   System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("热门主题");
   System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("精华主题");
   System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("论坛版块", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
   this.menuStrip1 = new System.Windows.Forms.MenuStrip();
   this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
   this.menuRefresh = new System.Windows.Forms.ToolStripMenuItem();
   this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
   this.statusStrip1 = new System.Windows.Forms.StatusStrip();
   this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
   this.splitContainer1 = new System.Windows.Forms.SplitContainer();
   this.forumTreeView = new System.Windows.Forms.TreeView();
   this.postListView = new System.Windows.Forms.ListView();
   this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
   this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
   this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
   this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
   this.menuStrip1.SuspendLayout();
   this.statusStrip1.SuspendLayout();
   ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
   this.splitContainer1.Panel1.SuspendLayout();
   this.splitContainer1.SuspendLayout();
   this.SuspendLayout();
   // 
   // menuStrip1
   // 
   this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile});
   this.menuStrip1.Location = new System.Drawing.Point(0, 0);
   this.menuStrip1.Name = "menuStrip1";
   this.menuStrip1.Size = new System.Drawing.Size(984, 25);
   this.menuStrip1.TabIndex = 0;
   this.menuStrip1.Text = "menuStrip1";
   // 
   // menuFile
   // 
   this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRefresh,
            this.menuExit});
   this.menuFile.Name = "menuFile";
   this.menuFile.Size = new System.Drawing.Size(58, 21);
   this.menuFile.Text = "文件(&F)";
   // 
   // menuRefresh
   // 
   this.menuRefresh.Name = "menuRefresh";
   this.menuRefresh.Size = new System.Drawing.Size(180, 22);
   this.menuRefresh.Text = "刷新(&R)";
   this.menuRefresh.Click += new System.EventHandler(this.menuRefresh_Click);
   // 
   // menuExit
   // 
   this.menuExit.Name = "menuExit";
   this.menuExit.Size = new System.Drawing.Size(180, 22);
   this.menuExit.Text = "退出(&X)";
   this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
   // 
   // statusStrip1
   // 
   this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
   this.statusStrip1.Location = new System.Drawing.Point(0, 639);
   this.statusStrip1.Name = "statusStrip1";
   this.statusStrip1.Size = new System.Drawing.Size(984, 22);
   this.statusStrip1.TabIndex = 1;
   this.statusStrip1.Text = "statusStrip1";
   // 
   // toolStripStatusLabel1
   // 
   this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
   this.toolStripStatusLabel1.Size = new System.Drawing.Size(32, 17);
   this.toolStripStatusLabel1.Text = "就绪";
   // 
   // splitContainer1
   // 
   this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
   this.splitContainer1.Location = new System.Drawing.Point(0, 25);
   this.splitContainer1.Name = "splitContainer1";
   // 
   // splitContainer1.Panel1
   // 
   this.splitContainer1.Panel1.Controls.Add(this.postListView);
   this.splitContainer1.Panel1.Controls.Add(this.forumTreeView);
   this.splitContainer1.Size = new System.Drawing.Size(984, 614);
   this.splitContainer1.SplitterDistance = 200;
   this.splitContainer1.TabIndex = 2;
   // 
   // forumTreeView
   // 
   this.forumTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
   this.forumTreeView.Location = new System.Drawing.Point(0, 0);
   this.forumTreeView.Name = "forumTreeView";
   treeNode1.Name = "节点1";
   treeNode1.Text = "最新帖子";
   treeNode2.Name = "节点2";
   treeNode2.Text = "热门主题";
   treeNode3.Name = "节点3";
   treeNode3.Text = "精华主题";
   treeNode4.Name = "节点0";
   treeNode4.Text = "论坛版块";
   this.forumTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
   this.forumTreeView.Size = new System.Drawing.Size(200, 614);
   this.forumTreeView.TabIndex = 0;
   this.forumTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.forumTreeView_AfterSelect);
   // 
   // postListView
   // 
   this.postListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
   this.postListView.Cursor = System.Windows.Forms.Cursors.Default;
   this.postListView.Dock = System.Windows.Forms.DockStyle.Fill;
   this.postListView.FullRowSelect = true;
   this.postListView.GridLines = true;
   this.postListView.HideSelection = false;
   this.postListView.Location = new System.Drawing.Point(0, 0);
   this.postListView.Name = "postListView";
   this.postListView.Size = new System.Drawing.Size(200, 614);
   this.postListView.TabIndex = 1;
   this.postListView.UseCompatibleStateImageBehavior = false;
   this.postListView.View = System.Windows.Forms.View.Details;
   // 
   // columnHeader1
   // 
   this.columnHeader1.Text = "标题";
   this.columnHeader1.Width = 400;
   // 
   // columnHeader2
   // 
   this.columnHeader2.Text = "作者";
   this.columnHeader2.Width = 100;
   // 
   // columnHeader3
   // 
   this.columnHeader3.Text = "回复/查看";
   this.columnHeader3.Width = 100;
   // 
   // columnHeader4
   // 
   this.columnHeader4.Text = "最后回复";
   this.columnHeader4.Width = 150;
   // 
   // Form1
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(984, 661);
   this.Controls.Add(this.splitContainer1);
   this.Controls.Add(this.statusStrip1);
   this.Controls.Add(this.menuStrip1);
   this.Name = "Form1";
   this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
   this.Text = "论坛客户端";
   this.menuStrip1.ResumeLayout(false);
   this.menuStrip1.PerformLayout();
   this.statusStrip1.ResumeLayout(false);
   this.statusStrip1.PerformLayout();
   this.splitContainer1.Panel1.ResumeLayout(false);
   ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
   this.splitContainer1.ResumeLayout(false);
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.MenuStrip menuStrip1;
  private System.Windows.Forms.ToolStripMenuItem menuFile;
  private System.Windows.Forms.ToolStripMenuItem menuRefresh;
  private System.Windows.Forms.ToolStripMenuItem menuExit;
  private System.Windows.Forms.StatusStrip statusStrip1;
  private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
  private System.Windows.Forms.SplitContainer splitContainer1;
  private System.Windows.Forms.TreeView forumTreeView;
  private System.Windows.Forms.ListView postListView;
  private System.Windows.Forms.ColumnHeader columnHeader1;
  private System.Windows.Forms.ColumnHeader columnHeader2;
  private System.Windows.Forms.ColumnHeader columnHeader3;
  private System.Windows.Forms.ColumnHeader columnHeader4;
 }
}

