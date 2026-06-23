// 创建 COnter 类的实例
 var counter = new Counter(10);

// 订阅ThresholdReached活动：
counter.ThresholdReached += (sender, e) =>
{
 Console.WriteLine("Threshold reached!");
};

// 使用 Add 方法递增计数值，验证当超过阈值时是否会触发事件
counter.Add(3);
counter.Add(2); // This should trigger the event

// var counter = new Counter(10);

counter.ThresholdReached += Counter_ThresholdReached;
static void Counter_ThresholdReached(object? sender, ThresholdReachedEventArgs e)
{
    Console.WriteLine($"Threshold of {e.Threshold} reached at {e.TimeReached}.");
}