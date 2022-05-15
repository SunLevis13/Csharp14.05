void Number(int a)
{
    if (a % 7 == 0 & a % 13 == 0)
    {
        Console.WriteLine("Кратно");
    }
    else
    {
        Console.WriteLine("Не кратно");
    }
}

Number(14);