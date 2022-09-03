// Программа, которая выводит случайное трёхзначное число и удаляет вторую цифру числа.

Random random = new Random();

int randomNumber = random.Next(100,1000);

Console.WriteLine(randomNumber);

int firstNumber = randomNumber / 100;
int lastNumber = randomNumber % 10;

int result = (firstNumber * 10) + lastNumber;
Console.Write(result);

