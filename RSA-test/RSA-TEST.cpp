#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <math.h>
int prime(unsigned long long int a); //�����ж�
int prime2(unsigned long long int* a);
int gcd(unsigned long long int a, unsigned long long int b);//ŷ�����
int rsa(unsigned long long int a, unsigned long long int b, unsigned long long int c); //rsa(e,m,n) rsa(d,c,n)
int qiud(unsigned long long int a, unsigned long long int b);//��d
//unsigned long long int a �����ֵ�������� 
int olg(unsigned long long int e, unsigned long long int h); //շת�������d����

int main() {
	int p, q, e, m, a, h, c, n, d; //h:Eular����
	do {
		printf("\n");
		printf("***************************************************\n");
		printf("****************RSAʵ��****************************\n");
		printf("*               1:�������                        *\n");
		printf("*               2:�������                        *\n");
		printf("*               3:�˳�                            *\n");
		printf("***************************************************\n");
		printf("�����빦�ܼ�(1~3)��");
		scanf("%d", &a);
		switch (a) {
		case 1:
			printf("*************RSA�������***************************\n");
			printf("����������p��");
			scanf("%ld", &p);
			while (prime(p) == 1) {//�˴���while����if��if��������ᵼ�³����ж�      if��while������ 
				printf("�����������������!����������p��");
				scanf("%ld", &p);
			}

			printf("����������q��");
			scanf("%ld", &q);
			while (prime(q) == 1) {//�˴���while����if��if��������ᵼ�³����ж�
				printf("�����������������!����������q��");
				scanf("%ld", &q);
			}

			n = p * q; //����n
			h = (p - 1) * (q - 1); // ����Eular����ֵ��(n)

			printf("������e��");
			scanf("%ld", &e);
			while (e<1 || e>h || gcd(e, h) != 1) {  //�˴���while����if��if��������ᵼ�³����ж� 
				printf("eֵ����������������룺");
				scanf("%ld", &e);
			}

			d = qiud(e, h); // ����d��ֵ
			printf("==================================================\n");
			printf("�����nΪ��%ld\n", n);
			printf("����æ�(n)Ϊ��%ld\n", h);
			printf("�����eΪ��%ld\n", e);
			printf("�����dΪ��%ld\n", d);
			printf("==================================================\n");
			printf("������Ҫ���ܵ����ģ�һ����������");
			scanf("%ld", &m);
			//�ж��Ƿ���һ������
			c = rsa(e, m, n);
			printf("���ܺ������CΪ��%ld", c);
			break;
		case 2:
			printf("*************RSA�������***************************\n");
			printf("����������p��");
			scanf("%ld", &p);
			while (prime(p) == 1) {
				printf("�����������������!����������p��");
				scanf("%ld", &p);
			}

			printf("����������q��");
			scanf("%ld", &q);
			while (prime(q) == 1) {
				printf("�����������������!����������q��");
				scanf("%ld", &q);
			}

			n = p * q; //����n
			h = (p - 1) * (q - 1); // ����Eular����ֵ��(n)

			printf("������e��");
			scanf("%ld", &e);
			while (e<1 || e>h || (gcd(e, h) != 1)) {
				printf("eֵ����������������룺");
				scanf("%ld", &e);
			}

			//d = qiud(e, h); // ����d��ֵ
			d = olg(e, h); //�������ŷ������㷨��d
			printf("==================================================\n");
			printf("�����nΪ��%ld\n", n);
			printf("����æ�(n)Ϊ��%ld\n", h);
			printf("�����eΪ��%ld\n", e);
			printf("�����dΪ��%ld\n", d);
			printf("==================================================\n");
			printf("������Ҫ���ܵ����ģ�һ����������");
			scanf("%d", &c);
			//�ж��Ƿ���һ������
			m = rsa(d, c, n);
			printf("���ܺ������mΪ��%ld", m);
			break;
		case 3:
			exit(0);
		default:
			printf("���ܼ��������!\n");
		}
	} while (a != 0);
}

//10.8��
int prime(unsigned long long int a) {
	unsigned long long int i = 2;
	if (a == 1) {
		return 1;
	}
	else {
		for (i = 2; i < sqrt(a); i++) { //����ƽ���������� 
			if (a % i == 0)
				return 1;  // ����������������������1
		}
	}
}

int prime2(unsigned long long int* a) {
	unsigned long long int i = 2;
	if (*a == 1) {
		return 1;
	}
	else {
		for (i = 2; i < sqrt(*a); i++) {
			if (*a % i == 0)
				return 1;
		}
	}
}

int gcd(unsigned long long int a, unsigned long long int b) {   //�ݹ����� 
	return b != 0 ? gcd(b, a % b) : a;
}

//10.8�� ŷ������㷨��d
int olg(unsigned long long int e, unsigned long long int h)    //h=e*a[0]+r[0]  շת�����
{
	int i;
	int k = 1;//�����̵ĸ���
	unsigned long long int d;
	unsigned long long int a[50] = { 0 }, r[50] = { 0 }, b[50] = { 0 };//a �� r ��
	a[0] = h / e;   //ȡ��һ���� 
	r[0] = h % e;   //ȡ��һ������                                                  
	a[1] = e / r[0];//ȡ�ڶ����� 
	r[1] = e % r[0];//ȡ�ڶ������� 
	for (i = 2;; i++)
	{
		a[i] = r[i - 2] / r[i - 1];
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


int qiud(unsigned long long int a, unsigned long long int b) { //����iѭ���������� ab mod ��(n) = 1 �������õ�d   ����շת����� 
	unsigned long long int i = 1;
	for (; ((a * i) % b) != 1;) {  //  ab mod ��(n) = 1   
		i++;
	}
	return i;
}

int rsa(unsigned long long int a, unsigned long long int b, unsigned long long int c) { //������� 
	unsigned long long int i = 1;
	while (a != 0) {
		i = i * b;
		i = i % c;
		a--;  //*һ�� %һ�� 
	}
	return i;
}
