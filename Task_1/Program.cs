Console.Write("Введите пятизначное число: ");
int a = int.Parse(Console.ReadLine());
if (a / 10000 == 0)
{
    Console.WriteLine("Вы ввели не пятизначное число!");
}
else
{
    int number1 = a % 10;
    int number2 = (a / 10) % 10;
    int number4 = (a / 1000) % 10;
    int number5 = (a / 10000) % 10;
    if (number1 == number5 & number2 == number4)
    {
        Console.WriteLine("Введеное число палиндром");
    }
    else Console.WriteLine("Введеное число не палиндром");
}
