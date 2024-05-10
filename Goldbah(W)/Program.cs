static bool IsPrime(int num)
{
    if (num <= 1)
        return false;

    if (num == 2)
        return true;

    if (num % 2 == 0)
        return false;

    for (int i = 3; i <= Math.Sqrt(num); i += 2)
    {
        if (num % i == 0)
            return false;
    }
    return true;
}

static void FindGoldbachPairs(int num)
{
    for (int i = 2; i <= num / 2; i++)
    {
        if (IsPrime(i) && IsPrime(num - i))
        {
            Console.WriteLine($" ({i};{num - i}) ");
        }
    }
}


Console.WriteLine("Введите число для проверки Проблемы Гольдбаха:");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 != 0 || number <= 2)
{
    Console.WriteLine("Для нечетных чисел или чисел меньше или равных 2 решения не существует.");
}
else
{
    FindGoldbachPairs(number);
}
