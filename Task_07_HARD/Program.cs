// Задача 7 HARD по желанию - идет за 2 необязательных Напишите программу,
// которая принимает на вход целое число любой разрядности и на выходе показывает третью цифру слева этого числа или говорит,
// что такой цифры нет. Через строку решать нельзя.

Console.WriteLine("Семпай, теперь я могу найти третью цифру любого числа! Проверьте меня, семпай, напишите любое число!");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 100)
{
    Console.WriteLine("Семпай, но это число не содержит третьей цифры. Оно слишком мало, простите меня, мне так жаль!");
}
else
{
    while (N >= 1000)
    {
        N = N / 10;
    }
    int d = N % 10;
    Console.WriteLine("Семпай, семпай, третья цифра это: "+ d + "!");
    Console.WriteLine("Мне так притно быть полезной моему господину!");
}
Console.WriteLine();