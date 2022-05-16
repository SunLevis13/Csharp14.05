// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
void Numb (int a)
{if(a > 99)
 {
    Console.WriteLine($"{a % 10}");
 }
 else
 {
     Console.WriteLine("no third numb");
 }
}
Numb(178);