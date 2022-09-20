Console.WriteLine("Введите трёхзначное число ");
int a = Convert.ToInt32(Console.ReadLine());
int secondNum (int num)
{
    int b = (a % 100) / 10;
    return (b);
}
int res = secondNum(a);
Console.WriteLine($"Вторая цифра {res}");