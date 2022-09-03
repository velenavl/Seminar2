// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа:
// 78 -> 8
// 12 -> 2
// 85 -> 8

Random random = new Random();

int randomNumber = random.Next(10,100);

Console.WriteLine(randomNumber);

int lastNumber = randomNumber % 10;
int firstNumber = randomNumber / 10;

if(lastNumber > firstNumber)
{
    Console.WriteLine($"Максимальное число = {lastNumber}"); // интерполяция
}
else
{
    Console.WriteLine($"Максимальное число = {firstNumber}");
}
