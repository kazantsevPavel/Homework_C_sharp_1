﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Здравствуйте, семпай! Я многому научилась и могу написать для вас все чётные числа от единицы до выбранного вами числа! Какое число вы изволите выбрать?");
int a = Convert.ToInt32(Console.ReadLine());
int count = 2;
while (count<a+1)
{
Console.Write ($" {count} ");
count = count + 2;
}
Console.WriteLine();
