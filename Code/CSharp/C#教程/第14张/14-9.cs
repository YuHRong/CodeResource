class Customer : People
{
 string s_no;
 int i_day;

 public string No
 {
  get { return s_no; }
  set { if (s_no != value) { s_no = value; } }
 }

 public int Day
 {
  get { return i_day; }
  set { if (i_day != value) { i_day = value; } }
 }

 public override string Name
 {
  get { return base.Name; }
 }

 public override sex Sex
 {
  get { return base.Sex; }
 }

 public override string Card
 {
  get { return s_card; }
  set { s_card = value; }
 }
}