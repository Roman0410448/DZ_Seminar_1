Console.Write("Введите первое число: ");
int firstValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int thirdValue = Convert.ToInt32(Console.ReadLine());

int max = firstValue;

if (secondValue > max)
{
   max = secondValue;
}
if (thirdValue > max)
{
   max = thirdValue;
}

Console.WriteLine("Наибольшее из введённых чисел -> " + max);
