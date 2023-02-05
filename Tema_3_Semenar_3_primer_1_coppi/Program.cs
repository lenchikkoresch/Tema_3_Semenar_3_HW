/*
1. Получить две координаты с консоли
2. Получить четверть
3. вывести на консоль результат
*/

int GetNumber(string message)
{
    int resultNumber=0;
while(true)
{
    Console.WriteLine(message);
    if(int.TryParse(Console.ReadLine(),out resultNumber) && resultNumber !=0) 
    {
        break;
    }
    else
    {
        Console.WriteLine("Ввели не число или не корректное число. Повторите ввод!\n");
    }
}
    return resultNumber;
}

int GetQuarter (int x, int y)
{if (x > 0 && y > 0)
return 1;
else if (x < 0 && y > 0)
return 2;
else if (x < 0 && y < 0)
return 3;
else 
return 4;
}
int x = GetNumber("Введие координату X, которая не равна 0:");
int y = GetNumber("Введие координату Y, которая не равна 0:");
int guarter = GetQuarter(x,y);

Console.WriteLine($"Точка с координатами ({x},{y})лежит в {guarter} четверти");



