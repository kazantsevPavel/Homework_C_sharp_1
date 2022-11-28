// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Привет, семпай! Я могу сравнить два простых числа и найти большее из них! Давай попробуем!");
Console.WriteLine("Напишите первое число, семпай:");
int a = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Какое прекраное число! А теперь второе число, пожалуйста, семпай:");
int b = Convert.ToInt32 (Console.ReadLine());
if (a>b)
{
    Console.WriteLine ("Число "+ a +" точно больше числа "+ b +" семпай!");
}
else 

{

Console.WriteLine ("Число "+ b +" точно больше числа "+ a +" семпай!");

}
Console.WriteLine();