
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int sum = 0;
void SumNumbers (int from, int to)
{
    if (from > to) return;
    sum += from;
    SumNumbers(from+1, to); 
}
int m = 4;
int n = 8;
SumNumbers(m,n);
Console.WriteLine ($"M = {m}; N = {n} -> {sum}");
