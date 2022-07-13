// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int numder1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = numder1;

if (numder1 > number2)
{
    max = numder1;
}
else
{
   max = number2;
}
if (max > number3)
{
    Console.Write("max = "); Console.Write(max);
}
else
{
    Console.Write("max = "); Console.Write(number3);
}