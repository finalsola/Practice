#include <stdio.h>
int main()
{
	int endtest, countstart, countend,countget;
	countstart = 0;
	countend = 9;
	countget = 0;
	printf("    %x", &countstart);
	printf("    %x", &countend);
	printf("    %x", &countget);
	int arg[9] = { 6,3,1,7,5,8,9,2,4 };
	int arg1[101];
	int argget[9];
	for (size_t i = 0; i < 9; i++)
	{
		arg1[i] = arg[i];
	}
	while (1)
	{
		argget[countget] = arg1[countstart];
		arg1[countstart] = NULL;
		if (countget == 5)
			countget=5;
		countget++;
		countstart++;
		if (countend == countstart)
			break;
		else {
			arg1[countend] = arg1[countstart];
			arg1[countstart] = NULL;
			countend++;
			countstart++;
		}

	}
	for (size_t i = 0; i < 9; i++)
	{
		printf_s("%d ", argget[i]);
	}
	//printf("    %x    ", arg+11);
	//printf("    %x", &countget);
	
	getchar();
	return 0;
}