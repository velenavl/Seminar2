// Программа, которая принимает на вход 2 числа и проверяет, является ли одно число квадратом второго.
Console.WriteLine("Введите первое число: ");
int N1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int N2 = Convert.ToInt32(Console.ReadLine());


bool CheckSqrt(int number1, int number2)
{
    if(number1 > number2)
    {
        if(number2 * number2 == number1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    else
    {
        if(number1 * number1 == number2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

bool result = CheckSqrt(N1, N2);
if(result == true)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}