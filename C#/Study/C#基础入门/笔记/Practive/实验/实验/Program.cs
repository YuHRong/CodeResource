// 原始数据字符串
string rawData = @"
1  ，积分265，等级 飞升150
2 庾丹萱，积分247，等级 飞升150
4 公良栋天，积分208，等级 飞升150
5 喬巧，积分199，等级 飞升150
6 无双飞剑，积分203，等级 飞升150
7 无名者，积分185，等级 飞升150
8 聂科予，积分185，等级 76
9 虎牙，积分150，等级 飞升150
1 云影青梨洛浅溪，积分168，等级 飞升150
1 白狸，积分204，等级 飞升150
2 神锋无影，积分162，等级 飞升145
1 雪中望月，积分209，等级 飞升150
2 六月，积分164，等级 飞升150
3 云影醉风颜，积分149，等级 飞升150
4 建是残云，积分140，等级 89
1 麦糖蛋卷，积分217，等级 飞升150
2   ，积分193，等级 飞升150
3 月下观雪，积分165，等级 飞升150
1 流腥，积分220，等级 飞升150
1 马到成功，积分206，等级 飞升150
";

 // 转换数据为Player对象列表
 List<Player> players = ConvertRawDataToPlayers(rawData);

 // 按积分降序排序
 players = players.OrderByDescending(p => p.Score).ToList();

 // 输出前16名排名
 Console.WriteLine("玩家排名列表：");
 Console.WriteLine("排名\t玩家姓名\t\t积分\t等级");
 Console.WriteLine("--------------------------------------------------");
 
 for (int i = 0; i < players.Count && i < 16; i++)
 {
 // 格式化输出，确保对齐
 string name = players[i].Name.PadRight(10, ' ');
 if (players[i].Name.Length > 6) // 长名字处理
 name = players[i].Name.PadRight(12, ' ');
 
 Console.WriteLine($"第{i + 1}名\t{name}\t{players[i].Score}\t{players[i].Level}");
 }

 // 确定实际参赛人数（最多16人）
 int playerCount = Math.Min(players.Count, 16);
 int matchCount = playerCount / 2;

 Console.WriteLine("\n比赛对阵安排：");
 Console.WriteLine("--------------------------------------------------");
 Console.WriteLine("组别\t对阵双方\t\t\t\t积分对比");
 Console.WriteLine("--------------------------------------------------");
 
 // 输出对阵安排：第1名vs最后1名，第2名vs倒数第2名，以此类推
 for (int i = 0; i < matchCount; i++)
 {
 int topIndex = i;
 int bottomIndex = playerCount - 1 - i;
 
 string topPlayer = $"{players[topIndex].Name}(积分{players[topIndex].Score})";
 string bottomPlayer = $"{players[bottomIndex].Name}(积分{players[bottomIndex].Score})";
 
 // 格式化对阵显示
 string vsMatch = $"{topPlayer.PadRight(25, ' ')} - {bottomPlayer.PadRight(25, ' ')}";
 Console.WriteLine($"{i + 1}\t{vsMatch}");
 }
 
 Console.WriteLine("--------------------------------------------------");
 
 // 等待用户按回车键退出
 Console.WriteLine("\n按回车退出...");
 Console.ReadLine();
 

 // 转换原始数据为Player对象列表
 static List<Player> ConvertRawDataToPlayers(string rawData)
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


// 玩家类
class Player
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