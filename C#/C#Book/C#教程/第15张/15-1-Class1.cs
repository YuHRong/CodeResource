using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第15张
{
 internal class _15_1_Class1
 {
 }
 

interface IControl
 {
  void Pain();
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
}
