using System;

public class  Customer
{
 public enum sex
 {
  man,
  woman
 }

 public string s_name;
 public string Name
 {
  get
  {
   return s_name;
  }
 }

 private sex m_sex;
 public sex Sex
 {
  get
  {
   return m_sex;
  }
 }

 private string s_no;
 public string No
 {
  get
  {
   return s_no;
  }
  set
  {
   if(s_no != Value)
   {
    s_no = Value;
   }
  }
 }

 private int i_day;
 public int day
 {
  get
  {
   return i_day;
  }
  set
  {
   if(i_day != value)
   {
    i_day = value;
   }
  }
 }

 public void Custtomer(string name, sex sex, string no, int day)
 {
  s_name = name;
  m_sex = sex;
  s_no = no;
  i_day = day;
 }
}