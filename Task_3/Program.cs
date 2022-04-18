Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

int index = 1;

while (index <= a - 1)
{
    Console.Write($"{Math.Pow(index, 3)}, ");
    index++;
}
Console.Write($"{Math.Pow(index, 3)}.");
