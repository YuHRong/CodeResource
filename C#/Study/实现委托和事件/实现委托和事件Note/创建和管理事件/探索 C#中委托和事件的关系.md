# 探索 C#中委托和事件的关系

## 目录在这里

- [探索 C#中委托和事件的关系](#探索-c中委托和事件的关系)
  - [目录在这里](#目录在这里)
  - [高级委托-事件关系](#高级委托-事件关系)
    - [使用`EventHandler<T>`与自定义事件数据](#使用eventhandlert与自定义事件数据)
      - [使用`EventHandler<T>`与自定义事件数据示例](#使用eventhandlert与自定义事件数据示例)
    - [多播委托](#多播委托)
      - [示例：使用多播委托](#示例使用多播委托)
    - [管理事件的最佳实践](#管理事件的最佳实践)
      - [示例：取消订阅以避免内存泄漏](#示例取消订阅以避免内存泄漏)
  - [总结](#总结)

C#中的事件建立在委托的基础之上，委托定义了事件处理程序的方法签名。

虽然之前的单元介绍了事件和委托的基础知识，但本单元将重点介绍高级概念，包括`EventHandler<T>`的使用、多播委托以及管理复杂事件驱动系统的最佳实践。

## 高级委托-事件关系

委托是类型安全的函数指针，允许将方法作为参数传递并动态调用。  
换句话说，委托就像一个“合同”，它指定了方法的签名，允许你像传递变量一样传递方法。  
事件封装了委托，提供了一种结构化的方式来通知订阅者在重要事件发生时。

本张探讨了如何使用内置委托如`EventHandler`和`EventHandler<T>`来简化事件处理。

### 使用`EventHandler<T>`与自定义事件数据

`EventHandler<T>`委托是一个内置委托，当需要将自定义事件数据传递给订阅者时，它可以简化事件处理。

它允许你定义包含有关事件额外信息的事件处理程序。

#### 使用`EventHandler<T>`与自定义事件数据示例

```C#
public class OrderEventArgs : EventArgs
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
}

public class OrderProcessor
{
    // Using EventHandler<T> to define an event with custom event data
    // Nullable to indicate no subscribers initially
    public event EventHandler<OrderEventArgs>? OrderProcessed; 

    protected virtual void OnOrderProcessed(OrderEventArgs e)
    {
        OrderProcessed?.Invoke(this, e);
    }

    public void ProcessOrder(int orderId)
    {
        Console.WriteLine($"Processing order {orderId}...");
        OnOrderProcessed(new OrderEventArgs
        {
            OrderId = orderId,
            OrderDate = DateTime.Now
        });
    }
}

// Subscribing to the event
public class Program
{
    public static void Main()
    {
        OrderProcessor processor = new OrderProcessor();
        processor.OrderProcessed += (sender, e) =>
        {
            Console.WriteLine($"Order {e.OrderId} processed on {e.OrderDate}");
        };

        processor.ProcessOrder(123); // Output: "Processing order 123..."
                                     // Output: "Order 123 processed on [current date and time]"
    }
}
```

在这个示例中，`OrderProcessed`事件被声明为`EventHandler<OrderEventArgs>?`，使用了可空引用类型。

可空引用类型明确表示事件可能没有任何订阅者，确保代码能够优雅地处理此类场景。`?.Invoke`语法确保只有存在订阅者时才会触发事件，防止潜在的`NullReferenceException`错误。

Lambda 表达式，如在`OrderProcessed`事件的订阅中所示，是内联简洁定义事件处理程序的常用方法。

### 多播委托

多播委托允许单个事件被多个方法调用。
当多个订阅者需要响应同一事件时，多播委托很有用，例如通知不同的系统或组件。

#### 示例：使用多播委托

```c#
public class NotificationService
{
    public event EventHandler? NotificationSent; // Nullable to indicate no subscribers initially

    public void SendNotification()
    {
        NotificationSent?.Invoke(this, EventArgs.Empty);
    }
}

public class Program
{
    public static void Main()
    {
        NotificationService service = new NotificationService();

        // Subscribing multiple methods to the event
        service.NotificationSent += (sender, e) => Console.WriteLine("Email notification sent!");
        service.NotificationSent += (sender, e) => Console.WriteLine("SMS notification sent!");

        service.SendNotification();
        // Output:
        // "Email notification sent!"
        // "SMS notification sent!"
    }
}
```

在这个示例中，使用 lambda 表达式（`=>`）来定义`NotificationSent`事件的处理器。

Lambda 表达式在委托中经常遇到，提供了一种简洁且易读的方式来定义事件处理程序，尤其是在每个处理程序的逻辑较为简单时。

### 管理事件的最佳实践

有效管理事件对于构建健壮且可维护的应用程序至关重要。  
这里有一些最佳实践建议：
- `避免内存泄漏：`当事件不再需要时，始终取消订阅事件，特别是如果事件的发布者比订阅者有更长的生命周期。
- `使用弱引用：`在订阅者的生命周期比发布者短的情况下，考虑使用弱引用或`WeakEventManager`来避免内存泄漏。
- `确保线程安全：`如果事件在一个多线程环境中被触发，请使用锁或线程安全的集合等同步机制来确保线程安全。

#### 示例：取消订阅以避免内存泄漏

```c#
public class Subscriber : IDisposable
{
    private readonly NotificationService _service;

    public Subscriber(NotificationService service)
    {
        _service = service;
        _service.NotificationSent += (sender, e) => Console.WriteLine("Notification received!");
    }

    public void Dispose()
    {
        _service.NotificationSent -= (sender, e) => Console.WriteLine("Notification received!");
    }
}
```

## 总结

使用- 
`EventHandler<T>`与自定义事件数据。
- 使用 Lambda 表达式简化事件处理。
- 使用多播委托通知多个订阅者。
- 管理事件订阅的最佳实践，避免内存泄漏，并确保线程安全。
- 
通过这些高级技术，您可以构建健壮、可维护和可扩展的事件驱动应用程序。

---

