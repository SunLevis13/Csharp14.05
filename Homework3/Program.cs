// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
void Numb(int a)
{
    int thirdnumb = 1;
    string txt;

    while (a > 99)
    {
        thirdnumb = a % 10;
        a = a / 10;

    }
    txt = $"{thirdnumb}";
    if (thirdnumb == 1)
    {
        txt = "no third numb";
    }
    Console.WriteLine(txt);
}
Numb(1789);