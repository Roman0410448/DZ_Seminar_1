Console.Write("Введите первое число: ");
int firstValue = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите второе число: ");
int secondValue = Convert.ToInt32(Console.ReadLine());
if (firstValue > secondValue)
{  Console.WriteLine("Первое число " + firstValue + " больше чем второе " + secondValue);
}
else
{
    Console.WriteLine("Второе число " + secondValue + " больше чем первое " + firstValue);
}