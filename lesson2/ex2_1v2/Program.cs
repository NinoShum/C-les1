int Max ( int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}


int a1 = 10;
int a2 = 15;
int a3 = 520;
int a4 = 60;
int a5 = 1;
int a6 = 20;
int a7 = 1;
int a8 = -20;
int a9 = 10;

int max = Max ( Max(a1,a2,a3), Max(a6,a4,a5), Max(a9,a7,a8));

Console.WriteLine (max);
