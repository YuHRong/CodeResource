using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace forum
{
 public partial class Form1 : Form
 {
  private HttpClient httpClient;
  private int currentPage = 1;
  private const int pageSize = 20;

  public Form1()
  {
   InitializeComponent();
   httpClient = new HttpClient();

   // 设置DataGridView的列（如果设计器没设置好）
   if (dgvPosts.Columns.Count == 0)
   {
    dgvPosts.Columns.Add("Title", "标题");
    dgvPosts.Columns.Add("Author", "作者");
    dgvPosts.Columns.Add("ReplyCount", "回复数");
    dgvPosts.Columns.Add("LastReplyTime", "最后更新");
   }
  }

  // 窗体加载时自动获取帖子
  private async void Form1_Load(object sender, EventArgs e)
  {
   await LoadPosts();
  }

  // 刷新按钮点击事件
  private async void tsbRefresh_Click(object sener, EventArgs e)
  {
   currentPage = 1;
   await LoadPosts();
  }

  // 上一页按钮点击事件
  private async void tsbPrev_Click(object sender, EventArgs e)
  {
   if (currentPage > 1)
   {
    currentPage--;
    await LoadPosts();
   }
  }

  // 下一页按钮点击事件
  private async void tsbNext_click(object sender, EventArgs e)
  {
   currentPage++;
   await LoadPosts();
  }

  // 搜索按钮点击事件
  private async void tsbSearch_Click(object sender, EventArgs e)
  {
   string keyword = tstSearch.Text.Trim();
   if (string.IsNullOrEmpty(keyword))
   {
    await LoadPosts();
   }
   else
   {
    await SearchPosts(keyword);
   }
  }

  // 选择帖子行变化事件
  private async void dgvPosts_SelectionChanged(object sender, EventArgs e)
  {
   if (dgvPosts.SelectedRows.Count > 0 && dgvPosts.SelectedRows[0].Cells[0].Value != null)
   {
    string postTitle = dgvPosts.SelectedRows[0].Cells[0].Value.ToString();
    await LoadPostContent(postTitle);
   }
  }

  // 加载帖子列表

 }
}
/*
 * 明白了！作为初学者，我们完全使用设计器的属性面板来设置控件，避免直接修改Designer.cs文件。让我重新详细说明步骤：
第一步：创建项目
打开VS2022 → 新建项目 → Windows窗体应用(.NET Framework) → 命名"ForumBrowser"
第二步：通过设计器添加和设置控件
1. 设置主窗体属性
在窗体空白处点击 → 属性面板中设置：
Text: "论坛浏览器 v1.0"
Size: 1000, 700
StartPosition: CenterScreen
2. 添加SplitContainer（分割容器）
从工具箱拖动SplitContainer到窗体
属性设置：
Dock: Fill
Orientation: Horizontal（水平分割）
SplitterDistance: 300（上下面板高度比例）
3. 在上部面板(Panel1)添加控件
添加DataGridView（帖子列表）：
拖动DataGridView到上部面板
属性设置：
Name: dgvPosts
Dock: Fill
ReadOnly: True
AutoSizeColumnsMode: Fill
添加列：
点击DataGridView右上角的小箭头 → 选择"编辑列"
添加列：
名称: "标题", DataPropertyName: "Title"
名称: "作者", DataPropertyName: "Author", Width: 100
名称: "回复数", DataPropertyName: "ReplyCount", Width: 80
名称: "最后更新", DataPropertyName: "LastUpdate", Width: 120
4. 在下部面板(Panel2)添加控件
添加RichTextBox（帖子内容）：
拖动RichTextBox到下部面板
属性设置：
Name: rtbContent
Dock: Fill
ReadOnly: True
BackColor: White
5. 添加ToolStrip（工具栏）
添加工具栏：
拖动ToolStrip到窗体（会自动停靠在顶部）
属性设置：
Name: toolStrip1
添加工具栏按钮：
点击ToolStrip的"添加工具项"按钮（小箭头）
依次添加：
ToolStripButton → 名称: tsbRefresh, Text: "刷新"
ToolStripSeparator（分隔线）
ToolStripButton → 名称: tsbPrev, Text: "上一页"
ToolStripButton → 名称: tsbNext, Text: "下一页"
ToolStripSeparator
ToolStripTextBox → 名称: tstSearch, Size: 200, 25
ToolStripButton → 名称: tsbSearch, Text: "搜索"
6. 添加StatusStrip（状态栏）
添加状态栏：
拖动StatusStrip到窗体（会自动停靠在底部）
属性设置：
Name: statusStrip1
添加状态标签：
点击StatusStrip的"添加工具项"按钮
添加ToolStripStatusLabel → 名称: tsslStatus, Text: "就绪"
第三步：最终窗体布局结构
Form1 (论坛浏览器 v1.0)
├── ToolStrip (顶部工具栏)
├── SplitContainer (分割容器)
│ ├── Panel1 (上部 - 帖子列表)
│ │ └── DataGridView (帖子表格)
│ └── Panel2 (下部 - 帖子内容)
│ └── RichTextBox (内容显示)
└── StatusStrip (底部状态栏)
第四步：编写事件处理代码（Form1.cs）
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ForumBrowser
{
 public partial class Form1 : Form
 {
 private HttpClient httpClient;
 private int currentPage = 1;
 private const int pageSize = 20;

 public Form1()
 {
 InitializeComponent();
 httpClient = new HttpClient();
 
 // 设置DataGridView的列（如果设计器没设置好）
 if (dgvPosts.Columns.Count == 0)
 {
 dgvPosts.Columns.Add("Title", "标题");
 dgvPosts.Columns.Add("Author", "作者");
 dgvPosts.Columns.Add("ReplyCount", "回复数");
 dgvPosts.Columns.Add("LastUpdate", "最后更新");
 }
 }

 // 窗体加载时自动获取帖子
 private async void Form1_Load(object sender, EventArgs e)
 {
 await LoadPosts();
 }

 // 刷新按钮点击事件
 private async void tsbRefresh_Click(object sender, EventArgs e)
 {
 currentPage = 1;
 await LoadPosts();
 }

 // 上一页按钮点击事件
 private async void tsbPrev_Click(object sender, EventArgs e)
 {
 if (currentPage > 1)
 {
 currentPage--;
 await LoadPosts();
 }
 }

 // 下一页按钮点击事件
 private async void tsbNext_Click(object sender, EventArgs e)
 {
 currentPage++;
 await LoadPosts();
 }

 // 搜索按钮点击事件
 private async void tsbSearch_Click(object sender, EventArgs e)
 {
 string keyword = tstSearch.Text.Trim();
 if (string.IsNullOrEmpty(keyword))
 {
 await LoadPosts();
 }
 else
 {
 await SearchPosts(keyword);
 }
 }

 // 选择帖子行变化事件
 private async void dgvPosts_SelectionChanged(object sender, EventArgs e)
 {
 if (dgvPosts.SelectedRows.Count > 0 && dgvPosts.SelectedRows[0].Cells[0].Value != null)
 {
 string postTitle = dgvPosts.SelectedRows[0].Cells[0].Value.ToString();
 await LoadPostContent(postTitle);
 }
 }

 // 加载帖子列表
 private async Task LoadPosts()
 {
 try
 {
 tsslStatus.Text = "加载中...";
 dgvPosts.Rows.Clear();

 // 模拟API调用 - 实际使用时替换为真实API
 await Task.Delay(500); // 模拟网络延迟
 
 // 模拟数据 - 替换为真实API调用
 var mockPosts = new List<Post>
 {
 new Post { Title = "欢迎来到论坛！", Author = "管理员", ReplyCount = 15, LastUpdate = DateTime.Now.AddHours(-1) },
 new Post { Title = "C#学习交流", Author = "初学者", ReplyCount = 8, LastUpdate = DateTime.Now.AddHours(-2) },
 new Post { Title = "WinForms开发技巧", Author = "资深开发者", ReplyCount = 23, LastUpdate = DateTime.Now.AddHours(-3) }
 };

 foreach (var post in mockPosts)
 {
 dgvPosts.Rows.Add(post.Title, post.Author, post.ReplyCount, post.LastUpdate.ToString("yyyy-MM-dd HH:mm"));
 }

 tsslStatus.Text = $"第 {currentPage} 页，共 {mockPosts.Count} 条帖子";
 }
 catch (Exception ex)
 {
 tsslStatus.Text = "加载失败";
 MessageBox.Show($"错误: {ex.Message}");
 }
 }

 // 加载帖子内容
 private async Task LoadPostContent(string postTitle)
 {
 try
 {
 rtbContent.Clear();
 tsslStatus.Text = "加载帖子内容...";

 // 模拟API调用
 await Task.Delay(300);

 // 模拟帖子内容
 StringBuilder content = new StringBuilder();
 content.AppendLine($"标题: {postTitle}");
 content.AppendLine($"作者: {dgvPosts.SelectedRows[0].Cells[1].Value}");
 content.AppendLine($"时间: {DateTime.Now:yyyy-MM-dd HH:mm}");
 content.AppendLine();
 content.AppendLine("这里是帖子的正文内容...");
 content.AppendLine();
 content.AppendLine("回复列表:");
 content.AppendLine(new string('-', 50));
 content.AppendLine();
 content.AppendLine("#1楼 用户A (2024-01-01 10:00):");
 content.AppendLine("这个帖子很有帮助！");
 content.AppendLine();
 content.AppendLine("#2楼 用户B (2024-01-01 10:30):");
 content.AppendLine("感谢分享！");

 rtbContent.Text = content.ToString();
 tsslStatus.Text = "内容加载完成";
 }
 catch (Exception ex)
 {
 tsslStatus.Text = "加载内容失败";
 MessageBox.Show($"错误: {ex.Message}");
 }
 }

 // 搜索帖子
 private async Task SearchPosts(string keyword)
 {
 // 实现搜索逻辑
 await LoadPosts(); // 暂时用加载帖子代替
 tsslStatus.Text = $"搜索: {keyword}";
 }
 }

 // 数据模型类
 public class Post
 {
 public string Title { get; set; }
 public string Author { get; set; }
 public int ReplyCount { get; set; }
 public DateTime LastUpdate { get; set; }
 }
}
第五步：设置事件处理程序
在设计器中设置事件：
双击"刷新"按钮 → 自动生成tsbRefresh_Click方法
双击"上一页"按钮 → 自动生成tsbPrev_Click方法
双击"下一页"按钮 → 自动生成tsbNext_Click方法
双击"搜索"按钮 → 自动生成tsbSearch_Click方法
点击DataGridView → 属性面板的事件标签 → 双击SelectionChanged → 自动生成dgvPosts_SelectionChanged方法
点击窗体空白处 → 属性面板的事件标签 → 双击Load → 自动生成Form1_Load方法
这样你就完全通过设计器完成了界面布局和事件绑定！
*/