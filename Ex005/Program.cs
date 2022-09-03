// Метод. Программа, которая принимает на вход число и проверяет кратно ли оно одновременно 7 и 23.

bool CheckNumber(int number, int firstDivider, int secondDivider)
{
    if (number % firstDivider == 0)
    {
        if (number % secondDivider == 0)
        {
            return true;
        }
    }
    return false;
}

Console.Write("Введите число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

bool result = CheckNumber(firstNumber, 7, 23);

Console.Write(result);