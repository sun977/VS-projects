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
		printf("************ ŷ������㷨��dֵ ****************\n");
		printf("*             �� 1 �������                   *\n");
		printf("*             �� 2 �˳�����                   *\n");
		printf("***********************************************\n");
		scanf("%d", &op);
		switch (op) {
		case 1:
			printf("---------------- 1 ������� -------------------\n");
			printf("������һ��������N��");
			scanf("%ld", &x);
			while (just(x) == 1) {
				printf("����������������룡");
				scanf("%ld", &x);
			}
			printf("������С��N��������A��"); //����Ӧ��С�ڱ�����
			scanf("%ld", &y);
			while (just(y) == 1 || just2(x, y) == 1) {
				printf("����������������룡");
				scanf("%ld", &y);
			}
			d = olg(y, x);
			printf("���������dֵΪ��%ld\n", d);
			break;
		case 2:
			printf("---------------- 2 �˳����� -------------------\n");
			exit(0);
		default:
			printf("���ܼ�����������������룡\n");
		}
	}
	return 0;	                     
}

int olg(unsigned int e, unsigned  int h)
{
	int i;
	int k = 1;//�����̵ĸ���
	unsigned int d;
	unsigned int a[50] = { 0 }, r[50] = { 0 }, b[50] = { 0 };//a �� r ��
	a[0] = h / e;   //ȡ��һ���� 
	r[0] = h % e;   //ȡ��һ������                                                  
	a[1] = e / r[0];//ȡ�ڶ����� 
	r[1] = e % r[0];//ȡ�ڶ������� 
	if (r[1] != 0) {
		for (i = 2;; i++)
		{
			a[i] = r[i - 2] / r[i - 1]; //��r[i-1]=0ʱ����������
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
		if ((k - 1) % 2 != 0)  // �����̵�ʱ�����һ������Ϊ����̳�ȥ
			d = h - b[k]; //��K-1Ϊ����ʱ
		if ((k - 1) % 2 == 0)
			d = b[k];  //��k-1Ϊż��ʱ
		return d;

	}
	else//r[1]=0ʱ
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




