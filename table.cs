int Table(int N)
{
    int result = 0;
    for (int i=0; i <= N; i++) 
    {
        result = i*i*i;
        Console.Write($"{result}, ");
    }
    return result;
}

int EnterData(string text)
{
    Console.WriteLine(text);
    int N = int.Parse(Console.ReadLine());
    return N;
}

int N = EnterData("Введите число: ");

int result = Table(N);
