// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 9
// 

int Print(int M, int N)  
{
   if (M > 0 && N > 0) return  Print(M - 1, Print(M, N - 1));
   else if (M > 0 && N == 0) return Print(M - 1, 1);
   else  return N + 1;
}

Console.Write("Введите первое число M = ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число N = ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine(Print(number1, number));
