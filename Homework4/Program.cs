//Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.
void Day(int num)
{
    string text = "work day";

    if (num == 6 || num == 7)
    {
        text = "weekend";
    }

    Console.WriteLine($"{num} -> {text}");

}

Day(6);

