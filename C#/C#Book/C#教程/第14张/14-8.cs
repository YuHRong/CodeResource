using System;

public enum sex
{
 woman,
 man,
};

abstract public class People
{
 private string s_name;

 public virtual string Name
 {
  get { return s_name; }
 }

 private sex m_sex;

 public virtual sex Sex
 {
  get { return m_sex; }
 }

 protected string s_card;

 public abstract string Card
 {
  get;
  set;
 }
}