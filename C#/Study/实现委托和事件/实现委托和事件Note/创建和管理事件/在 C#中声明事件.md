# 在 C#中声明事件

## 目录在这里

- [在 C#中声明事件](#在-c中声明事件)
  - [目录在这里](#目录在这里)
  - [声明事件](#声明事件)
    - [示例：声明和触发事件](#示例声明和触发事件)
  - [在继承中使用事件](#在继承中使用事件)
    - [示例：在基类中声明和引发事件](#示例在基类中声明和引发事件)
  - [声明事件的最佳实践](#声明事件的最佳实践)

C#中的事件是一种强大的机制，它允许对象通过发出感兴趣事件发生时的信号来进行通信。  
这一概念对于希望构建交互式和可维护应用程序的开发者来说至关重要。

通过在基类中声明事件，派生类可以引发或处理这些事件，确保组件之间的高效通信，同时保持代码的条理化和可重用性。

## 声明事件

事件使一个类或对象能够在感兴趣的事情发生时通知其他类或对象。
发布者是指定义并触发事件的类，而订阅者是指附加方法来处理事件的类。  
在 C#中，使用 `event` 关键字来声明事件，确保只有发布者类可以触发它，而订阅者可以附加可执行代码来响应它。

### 示例：声明和触发事件

```c#
public class Counter
{
    public event EventHandler ThresholdReached;

    protected virtual void OnThresholdReached(EventArgs e)
    {
        ThresholdReached?.Invoke(this, e);
    }

    public void Increment(int value, int threshold)
    {
        if (value >= threshold)
        {
            OnThresholdReached(EventArgs.Empty);
        }
    }
}

// Subscribing to the event
Counter counter = new Counter();
counter.ThresholdReached += (sender, e) => Console.WriteLine("Threshold reached!");

// Triggering the event
counter.Increment(10, 5); // Output: "Threshold reached!"
```

*注*没有任何订阅者的事件永远不会被触发。

## 在继承中使用事件

在需要跨多个类共享事件功能的场景中，你可以在基类中声明事件，并允许派生类来触发或处理它们。
这种方法促进了代码复用并简化了维护。

### 示例：在基类中声明和引发事件

```c#
public class BaseCounter
{
    public event EventHandler ThresholdReached;

    protected virtual void OnThresholdReached(EventArgs e)
    {
        ThresholdReached?.Invoke(this, e);
    }

    public void Increment(int value, int threshold)
    {
        if (value >= threshold)
        {
            OnThresholdReached(EventArgs.Empty);
        }
    }
}

public class AdvancedCounter : BaseCounter
{
    protected override void OnThresholdReached(EventArgs e)
    {
        Console.WriteLine("AdvancedCounter: Threshold reached!");
        base.OnThresholdReached(e);
    }
}

// Usage
AdvancedCounter counter = new AdvancedCounter();
counter.ThresholdReached += (sender, e) => Console.WriteLine("Subscriber: Threshold reached!");
counter.Increment(10, 5);
// Output:
// AdvancedCounter: Threshold reached!
// Subscriber: Threshold reached!
```

这个示例演示了派生类如何在仍然通知订阅者的同时覆盖基类的触发事件逻辑。

## 声明事件的最佳实践

- `封装`：使用`protected`访问修饰符来声明触发事件的函数，以确保事件仅在声明类或其派生类中触发。
- `虚方法`：使用`protected virtual`方法允许派生类自定义事件触发逻辑。
- `事件命名`：为事件使用有意义的名称，以便清楚地表明其用途。

通过理解如何在实际场景中声明和使用事件，你可以构建灵活且可维护的应用程序，这些应用程序能够有效响应用户操作和系统变化。

---

