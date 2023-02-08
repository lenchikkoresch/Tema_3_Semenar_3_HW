/*Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/
int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && 9999 < result && result < 100000)
        {
            break;
        }
        else
        {
            Console.WriteLine("Число ввели некорректно");
        }
    }
    return result;
}

string IsPolindrome(string numbered)
{
    string number1 = numbered.ToString();
    int caunt = number1.Length;
    int a;
    int i = 0;
    a = (caunt / 2);
    for (i = 0; i < a; i++)
    {
        if (number1[i] == number1[caunt - 1 - i])
        {
            Console.WriteLine($"{number1} - Палиндром");
        }
        else
        {
            Console.WriteLine($"{number1} - НЕ палиндром");
        }
    }
    return number1;
}


int result = GetNumber("Введите пятизначное положительное число");
string numbered = result.ToString();
string result1 = IsPolindrome(numbered);
