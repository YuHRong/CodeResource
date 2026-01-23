// 将此代码翻译成中文
/* 
This C# console application is designed to:
此C#控制台应用程序只在：
- Use arrays to store student names and assignment scores.
- 使用数组存储学生名字和作业成绩。
- Use a `foreach` statement to iterate through the student names as an outer program loop.
- 使用'foreach'语句作为外部循环迭代学生姓名。
- Use an `if` statement within the outer loop to identify the current student name and access that student's assignment scores.
- 在外部循环使用 if 语句来标识当前学生姓名并访问该学生的作业成绩。
- Use a `foreach` statement within the outer loop to iterate though the assignment scores array and sum the values.
- 在外循环中使用 'foreach'语句迭代赋值分数数组并求和值。
- Use an algorithm within the outer loop to calculate the average exam score for each student.
- 使用外循环中的算法计算每个学生的考试平均成绩。
- Use an `if-elseif-else` construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
- 在外循环中使用`if-elseif-else构造来评估考试成绩，并自动分配一个字母等级。
- Integrate extra credit scores when calculating the student's final score and letter grade as follows:
- 在计算学生的最终成绩和字母等级时，将额外学分总和如下：
 - detects extra credit assignments based on the number of elements in the student's scores array.
  - 根据学生分数数组中的元素数量检测额外的学分分配。
 - divides the values of extra credit assignments by 10 before adding extra credit scores to the sum of exam scores.
  - 在将额外学分加到考试成绩之和之前，将额外的值除10。
- use the following report format to report student grades: 
- 使用下面格式报告学生成绩。

Student Exam Score Overall Grade Extra Credit
学生考试成绩总成绩额外学分

Sophia 92.2 95.88 A 92 (3.68 pts)
索菲亚92.2 95.88 A 92（3.68分）

*/
// int examAssignments = 5;
int 考试项目 = 5;

// string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };
string[] 学生姓名 = new string[] { "索菲亚", "安德鲁", "艾玛", "洛根" }

// int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] 索菲亚得分 = new int[] { 90, 86, 87, 98, 100, 94, 90 };
// int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };

int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// display the header row for scores/grades
Console.Clear();
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

/*
The outer foreach loop is used to:
- iterate through student names 
- assign a student's grades to the studentScores array
- calculate exam and extra credit sums (inner foreach loop)
- calculate numeric and letter grade
- write the score report information
*/
foreach (string name in studentNames)
{
 string currentStudent = name;

 if (currentStudent == "Sophia")
 studentScores = sophiaScores;

 else if (currentStudent == "Andrew")
 studentScores = andrewScores;

 else if (currentStudent == "Emma")
 studentScores = emmaScores;

 else if (currentStudent == "Logan")
 studentScores = loganScores;

 int gradedAssignments = 0;
 int gradedExtraCreditAssignments = 0;

 int sumExamScores = 0;
 int sumExtraCreditScores = 0;

 decimal currentStudentGrade = 0;
 decimal currentStudentExamScore = 0;
 decimal currentStudentExtraCreditScore = 0;

 /* 
 the inner foreach loop: 
 - sums the exam and extra credit scores
 - counts the extra credit assignments
 */
 foreach (int score in studentScores)
 {
 gradedAssignments += 1;

 if (gradedAssignments <= examAssignments)
 {
 sumExamScores = sumExamScores + score;
 }

 else
 {
 gradedExtraCreditAssignments += 1;
 sumExtraCreditScores += score;
 }
 }

 currentStudentExamScore = (decimal)(sumExamScores) / examAssignments;
 currentStudentExtraCreditScore = (decimal)(sumExtraCreditScores) / gradedExtraCreditAssignments;

 currentStudentGrade = (decimal)((decimal)sumExamScores + ((decimal)sumExtraCreditScores / 10)) / examAssignments;

 if (currentStudentGrade >= 97)
 currentStudentLetterGrade = "A+";

 else if (currentStudentGrade >= 93)
 currentStudentLetterGrade = "A";

 else if (currentStudentGrade >= 90)
 currentStudentLetterGrade = "A-";

 else if (currentStudentGrade >= 87)
 currentStudentLetterGrade = "B+";

 else if (currentStudentGrade >= 83)
 currentStudentLetterGrade = "B";

 else if (currentStudentGrade >= 80)
 currentStudentLetterGrade = "B-";

 else if (currentStudentGrade >= 77)
 currentStudentLetterGrade = "C+";

 else if (currentStudentGrade >= 73)
 currentStudentLetterGrade = "C";

 else if (currentStudentGrade >= 70)
 currentStudentLetterGrade = "C-";

 else if (currentStudentGrade >= 67)
 currentStudentLetterGrade = "D+";

 else if (currentStudentGrade >= 63)
 currentStudentLetterGrade = "D";

 else if (currentStudentGrade >= 60)
 currentStudentLetterGrade = "D-";

 else
 currentStudentLetterGrade = "F";


 // Student Exam Score Overall Grade Extra Credit
 // Sophia 92.2 95.88 A 92 (3.68 pts)

 Console.WriteLine($"{currentStudent}\t\t{currentStudentExamScore}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t{currentStudentExtraCreditScore} ({(((decimal)sumExtraCreditScores / 10) / examAssignments)} pts)");
}

// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();