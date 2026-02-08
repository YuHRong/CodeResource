// 原始数据字符串
string rawData = @"
1  ，积分241，等级 飞升150
2 庾丹萱，积分235，等级 飞升150
3 流兴，积分220，等级 飞升150
4 公良栋天，积分210，等级 飞升150
5 紫藤星月，积分160，等级 飞升150
6 东方飞剑，积分119，等级 飞升150
7 语晗，积分110，等级 飞升150
8 meteor，积分106，等级 飞升150
1 芒果布丁，积分110，等级 119
2 艳阳焚天，积分110，等级 56
3 公孙幼怡，积分78，等级 92
1 西门法师，积分110，等级 飞升150
2 莫雪璃殇，积分96，等级 117
3 MR_Key，积分96，等级 101
1 秋风，积分135，等级 131
2 公冶天亦，积分96，等级 150
3 破麻，积分91，等级 70
1 云影醉风颜，积分145，等级 飞升150
2 曜灵，积分110，等级 飞升150
3 缙云山城，积分96，等级 飞升150
1   ，积分201，等级 飞升150
2 麦糖蛋卷，积分198，等级 飞升150
1 马到成功，积分202，等级 飞升150
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