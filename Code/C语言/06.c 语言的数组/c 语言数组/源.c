#include<stdio.h>

int main(void) {
	int nums[10] = { 1,10,6,296,177,23,0,100,34,999 };
	int i, num, thisindex = -1;

	printf("Input an integer: ");
	scanf_s("%d", &num);
	for (i = 0; i < 10; i++) {
		if (nums[i] == num) {
			thisindex = i;
			break;
		}
		else if (nums[i] > num) {
			break;
		}
	}
	if (thisindex < 0) {
		printf("%d isn't  in the array.\n", num);
	}
	else
	{
		printf("%d is  in the array, it's index is %d.\n", num, thisindex);
	}

	return 0;
}