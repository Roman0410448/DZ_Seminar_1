//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int N = 1;
bool not = true;
Console.WriteLine("Чётные числа от 1 до " + number);
while (N <= number)
{
   if (N % 2 != 1)
 {
  Console.Write(N + ", ");
  not = false;
 }
N++;
}

if (not)
{
 Console.WriteLine("Нет чётных чисел!");
}