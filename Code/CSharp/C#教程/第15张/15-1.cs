using System;

interface IControl
{
 void Paint();
}

interface ITestBox : IControl
{
 void SetText(string text);
}

interface IListBox : IControl
{
 void SetItems(string[] items);
}

interface IComboBox : ITestBox, IListBox
{

}