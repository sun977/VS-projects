#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <math.h>
#define LEN 50 
int olg(unsigned int e, unsigned  int h);
int just(int a);
int just2(int a, int b);

int main() {
	unsigned int x, y;
	unsigned int d;
	int op;
	while (1) {
		printf("************ 欧几里德算法求d值 ****************\n");
		printf("*             按 1 进入程序                   *\n");
		printf("*             按 2 退出程序                   *\n");
		printf("***********************************************\n");
		scanf("%d", &op);
		switch (op) {
		case 1:
			printf("---------------- 1 进入程序 -------------------\n");
			printf("请输入一个正整数N：");
			scanf("%ld", &x);
			while (just(x) == 1) {
				printf("输入错误！请重新输入！");
				scanf("%ld", &x);
			}
			printf("请输入小于N的正整数A："); //除数应该小于被除数
			scanf("%ld", &y);
			while (just(y) == 1 || just2(x, y) == 1) {
				printf("输入错误！请重新输入！");
				scanf("%ld", &y);
			}
			d = olg(y, x);
			printf("计算求出的d值为：%ld\n", d);
			break;
		case 2:
			printf("---------------- 2 退出程序 -------------------\n");
			exit(0);
		default:
			printf("功能键输入错误！请重新输入！\n");
		}
	}
	return 0;	                     
}

int olg(unsigned int e, unsigned  int h)
{
	int i;
	int k = 1;//计算商的个数
	unsigned int d;
	unsigned int a[50] = { 0 }, r[50] = { 0 }, b[50] = { 0 };//a 商 r 余
	a[0] = h / e;   //取第一个商 
	r[0] = h % e;   //取第一个余数                                                  
	a[1] = e / r[0];//取第二个商 
	r[1] = e % r[0];//取第二个余数 
	if (r[1] != 0) {
		for (i = 2;; i++)
		{
			a[i] = r[i - 2] / r[i - 1]; //当r[i-1]=0时，程序会出错
			r[i] = r[i - 2] % r[i - 1];
			if (r[i] == 0)
				break;
			k++;
		}
		b[0] = a[k];
		b[1] = b[0] * a[k - 1] + 1;
		for (i = 2; i <= k; i++)
		{
			b[i] = a[k - i] * b[i - 1] + b[i - 2];
		}
		if ((k - 1) % 2 != 0)  // 计算商的时候最后一个余数为零的商除去
			d = h - b[k]; //当K-1为奇数时
		if ((k - 1) % 2 == 0)
			d = b[k];  //当k-1为偶数时
		return d;

	}
	else//r[1]=0时
	{
		return h - (a[0] + 1);
	}
}

int just(int a) 
{
	if (a <= 0) {
		return 1;
	}
}

int just2(int a,int b) {
	if (a <= b) {
		return 1;
	}
}




