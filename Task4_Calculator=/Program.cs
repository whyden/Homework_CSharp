Console.WriteLine("Введите первое число:");
double result = Convert.ToDouble(Console.ReadLine());

while (true)
{
    Console.WriteLine("Введите оператор (+, -, *, /) или '=' " +
        "для результата:");
    string op = Console.ReadLine();

    if (op == "=")
    {
        Console.WriteLine("Результат: " + result);

        Console.WriteLine("Введите новое первое число (или 'q'" +
            "для выхода):");
        string newInput = Console.ReadLine();

        if (newInput.ToLower() == "q")
            break;

        result = Convert.ToDouble(newInput);
        continue;
    }

    Console.WriteLine("Введите следующее число:");
    double num = Convert.ToDouble(Console.ReadLine());

    switch (op)
    {
        case "+":
            result += num;
            break;

        case "-":
            result -= num;
            break;

        case "*":
            result *= num;
            break;

        case "/":
            result /= num;
            break;

        default:
            Console.WriteLine("Неизвестный оператор");
            break;
    }
}