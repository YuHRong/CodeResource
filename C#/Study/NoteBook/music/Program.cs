int bpm = 90;  // 速度
string key = "C";  // C大调
string tS = "4 /4";  // 拍号（time signature 缩写
string[] chord = { "I", "VII", "IV", "V" };  // 和弦进行数组
string[] soundP = { "引子", "a1", "b1", "c1", "间奏", "b2", "c1", "c2", "c3", "end" };  // 段落数组, sound passage缩写
string soundLRC = "";  // 歌词

const int INTRO_INDEX = 0;  // 引子在soundP数组中的索引
const int INTERLUDE_INDEX = 4;  // 引子在soundP中的数组索引
const int END_INDEX = 9;  //结尾在soundP中的数组索引

Console.WriteLine($"\t{key}: 大调\n\t速度: {bpm}\n\t拍号: {tS}");

Intro();  // 引子
First();  // A段
Interlude();  // 间奏
Second();  // B段
End();  // 结尾

void PlaySection(string sectionName, int startIndex, int endIndex)
{
    for (int i = startIndex; i <= endIndex; i++)
    {
        Console.WriteLine($"{sectionName}: {soundP[i]}: 歌词： {soundLRC}");
        Chord();
    }
}

void PlayRepeatedPassage(int passageIndex, int repeatCount = 2)
{
    // 重复播放指定段落
    for (int i = 0; i < repeatCount; i++)
    {
        //输出段落名称
        Console.Write($"{soundP[passageIndex]}: ");
        Chord();
    }
}

void Intro()
{
    PlayRepeatedPassage(INTRO_INDEX);
}

void First()
{
    PlaySection("A段", 1, 3);
}

void Interlude()
{
    PlayRepeatedPassage(INTERLUDE_INDEX);
}

void Second()
{
    PlaySection("B段", 5, 8); // 播放B段（索引5到8的段落）
}

void End()
{
    Console.WriteLine(soundP[END_INDEX]);
}

void Chord()
{
    Console.WriteLine($"和弦: {string.Join("-", chord)}");
}
