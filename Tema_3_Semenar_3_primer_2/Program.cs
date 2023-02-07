/*Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).*/

/*Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/

/*
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу квадратов чисел
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

int GetQuarterFromUser(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0 && result < 5)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели неккоректный номер четверти");
        }
    }
    return result;
}


int quarter = GetQuarterFromUser("Enter quarter number");


if (quarter == 1)
{
    Console.WriteLine($"x in {quarter} lies between 0 and infinity, y in {quarter} lies between 0 and infinity");
}
else if (quarter == 2)
{
    Console.WriteLine($"x in {quarter} lies between 0 and - infinity, y in {quarter} lies between 0 and infinity");
}
else if (quarter == 3)
{
    Console.WriteLine($"x in {quarter} lies between -infiniti and 0, y in {quarter} leis between -infiniti and 0");
}
else if (quarter == 4)
{
    Console.WriteLine($"x in {quarter} lies between -infiniti and 0, y in {quarter} leis between 0 and infiniti");
}
