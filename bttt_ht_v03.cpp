#include "stdio.h"
#include "conio.h"
#include "stdlib.h"

typedef struct tdata{
	int sign;    
	float num;
	char ope;
} ; 

typedef struct node{
	tdata info;
	node *next;
}*stack;

tdata Peek(stack s,int &err)
{
	tdata value;
	if(s==NULL){
		err=0;
		return value;
	}
	value=s->info;
	err=1;
	return(value);
}

void capphat(stack &temp,tdata v){
	temp=(node*)malloc(sizeof(node));
	temp->info=v;
	temp->next=NULL;	
}

void Push(stack &s,tdata v)
{
	stack temp,temp1;
	capphat(temp,v);
	if(s==NULL) s=temp;
	else {
		temp->next=s;
		s=temp;
	}
}

void InsertAtLast(stack &s,tdata v)
{
	stack temp,temp1;
	temp1=s;
	capphat(temp,v);
	if(s==NULL) s=temp;
	else {
		while (temp1->next != NULL) temp1 = temp1->next;
		temp1->next=temp;
	}
}

tdata Pop(stack &s,int &err)
{
	tdata value;
	stack temp;
	temp=s;
	if(temp==NULL){
		err=0;
		return value;
	}
	s=s->next;
	value=temp->info;
	free(temp);
	err=1;
	return(value);
}

void _Write(tdata info){
	printf("sign=%d\tnum=%f\tope=%c\n",info.sign,info.num,info.ope);	
}

void printfstack(stack s)
{
	while(s!=NULL) {
		_Write(s->info);
		s=s->next;
	}
}

void _Write_BT(tdata info){
	if (info.sign==0) printf("%.0f  ",info.num); 
	else printf("%c  ",info.ope);
}
	
void printfstack_BT(stack s)
{
	while(s!=NULL) {
		_Write_BT(s->info);
		s=s->next;
	}
}
void readfile(stack &s){
	FILE *f;
	char ch;
	tdata temp;
	int so=0, flag_so = 0;
	f=fopen("bttt.in.txt","r");
	while(!feof(f)){
		fscanf(f,"%c",&ch);
		if (!feof(f))
		{
		
			printf("%c",ch);
			
			switch(ch){
				case '0':
				case '1':
				case '2':
				case '3':
				case '4':
				case '5':
				case '6':
				case '7':
				case '8':
				case '9':
					so = so*10+(int)ch-(int)'0';
					flag_so = 1;
					break;
					
				case '+':
				case '-':
					if (flag_so ==1)
					{
						temp.sign=0;
						temp.num=so;
						temp.ope=' ';
						InsertAtLast(s,temp);
						so = 0;
						flag_so=0;
					}
					
					if (s==NULL)
					{
						temp.sign=0;
						temp.num=0;
						temp.ope=' ';
						InsertAtLast(s,temp);
					}
					
					temp.sign=2;
					temp.num=0;
					temp.ope=ch;
					InsertAtLast(s,temp);
					break;
				case '*':
				case '/':
					if (flag_so ==1)
					{
						temp.sign=0;
						temp.num=so;
						temp.ope=' ';
						InsertAtLast(s,temp);
						so = 0;
						flag_so=0;
					}
					
					if (s==NULL)
					{
						temp.sign=0;
						temp.num=0;
						temp.ope=' ';
						InsertAtLast(s,temp);
					}
					
					temp.sign=3;
					temp.num=0;
					temp.ope=ch;
					InsertAtLast(s,temp);
					break;
					
				case ')':
				case '(':
					if (flag_so ==1)
					{
						temp.sign=0;
						temp.num=so;
						temp.ope=' ';
						InsertAtLast(s,temp);
						so = 0;
						flag_so=0;
					}
					
					if (s==NULL)
					{
						temp.sign=0;
						temp.num=0;
						temp.ope=' ';
						InsertAtLast(s,temp);
					}
					
					temp.sign=1;
					temp.num=0;
					temp.ope=ch;
					InsertAtLast(s,temp);
					break;
			}
		}
	}
	if (flag_so == 1)
	{
		temp.sign=0;
		temp.num=so;
		temp.ope=' ';
		InsertAtLast(s,temp);
	}
}

void BTTT_BTHT(stack BTTT, stack &BTHT)
{
	stack s1, s2;
	tdata tg,tg1;
	int err;
	s1 = s2 = NULL;
	while (BTTT!=NULL)
	{
		tg = Pop(BTTT,err);
		switch(tg.sign)
		{
			case 0: InsertAtLast(s1,tg); break;
			case 1:
				if (tg.ope=='(') Push(s2,tg);
				else 
				{
					tg = Pop(s2,err);
					while ((err==1)&&(tg.ope!='('))
					{
						InsertAtLast(s1,tg);
						tg = Pop(s2,err);
					}
				}
				break;
			case 2:
			case 3:
				tg1 = Peek(s2,err);
				while ((err==1)&&(tg1.sign>=tg.sign)) //kiem tra xem stack co rong hay k va xet do uu tien cua toan tu
				{
					tg1 = Pop(s2,err);
					InsertAtLast(s1,tg1);
					tg1 = Peek(s2,err);
				}
				Push(s2,tg);
				break;
			
		}
	}
	while (s2!=NULL)
	{
		tg = Pop(s2,err);
		InsertAtLast(s1,tg);
	}
	BTHT = s1;
}

float tinhgiatri(stack s){
	tdata tg2,tg3,temp;
	stack giatri,tg1;
	int a,b;
	int err;
	tg1 = s;
	giatri=NULL;
	while(tg1!=NULL){
		
		if(tg1->info.sign==0){
			tg2=Pop(tg1,err);
			Push(giatri,tg2);
		}
		if(tg1->info.sign==2||tg1->info.sign==3){
			tg2= Pop(giatri,a);
			tg3= Pop(giatri,b);
		//	printf("%d\t%d\n",tg2.num, tg3.num);
//			switch(tg1->info.ope){
//				case '+': 
//					temp.num=tg3.num+tg2.num;
//					break;
//				case '-':
//					temp.num=tg3.num-tg2.num;
//					break;
//				case '*':
//					temp.num=tg3.num*tg2.num;
//					break;
//				case '/':
//					temp.num=tg3.num/tg2.num;
//					break;
//			}
			if(tg1->info.ope == '+') temp.num = tg3.num + tg2.num;
			if(tg1->info.ope == '-') temp.num = tg3.num - tg2.num;
			if(tg1->info.ope == '*') temp.num = tg3.num * tg2.num;
			if(tg1->info.ope == '/') temp.num = tg3.num / tg2.num;
		//	printf("\n%.2f\n",temp.num);
			Push(giatri,temp);
		}
		tg1=tg1->next;
	}
	temp=Pop(giatri,err);
	return temp.num;
}

int main(){
	stack BTTT, BTHT;
	tdata giatri;
	BTTT=NULL;
	readfile(BTTT);
	printfstack(BTTT);
	printf("\n");
	printfstack_BT(BTTT);	
	BTTT_BTHT(BTTT,BTHT);
	printf("\n");
	printfstack_BT(BTHT);
	tinhgiatri(BTHT);
	printf("\n");
	float i = tinhgiatri(BTHT);
	printf("%.2f",i);	
//	printf("%f",giatri.num);
}

