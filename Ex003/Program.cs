// Программа, которая принимает на вход 2 числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.Write("Введите число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int result = firstNumber % secondNumber;

if(result == 0)
{
    Console.Write("Кратно");
}
else
{
    int ostatok = firstNumber % secondNumber;
    Console.Write(ostatok);
}