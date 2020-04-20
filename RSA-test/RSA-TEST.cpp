#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <math.h>
int prime(unsigned long long int a); //素数判断
int prime2(unsigned long long int* a);
int gcd(unsigned long long int a, unsigned long long int b);//欧几里得
int rsa(unsigned long long int a, unsigned long long int b, unsigned long long int c); //rsa(e,m,n) rsa(d,c,n)
int qiud(unsigned long long int a, unsigned long long int b);//求d
//unsigned long long int a 解决数值过大问题 
int olg(unsigned long long int e, unsigned long long int h); //辗转相除法求d函数

int main() {
	int p, q, e, m, a, h, c, n, d; //h:Eular函数
	do {
		printf("\n");
		printf("***************************************************\n");
		printf("****************RSA实验****************************\n");
		printf("*               1:密码加密                        *\n");
		printf("*               2:密码解密                        *\n");
		printf("*               3:退出                            *\n");
		printf("***************************************************\n");
		printf("请输入功能键(1~3)：");
		scanf("%d", &a);
		switch (a) {
		case 1:
			printf("*************RSA密码加密***************************\n");
			printf("请输入素数p：");
			scanf("%ld", &p);
			while (prime(p) == 1) {//此处用while代替if，if重新输入会导致程序中断      if和while的区别？ 
				printf("您输入的数不是素数!请重新输入p：");
				scanf("%ld", &p);
			}

			printf("请输入素数q：");
			scanf("%ld", &q);
			while (prime(q) == 1) {//此处用while代替if，if重新输入会导致程序中断
				printf("您输入的数不是素数!请重新输入q：");
				scanf("%ld", &q);
			}

			n = p * q; //计算n
			h = (p - 1) * (q - 1); // 计算Eular函数值φ(n)

			printf("请输入e：");
			scanf("%ld", &e);
			while (e<1 || e>h || gcd(e, h) != 1) {  //此处用while代替if，if重新输入会导致程序中断 
				printf("e值输入错误，请重新输入：");
				scanf("%ld", &e);
			}

			d = qiud(e, h); // 计算d的值
			printf("==================================================\n");
			printf("计算得n为：%ld\n", n);
			printf("计算得φ(n)为：%ld\n", h);
			printf("计算得e为：%ld\n", e);
			printf("计算得d为：%ld\n", d);
			printf("==================================================\n");
			printf("请输入要加密的明文（一个整数）：");
			scanf("%ld", &m);
			//判断是否是一个整数
			c = rsa(e, m, n);
			printf("加密后的密文C为：%ld", c);
			break;
		case 2:
			printf("*************RSA密码解密***************************\n");
			printf("请输入素数p：");
			scanf("%ld", &p);
			while (prime(p) == 1) {
				printf("您输入的数不是素数!请重新输入p：");
				scanf("%ld", &p);
			}

			printf("请输入素数q：");
			scanf("%ld", &q);
			while (prime(q) == 1) {
				printf("您输入的数不是素数!请重新输入q：");
				scanf("%ld", &q);
			}

			n = p * q; //计算n
			h = (p - 1) * (q - 1); // 计算Eular函数值φ(n)

			printf("请输入e：");
			scanf("%ld", &e);
			while (e<1 || e>h || (gcd(e, h) != 1)) {
				printf("e值输入错误，请重新输入：");
				scanf("%ld", &e);
			}

			//d = qiud(e, h); // 计算d的值
			d = olg(e, h); //这里改用欧几里得算法求d
			printf("==================================================\n");
			printf("计算得n为：%ld\n", n);
			printf("计算得φ(n)为：%ld\n", h);
			printf("计算得e为：%ld\n", e);
			printf("计算得d为：%ld\n", d);
			printf("==================================================\n");
			printf("请输入要解密的密文（一个整数）：");
			scanf("%d", &c);
			//判断是否是一个整数
			m = rsa(d, c, n);
			printf("解密后的明文m为：%ld", m);
			break;
		case 3:
			exit(0);
		default:
			printf("功能键输入错误!\n");
		}
	} while (a != 0);
}

//10.8改
int prime(unsigned long long int a) {
	unsigned long long int i = 2;
	if (a == 1) {
		return 1;
	}
	else {
		for (i = 2; i < sqrt(a); i++) { //改用平方根函数做 
			if (a % i == 0)
				return 1;  // 整除，即不是素数，返回1
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

int gcd(unsigned long long int a, unsigned long long int b) {   //递归的理解 
	return b != 0 ? gcd(b, a % b) : a;
}

//10.8改 欧几里得算法求d
int olg(unsigned long long int e, unsigned long long int h)    //h=e*a[0]+r[0]  辗转相除法
{
	int i;
	int k = 1;//计算商的个数
	unsigned long long int d;
	unsigned long long int a[50] = { 0 }, r[50] = { 0 }, b[50] = { 0 };//a 商 r 余
	a[0] = h / e;   //取第一个商 
	r[0] = h % e;   //取第一个余数                                                  
	a[1] = e / r[0];//取第二个商 
	r[1] = e % r[0];//取第二个余数 
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
	if ((k - 1) % 2 != 0)  // 计算商的时候最后一个余数为零的商除去
		d = h - b[k]; //当K-1为奇数时
	if ((k - 1) % 2 == 0)
		d = b[k];  //当k-1为偶数时
	return d;
}


int qiud(unsigned long long int a, unsigned long long int b) { //利用i循环自增满足 ab mod φ(n) = 1 的条件得到d   改用辗转相除法 
	unsigned long long int i = 1;
	for (; ((a * i) % b) != 1;) {  //  ab mod φ(n) = 1   
		i++;
	}
	return i;
}

int rsa(unsigned long long int a, unsigned long long int b, unsigned long long int c) { //溢出问题 
	unsigned long long int i = 1;
	while (a != 0) {
		i = i * b;
		i = i % c;
		a--;  //*一次 %一次 
	}
	return i;
}
