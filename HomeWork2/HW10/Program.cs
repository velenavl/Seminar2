// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int ShowSecondNumber(int number)
{
    int firstNumber = number * 0;
    int secondNumber = number % 100;
    int result = (secondNumber / 10);
    {
        return result;
    }
}
int result = ShowSecondNumber(Number);
Console.WriteLine(result);