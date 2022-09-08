// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



int Print(int N, int count)  
{
if (N == count) return N;
return N + Print(N + 1, count);  
}

Console.Write("Введите первое число M = ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число N = ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine(Print(number1, number));
