
namespace C__继承和派生类型;

//WorkItem隐式继承自Object类。
public class WorkItem
{
 // Static field currentID stores the job ID of the last WorkItem that.静态字段 currentID 存储最后一项工作字段的ID
 // has been created.已创建
 private static int currentID;

 //Properties.属性
 protected int ID { get; set; }
 protected string Title { get; set; }
 protected string Description { get; set; }
 protected TimeSpan jobLength { get; set; }

 // Default constructor. If a derived class does not invoke a base-。默认构造函数，如果派生类不调用基类-
 // class constructor explicitly, the default constructor is called，显示调用构造函数，默认函数被调用
 // implicitly.
 public WorkItem()
 {
  ID = 0;
  Title = "Default title";
  Description = "Default description.";
  jobLength = new TimeSpan();
 }

 // Instance constructor that has three parameters.具有三个参数的实力构造函数。
 public WorkItem(string title, string desc, TimeSpan joblen)
 {
  ID = GetNextID();
  Title = title;
  Description = desc;
  jobLength = joblen;
 }

 // Static constructor to initialize the static member, currentID.用于初始化静态成员 currentID的构造函数。
 // this constructor is called one time, automatically, before any instance.构造函数在任何实例之前被调用一次
 // of WorkItem or ChangeRequest is created, or currentID is referenced.创建工作项并变更请求，或引用当前 ID。
 static WorkItem() => currentID = 0;

 // currentID is a static field. It is incremented each time a new
 // instance of WorkItem is created.
 protected int GetNextID() => ++currentID;

 // Method Update enables you to update the title and job length of an
 // existing WorkItem object.
 public void Update(string title, TimeSpan joblen)
 {
  this.Title = title;
  this.jobLength = joblen;
 }

 // Virtual method override of the ToString method that is inherited from System.Object.
 //从System继承的ToString方法的虚拟方法重写。对象。
 public override string ToString() =>
         $"{this.ID} - {this.Title}";
}
