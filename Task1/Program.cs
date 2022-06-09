
// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"
void PrintEvenNumbers (int from, int to)
{
    if (from > to) return;
    if (from%2 == 0) Console.Write (from + ", ");
    PrintEvenNumbers (from+1, to);
}
int from = 4;
int to = 8;
PrintEvenNumbers (from,to);