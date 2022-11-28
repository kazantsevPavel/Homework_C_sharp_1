// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Здравствуйте, семпай! Я готова сравнить три числа и найти максимальное из них! Давайте попробуем!");
Console.WriteLine("Напишите первое число, семпай:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Какое прекраное число, семпай! А теперь второе число, пожалуйста, семпай:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Поверить не могу! Это число даже лучше первого, семпай! А теперь последнее число, пожалуйста, семпай:");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine("Семпай! Похоже, что это число самое большое: " + max + "!");
Console.WriteLine("Рада служить вам, семпай!");
Console.WriteLine();