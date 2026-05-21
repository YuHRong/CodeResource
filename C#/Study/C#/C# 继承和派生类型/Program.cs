// Create an instance of WorkItem by using the constructor in the

using C__继承和派生类型;

WorkItem item = new WorkItem("Fix Bugs",
            "Fix all bugs in my code branch",
            new TimeSpan(3, 4, 0, 0));

// Create an instance of ChangeRequest by using the constructor in
// the derived class that takes four arguments.
ChangeRequest change = new("Change Base Class Design",
                  "Add members to the class",
                                    new TimeSpan(4, 0, 0),
                                    1);

// Use the ToString method defined in WorkItem.
Console.WriteLine(item.ToString());

// Use the inherited Update method to change the title of the
// ChangeRequest object.
change.Update("Change the Design of the Base Class",
    new TimeSpan(4, 0, 0));

// ChangeRequest inherits WorkItem's override of ToString.
Console.WriteLine(change.ToString());

/* 输出
    1 - Fix Bugs
        2 - Change the Design of the Base Class
*/