// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
int DataEntryXYZ(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double FindDistance(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double distance = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));
    return distance;
}

int x1 = DataEntryXYZ("Координаты точки X1: ");
int y1 = DataEntryXYZ("Координаты точки Y1: ");
int z1 = DataEntryXYZ("Координаты точки Y1: ");
int x2 = DataEntryXYZ("Координаты точки X2: ");
int y2 = DataEntryXYZ("Координаты точки Y2: ");
int z2 = DataEntryXYZ("Координаты точки Y2: ");
double distance = FindDistance(x1, x2, y1, y2, z1, z2);
Console.WriteLine($"Расстояние между точками A({x1},{y1},{z1}) и B({x2},{y2},{z2}) -> {distance}");