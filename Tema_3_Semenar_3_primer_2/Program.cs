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

int GetNumber (string message)
{
int resultNumber=0;
while(true)
{
    Console.WriteLine(message);
    if(int.TryParse(Console.ReadLine(), out resultNumber) && resultNumber!=0)
    {
        break;
    }
    else
    {
        Console.WriteLine("Ввели не число или некорректное число.Повторите ввод!\n");
        }
}
return resultNumber;
}

int GetQuarter (int x, int y)
{
    if (x>0 && y>0)
    return 1;
    else if (x<0 && y>0)
    return 2;
    else if (x<0 && y<0)
    return 3;
    else 
    return 4;
}
 
 int x = GetNumber ("Введите координату Х. которая не равна 0:");
 int y = GetNumber ("Введите координату Y. которая не равна 0:");
 int quarter = GetQuarter(x,y);
  
  Console.WriteLine($"Точка с координатами ({x},{y})лежит {quarter} в четверти");

