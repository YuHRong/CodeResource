 // 原始数据字符串
 string rawData = @"
1 庾丹萱，积分248，等级 飞升150
2 白暮云，积分247，等级 飞升150
3 司空星辰，积分238，等级 飞升150
4 洛日瑜灰，积分220，等级 飞升150
5 公良栋天，积分219，等级 飞升150
6 淡写你真情，积分213，等级 飞升150
7 诸神黄昏，积分167，等级 飞升150
8 虎牙，积分122，等级 飞升150
9 东方飞剑，积分119，等级 飞升150
1 错了，积分140，等级 105
2 芒果布丁，积分110，等级 119
3 熊猫居士，积分104，等级 140
1 愚者￣克莱恩，积分214，等级 飞升150
2 柠檬为何心酸，积分199，等级 飞升145
3 西门法师，积分119，等级 飞升150
4 极雪悠然，积分108，等级 94
5 恩巧而，积分106，等级 104
6 网兜，积分101，等级 105
1 雲朵，积分225，等级 飞升150
2 公寓德音，积分117，等级 112
3 桃依画月弦，积分110，等级 飞升143
4 容梦雨，积分106，等级 61
1 君鑫，积分237，等级 飞升150
2 匀雪，积分230，等级 飞升150
3 六月，积分215，等级 飞升150
4 吃灰狼的小红帽，积分184，极雪 飞升150
5 云影醉风颜，积分145，等级 飞升极雪150
6 紫灵，积分130，等级 飞升150
7 曜灵，积分110，等级 飞升150
1 白离，积分222，等级 飞升150
2 缪凡双，积分209，等级 65
3 江晚，积分129，等级 飞升149
1 静暮萧湘雨，积分160，等级 飞升150
2 白灵，积分138，等级 84
3 蓝鹰，积分110，等级 转生83
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