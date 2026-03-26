# 检查 C#中的事件

## 目录在这里

- [检查 C#中的事件](#检查-c中的事件)
  - [目录在这里](#目录在这里)
  - [理解事件](#理解事件)
    - [一个简单按钮示例](#一个简单按钮示例)
  - [委托：事件的基础](#委托事件的基础)
    - [示例：在事件后面委托](#示例在事件后面委托)
  - [事件设计](#事件设计)

事件使应用程序的不同部分能够有效通信。  
当用户选择按钮或菜单项时，事件确保更新库存或应用折扣等任务顺利进行。  
使用事件不仅使您的代码更有条理，而且当添加新功能时，也使您的应用程序更容易适应和扩展。

## 理解事件

事件让程序的一部分在重要事情发生时通知其他部分。发出事件的这部分称为`发布者(publisher)`，而响应事件的这部分称为`订阅者(subscribers)`。

例如，事件常用于具有图形用户界面的程序中，以响应按钮或菜单选择等操作。

- 发布者会在特定操作发生时（例如按钮的选择）触发事件。
- - 订阅者通过执行各自的事件处理方法来处理事件。

这种模式确保发布者和订阅者保持松散耦合，从而提供更高的灵活性和可维护性。

事件的关键属性:
- 发布者决定何时触发事件，订阅者决定如何响应。
- 一个事件可以拥有多个订阅者，一个订阅者可以处理多个事件。
- 没有订阅者的事件永远不会被触发。

### 一个简单按钮示例

```c#
public class Button
{
    public event EventHandler? Selected; // Nullable to indicate no subscribers initially

    public void OnClick()
    {
        // If subscribers exist, ?.Invoke syntax triggers an event
        Selected?.Invoke(this, EventArgs.Empty);
    }
}

// Subscribing to the event
Button button = new Button();
button.Selected += (sender, e) => Console.WriteLine("Button Selected!");

// Triggering the event
button.OnClick(); // Output: "Button Selected!"
```

在这个示例中，`Selected`事件被声明为`EventHandler?`，使用可空引用类型，明确表示该事件可能没有任何订阅者，确保代码能够优雅地处理这种情况。
`?.Invoke`语法进一步确保只有当存在订阅者时才会触发事件，从而防止潜在的`NullReferenceException`错误。

Lambda 表达式（`=>`）用于订阅中内联定义事件处理程序。

## 委托：事件的基础

委托是类型安全的函数指针，允许将方法作为参数传递并动态调用。  
C#中的事件建立在委托的基础之上，委托定义了事件处理程序的方法签名。

委托与事件的关系：:
- 委托定义了事件处理程序必须匹配的方法签名。
- 事件使用委托在重要事件发生时通知订阅者。

### 示例：在事件后面委托

```c#
// Define a delegate
public delegate void ButtonClickedHandler(object sender, EventArgs e);

// Use the delegate in an event
public class Button
{
    public event ButtonClickedHandler Clicked;

    public void OnClick()
    {
        Clicked?.Invoke(this, EventArgs.Empty); 
    }
}
```

*注*委托提供了事件依赖的类型安全机制来通知订阅者。

## 事件设计

C#中事件的设计旨在促进组件之间的最小耦合，同时确保灵活性和易用性。

事件设计的目标:
- `最小耦合`：事件使得事件源和事件接收器之间能够交互，而无需紧密依赖。  
使用事件实现最小耦合，在由不同团队开发或独立更新的组件中尤其有用。
- `订阅和退订的便捷性`：订阅（`+=`）和退订（`-=`）的语法非常简单。
- `支持多个订阅者`：事件可以有零个、一个或多个订阅者，使其适用于各种场景。
- 
事件通常用于需要跨组件传递用户操作或系统变化的场景。  
例如，一个`Closing`事件可能允许订阅者取消关闭操作或修改其行为。

