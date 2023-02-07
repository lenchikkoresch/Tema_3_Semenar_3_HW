/*Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int getCoordinate(string message)
{
    int result = 0;
    while (true)
        {
            Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Число ввели некорректно, повторите.");
        }
    }
    return result;
}

double getDistance(int ax, int ay, int az, int bx, int by, int bz)
{
    double result = Math.Round(Math.Sqrt(Math.Pow(ax-bx,2)+Math.Pow(ay-by,2)+Math.Pow(az-bz,2)));
    return result;
}
int ax = getCoordinate ("Enter x coordinate of the first point");
int ay = getCoordinate ("Enter y coordinate of the first point");
int az = getCoordinate ("Enter z coordinate of the first point");
int bx = getCoordinate ("Enter x coordinate of the second point");
int by = getCoordinate ("Enter y coordinate of the second point");
int bz = getCoordinate ("Enter z coordinate of the second point");
double distance = getDistance(ax, ay, az, bx, by, bz);
Console.WriteLine($"Distance between ( {ax},{ay},{az}) and ({bx},{by},{bz}) is {distance:f2}");
