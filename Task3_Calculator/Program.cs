while (true)
{
    Console.WriteLine("Введите первое число:");
    string inputA = Console.ReadLine();
    if (inputA.ToLower() == "q") break;
    double num1 = Convert.ToDouble(inputA);

    Console.WriteLine("Введите второе число:");
    string inputB = Console.ReadLine();
    double num2 = Convert.ToDouble(inputB);

    Console.WriteLine("Введите оператор (+, -, *, /):");
    string op = Console.ReadLine();

    double result;
    switch (op)
    {
        case "+":
            result = num1 + num2;
            break;
        case "-":
            result = num1 - num2;
            break;
        case "*":
            result = num1 * num2;
            break;
        case "/":
            if (num2 != 0)
                result = num1 / num2;
            else
            {
                Console.WriteLine("Ошибка: деление на нуль!");
                continue;
            }
            break;
        default:
            Console.WriteLine("Неизвестный оператор");
            continue;
    }

    Console.WriteLine("Результат: " + result);
    Console.WriteLine();
}