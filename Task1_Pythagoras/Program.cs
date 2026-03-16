while (true)
{
    Console.WriteLine("Введите первое число:");
    string inputA = Console.ReadLine();
    if (inputA.ToLower() == "q") break;
    double a = Convert.ToDouble(inputA);

    Console.WriteLine("Введите второе число:");
    string inputB = Console.ReadLine();
    if (inputB.ToLower() == "q") break;
    double b = Convert.ToDouble(inputB);

    double c = Math.Sqrt(a * a + b * b);

    Console.WriteLine("Гипотенуза равна:" + c);
    Console.WriteLine();
}