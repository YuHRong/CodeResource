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
using Newtonsoft.Json.Linq;


namespace zdsr
{
 public partial class Form1 : Form
 {
  private const string BASE_URL = "http://www.zd.hk/";
  private const string APP_KEY = "your_app_key";
  private const string SEC_KEY = "your_seckey";

  private HttpClient httpClient;

  public Form1()
  {
   InitializeComponent();
   InitializeHttpClient();
  }

  private void InitializeHttpClient()
  {
   httpClient = new HttpClient();
   httpClient.Timeout = TimeSpan.FromSeconds(30);
  }

  private async void Form1_Load(object sender, EventArgs e)
  {
   await LoadLatestPosts();
  }

  private async Task LoadLatestPosts()
  {
   try
   {
    toolStripStatusLabel1.Text = "正在加载最新帖子...";
    postListView.Items.Clear();

   string url = $"{BASE_URL}index-index.htm?format=json&appkey={APP_KEY}&seckey={SEC_KEY}&orderby=tid";

   HttpResponseMessage response = await httpClient.GetAsync(url);
   if (response.IsSuccessStatusCode)
   {
    string json = await response.Content.ReadAsStringAsync();
    JObject result = JObject.Parse(json);

    if (result["status"]?.ToString() == "1")
    {
     JArray posts = result["message"] as JArray;
     if (posts != null)
     {
      foreach (JObject post in posts)
      {
       ListViewItem item = new ListViewItem(post["subject"]?.ToString() ?? "无标题");
       item.SubItems.Add(post["author"]?.ToString() ?? "未知");
       item.SubItems.Add($"{post["replies"]}/{post["views"]}");
       item.SubItems.Add(post["lastpost"]?.ToString() ?? "");
       item.Tag = post["tid"]?.ToString();
       postListView.Items.Add(item);
      }

       toolStripStatusLabel1.Text = $"加载完成，共 {posts.Count} 个帖子";
      }
     }
     else
     {
      toolStripStatusLabel1.Text = "API返回错误状态";
     }
    }
    else
    {
     toolStripStatusLabel1.Text = $"HTTP错误: {response.StatusCode}";
    }
   }
   catch (Exception ex)
   {
    toolStripStatusLabel1.Text = "加载失败";
    MessageBox.Show($"加载帖子时出错: {ex.Message}", "错误");
   }
  }

  // 菜单项事件
  private void menuRefresh_Click(object sender, EventArgs e)
  {
   _ = LoadLatestPosts();
  }

  private void menuExit_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  // 树形视图选择事件
  private void forumTreeView_AfterSelect(object sender, TreeViewEventArgs e)
  {
   if (e.Node.Text == "最新帖子")
   {
    _ = LoadLatestPosts();
   }
  }

  // 列表视图双击事件
  private void postListView_DoubleClick(object sender, EventArgs e)
  {
   if (postListView.SelectedItems.Count > 0)
   {
    string tid = postListView.SelectedItems[0].Tag as string;
    if (!string.IsNullOrEmpty(tid))
    {
     MessageBox.Show($"打开贴子 ID: {tid}", "帖子详情");
    }
   }
  }

  protected override void OnFormClosing(FormClosingEventArgs e)
  {
   httpClient?.Dispose();
   base.OnFormClosing(e);
  }
 }
}
