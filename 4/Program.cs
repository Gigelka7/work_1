//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
int a = 2;
int b = 7;
int c = 3;
if (a > b & a > c)
{
    Console.WriteLine(a);
}
else if (b > a & b > c)
{
    Console.WriteLine(b);
}
else
{
    Console.WriteLine(c);
}