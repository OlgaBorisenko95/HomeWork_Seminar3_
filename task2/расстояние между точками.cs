

int x1 = EnterData("Введите координату x1: ");
int y1 = EnterData("Введите координату y1: ");
int z1 = EnterData("Введите координату z1: ");
int x2 = EnterData("Введите координату x2: ");
int y2 = EnterData("Введите координату y2: ");
int z2 = EnterData("Введите координату z2: ");

double FindDistance(int x1, int y1, int x2, int y2, int z1, int z2)
{  
    double result = Math.Sqrt(Math.Pow((x2-x1), 3) + Math.Pow((y2-y1), 3) + Math.Pow(z2-z1, 3)));
    return result;
}
int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double result = FindDistance(x1, y1, x2, y2, z1, z2);


Console.WriteLine($"Расстояние между заданными точками равно {result}");
