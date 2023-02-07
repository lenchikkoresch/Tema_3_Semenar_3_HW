/*
Задача 23

Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int GetNumber(string message)
{
    int resultNumber = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out resultNumber) && 0 < resultNumber)
        {
            break;
        }
        else
        {
            Console.WriteLine("Число ввели некорректно. Повторите ввод: ");
        }
    }
    return resultNumber;
}

int N = GetNumber("Ведите натуральное число");
int i=1;
while (i<N)
{
    Console.Write(Math.Pow(i,3)+",");
    i++;
}
Console.Write(Math.Pow(i,3)+".");
