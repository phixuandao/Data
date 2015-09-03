#include<stdio.h>
#include<stdlib.h>
#include<conio.h>
int TimKiemTuanTu(int a[],int n,int x)
{
    int i=0;
    a[n]=x;
    while(a[i]!=x) i++;
    if(i<n) return i;
    return -2;
}
int TimKiemNhiPhan(int a[],int n,int x)
{
    int left=0, right=n-1,mid;
    while(left<=right)
    {
        mid=(left+right)/2;
        if(x==a[mid]) return mid;
        if(x<a[mid]) right=mid-1;
        else left=mid+1;
    }   
    return -2;
}
void taofile(int a[],int n)
{
    int i;
    FILE *f;
    f=fopen("input.in","wt");  
    for(i=0;i<n;i++)
    a[i]=rand()%255;
    for(i=0;i<n;i++)
    fprintf(f,"%d ",a[i]);
    fclose(f);
}
void sapxepchon(int a[],int n)
{
    int i,j,tg;
    for(i=0;i<n-1;i++)
    for(j=i+1;j<n;j++)
    if(a[i]>a[j])
    {
        tg=a[i];
        a[i]=a[j];
        a[j]=tg;
    }
}
void sapxepchen(int a[],int n)
{
    int i,j,tg;
    for(i=1;i<n;i++)
    {
        tg=a[i];
        j=i-1;
        while(j>=0&&a[j]>tg)
        {
            a[j+1]=a[j];
            j--;
        }
        a[j+1]=tg;
    }
}
void sapxepnoibot(int a[],int n)
{
    int tg,i,j;
    for(i=0;i<n-1;i++)
    for(j=n-1;j>i;j--)
        if(a[j]<a[j-1])
        {
            tg=a[j];
            a[j]=a[j-1];
            a[j-1]=tg;
        }
}
void sapxepnhanh(int a[],int left, int right)
{
    int i,j,x,tg;
    if(left>=right) return;
    x= a[(left+right)/2];
    i=left;
    j=right;
    do
    {
        while(a[i]<x) i++;
        while(a[j]>x) j--;
        if(i<=j)
        {
            tg=a[i];
            a[i]=a[j];
            a[j]=tg;
            i++;j--;
        }
    }while(i<j);
    if(left<j) sapxepnhanh(a,left,j);
    if(i<right) sapxepnhanh(a,i,right);
}
using namespace std ;
void usingFILEpointer(int a[],int n)
{
	FILE *f , *g;
	int i,j,tg,m;
//	printf("nhap tu can tim:\n");
//	scanf("%d",&m);
	f=fopen("input.in","rt");
	g=fopen("output.out","wt") ;	
		fscanf(f,"%d",&a[i]); 
		for(i=0;i<n;i++)
		{
		int k ;
		 fscanf(f,"%d ",&k) ;
		 a[i] = k ;
		}
//		sapxepchen(a,n);
//		printf("%d",TimKiemNhiPhan(a,n,m)+1);
        for(i=0;i<n;i++)
        fprintf(g,"%d ",a[i]);
		fclose(f) ;
		fclose(g) ;
}
using namespace std ;
int main()
{
	//using FILe pointer
	int n,a[500000],m;
	printf("nhap so phan tu cua mang:\n");
	scanf("%d",&n);
    taofile(a,n);
	usingFILEpointer(a,n)		 ;
	getch();
}
