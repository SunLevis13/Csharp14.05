// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
void Numb()
{
    int RandomNumb = new Random().Next(100, 1000);
    Console.WriteLine($"{RandomNumb} -> {RandomNumb / 100}{RandomNumb % 10}");

}

Numb();