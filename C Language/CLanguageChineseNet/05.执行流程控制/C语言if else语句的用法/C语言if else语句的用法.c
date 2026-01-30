#include<stdio.h>

/*int main() {
	int h;

	printf("请输入你的年龄");
	scanf_s("%d", &h);

	if (h >= 18) {
		printf("你已经成年了");
	}
	else
	{
		printf("你还未成年\n");
	}

	return 0;
}

int main() {
	int h;

	printf("请输入你的年龄");
scanf_s("%d", &h);

if (h >= 18) {
	printf("你已经成年了\n");
}

return 0;
}

int main() {
	int score;
	printf("请输入学生成绩（1-100）");
	scanf_s("%d", &score);

	if (score >= 90 && score <= 100) {
		printf("优秀\n");
	}
	else if (score >=80 && score <90)
	{
		printf("良好\n");
	}
	else if (score >= 70 && score <80)
	{
		printf("中等\n");
	}
	else if (score >= 60 && score < 70)
	{
		printf("及格\n");
	}
	else if (score >= 0 && score < 60)
	{
		printf("不及格\n");
	}
	else
	{
		printf("输入的成绩无效\n");
	}

	return 0;
}*/


int main() {
	float grade, attendance;

	printf("请输入学生成绩（0-100）");
	scanf_s("%f", &grade);

	printf("请输入学生出勤率");
	scanf_s("%f", &attendance);

	if (grade >= 85) {
		if (attendance >= 95) {
			printf("恭喜，你获得了一等奖学金。\n");
		}
		else
		{
			printf("很遗憾，虽然你的成绩达标，但出勤率不足。你获得了二等奖学金。\n");
		}
	}
	else
	{
		if (attendance >= 95) {
			printf("虽然你的成绩未达到一等奖学金标准，但由于出色的出勤率，你获得了三等奖学金。\n");
		}
		else
		{
			printf("很抱歉，你没有获得奖学金的资格。继续努力！\n");
		}
	}

	return 0;
}