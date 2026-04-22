// 原始数据字符串
 string rawData = @"
1 白暮云，积分224，等级 飞升150
2 洛日瑜灰，积分207，等级 飞升150
3 淡写你真情，积分203，等级 飞升150
4 公良栋天，积分202，等级 飞升150
5 庾丹萱，积分177，等级 飞升150
6 虎牙，积分175，等级 飞升150
7 司空星辰，积分164，等级 飞升150
8 诸神黄昏，积分158，等级 飞升150
9 宇文幽，积分146，等级 110
10 芒果西米露，积分135，等级 飞升150
1 芒果布丁，积分110，等级 119
2 景璇玑，积分96，等级 58
1 北萌星，积分154，等级 飞升150
2 熊猫王子，积分146，等级 飞升150
3 牧羊小哥，积分141，等级 115
4 西门法师，积分110，等级 飞升150
1 雲朵，积分206，等级 飞升150
2 Ella，积分117，等级 121
3 桃依画月弦，积分110，等级 飞升143
1 匀雪，积分215，等级 飞升150
2 君鑫，积分166，等级 飞升150
3 云影醉风颜，积分150，等级 飞升150
4 六月，积分143，等级 飞升150
5 曜灵，积分117，等级 飞升150
1 白离，积分138，等级 飞升150
2 江晚，积分125，等级 飞升149
3 時光剪影，积分114，等级 140
1 静暮萧湘雨，积分152，等级 飞升150
2 蓝鹰，积分144，等级 转生83
3 微笑的风，积分94，等级 117
1 马到成功，积分110，等级 飞升150
";

 // 转换数据为Player对象列表
 List<Player> players = ConvertRawDataToPlayers(rawData);

 // 按积分降序排序
 players = players.OrderByDescending(p => p.Score).ToList();

 // 显示前16名排名
 DisplayRankings(players);
 
 // 显示对阵安排
 DisplayMatchups(players);
 

 private void DisplayRankings(List<Player> players)
 {
 rankingsTextBox.Clear();
 rankingsTextBox.AppendText("玩家排名列表：\r\n");
 rankingsTextBox.AppendText("排名\t玩家姓名\t\t积分\t等级\r\n");
 rankingsTextBox.AppendText("--------------------------------------------------\r\n");
 
 for (int i = 0; i < players.Count && i < 16; i++)
 {
 // 格式化输出，确保对齐
 string name = players[i].Name.PadRight(10, ' ');
 if (players[i].Name.Length > 6) // 长名字处理
 name = players[i].Name.PadRight(12, ' ');
 
 rankingsTextBox.AppendText($"第{i + 1}名\t{name}\t{players[i].Score}\t{players[i].Level}\r\n");
 }
 }

 //private void DisplayMatchups(List<Player> players)
 {
 //matchupsTextBox.Clear();
 
 // 确定实际参赛人数（最多16人）
 int playerCount = Math.Min(players.Count, 16);
 int matchCount = playerCount / 2;


 matchupsTextBox.AppendText("\r\n比赛对阵安排：\r\n");
 matchupsTextBox.AppendText("--------------------------------------------------\r\n");
 matchupsTextBox.AppendText("组别\t对阵双方\t\t\t\t积分对比\r\n");
 matchupsTextBox.AppendText("--------------------------------------------------\r\n");
 
 // 输出对阵安排：第1名vs最后1名，第2名vs倒数第2名，以此类推
 for (int i = 0; i < matchCount; i++)
 {
 int topIndex = i;
 int bottomIndex = playerCount - 1 - i;
 
 string topPlayer = $"{players[topIndex].Name}(积分{players[topIndex].Score})";
 string bottomPlayer = $"{players[bottomIndex].Name}(积分{players[bottomIndex].Score})";
 
 // 格式化对阵显示
 string vsMatch = $"{topPlayer.PadRight(25, ' ')} - {bottomPlayer.PadRight(25, ' ')}";
 matchupsTextBox.AppendText($"{i + 1}\t{vsMatch}\r\n");
 }
 
 matchupsTextBox.AppendText("--------------------------------------------------\r\n");
 }

 // 转换原始数据为Player对象列表
 private List<Player> ConvertRawDataToPlayers(string rawData)
 {
 List<Player> players = new List<Player>();
 
 // 按行分割数据
 string[] lines = rawData.Split('\n', StringSplitOptions.RemoveEmptyEntries);
 
 foreach (string line in lines)
 {
 // 跳过空行
 if (string.IsNullOrWhiteSpace(line)) continue;
 
 // 移除行首的数字和空格
 string cleanLine = line.Trim();
 int firstSpaceIndex = cleanLine.IndexOf(' ');
 if (firstSpaceIndex > 0)
 {
 cleanLine = cleanLine.Substring(firstSpaceIndex).Trim();
 }
 
 // 分割姓名、积分和等级
 int nameEndIndex = cleanLine.IndexOf('，');
 if (nameEndIndex == -1) continue;
 
 string name = cleanLine.Substring(0, nameEndIndex);
 string remaining = cleanLine.Substring(nameEndIndex + 1);
 
 // 提取积分
 int scoreStartIndex = remaining.IndexOf("积分");
 if (scoreStartIndex == -1) continue;
 scoreStartIndex += 2;
 
 int scoreEndIndex = remaining.IndexOf('，', scoreStartIndex);
 if (scoreEndIndex == -1) scoreEndIndex = remaining.Length;
 
 string scoreStr = remaining.Substring(scoreStartIndex, scoreEndIndex - scoreStartIndex).Trim();
 if (!int.TryParse(scoreStr, out int score))
 {
 continue; // 跳过无法解析的行
 }
 
 // 提取等级
 int levelStartIndex = remaining.IndexOf("等级");
 if (levelStartIndex == -1) 
 {
 // 尝试其他可能的等级标识
 levelStartIndex = remaining.IndexOf("极雪");
 if (levelStartIndex == -1) continue;
 }
 
 levelStartIndex += 2;
 string level = remaining.Substring(levelStartIndex).Trim();
 
 players.Add(new Player(name, score, level));
 }
 
 return players;
 }

 private void exitButton_Click(object sender, EventArgs e)
 {
 Application.Exit();
 }
 

 // 玩家类
 public class Player
 {
 public string Name { get; set; }
 public int Score { get; set; }
 public string Level { get; set; }
 
 public Player(string name, int score, string level)
 {
 Name = name;
 Score = score;
 Level = level;
 }
 }

// 修复后的 MainForm.Designer.cs
namespace PlayerRankingApp
{
 partial class MainForm;
 
 private System.ComponentModel.IContainer components = null;
 
 private System.Windows.Forms.TextBox rankingsTextBox;
 private System.Windows.Forms.TextBox matchupsTextBox;
 private System.Windows.Forms.Button exitButton;
 
 protected override void Dispose(bool disposing)
 {
 if (disposing && (components != null))
 {
 components.Dispose();
 }
 base.Dispose(disposing);
 }
 
 private void InitializeComponent()
 {
 this.rankingsTextBox = new System.Windows.Forms.TextBox();
 this.matchupsTextBox = new System.Windows.Forms.TextBox();
 this.exitButton = new System.Windows.Forms.Button();
 this.SuspendLayout();
 
 // rankingsTextBox
 this.rankingsTextBox.Location = new System.Drawing.Point(12, 12);
 this.rankingsTextBox.Multiline = true;
 this.rankingsTextBox.Name = "rankingsTextBox";
 this.rankingsTextBox.ReadOnly = true;
 this.rankingsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
 this.rankingsTextBox.Size = new System.Drawing.Size(600, 250);
 this.rankingsTextBox.TabIndex = 0;
 
 // matchupsTextBox
 this.matchupsTextBox.Location = new System.Drawing.Point(12, 280);
 this.matchupsTextBox.Multiline = true;
 this.matchupsTextBox.Name = "matchupsTextBox";
 this.matchupsTextBox.ReadOnly = true;
 this.matchupsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
 this.matchupsTextBox.Size = new System.Drawing.Size(600, 200);
 this.matchupsTextBox.TabIndex = 1;
 
 // exitButton
 this.exitButton.Location = new System.Drawing.Point(537, 500);
 this.exitButton.Name = "exitButton";
 this.exitButton.Size = new System.Drawing.Size(75, 30);
 this.exitButton.TabIndex = 2;
 this.exitButton.Text = "退出";
 this.exitButton.UseVisualStyleBackColor = true;
 this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
 
 // MainForm
 this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
 this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
 this.ClientSize = new System.Drawing.Size(624, 541);
 this.Controls.Add(this.exitButton);
 this.Controls.Add(this.matchupsTextBox);
 this.Controls.Add(this.rankingsTextBox);
 this.Name = "MainForm";
 this.Text = "玩家排名与对阵安排";
 this.ResumeLayout(false);
 this.PerformLayout();
 }
 }

