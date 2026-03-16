while (true)
{
    Console.WriteLine("Введите число:");
    string input = Console.ReadLine();
    if (input.ToLower() == "q") break;
    int number = Convert.ToInt32(input);
    
    if (number % 2 == 0)
    {
        Console.WriteLine("Число четное");
    }
    else
    {
        Console.WriteLine("Число нечетное");
    }

    Console.WriteLine();
} 