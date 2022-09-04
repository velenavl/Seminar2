// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введи число: ");
int severalNumber = Convert.ToInt32(Console.ReadLine());
string severalNumberText = Convert.ToString(severalNumber);

if (severalNumberText.Length > 2)
{
    Console.WriteLine("Третья цифра: " + severalNumberText[2]);
}

else
{
    Console.WriteLine("Третьей цифры нет");
}