#include<stdio.h>
int main()
{
    int a,b;
    bilash:
    scanf("%d",&a);
    scanf("%d",&b);
    while(a!=b)
    {
     if(a>b)
    {
        printf("Decrescente\n");
    }
    if(a<b)
    {
        printf("Crescente\n");
    }
    goto bilash;
    }

    return 0;
}
