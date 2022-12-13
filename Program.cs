// Является ли число полиндромом

void rang(string str)
{
        if (str.Length == 5)
    {
            if (str[0] == str[4] && str[1] == str[3])
        {
            Console.WriteLine($"Число {str} является полиндромом");
        }
        else
        {
            Console.WriteLine($"Число {str} не является полиндромом");
        }
    }
    else
    {
        Console.WriteLine($"Число {str} состоит не из 5-ти цифр");
    }
}
string EnterData(string text)
{
    Console.Write(text);
    string number = Console.ReadLine();
    return number;
}
string N = EnterData("Введите пятизначное число: ");
rang(N);
