using NET22App2;

Console.OutputEncoding = System.Text.Encoding.UTF8;

//Calculator();
//lesson4.taskLoop();
//lesson4.taskMatrix();
lesson4.taskLists();


void Calculator()
{
    double num1, num2 = 0;
    string[] operations = { "+", "-", "/", "*", "%", "^2" };
    string operation = "";

    Console.WriteLine("Добро пожаловать в увлекательный калькулятор!\n");

    while (true)
    {
        Console.WriteLine("\nВведите пожалуйста операцию:\n+ - / * % ^2");

        while (true)
        {
            operation = Console.ReadLine();
            if (!operations.Contains(operation))
            {
                Console.WriteLine("Вы ввели несуществующую операцию, попробуйте снова :)");
            }
            else
            {
                break;
            }
        }

        Console.WriteLine("Введите число:");
        string numStr1 = Console.ReadLine();
        if (double.TryParse(numStr1, out num1))
        {
            num1 = Convert.ToDouble(numStr1);
        }
        else
        {
            Console.WriteLine("Вы ввели не число :(");
            continue;
        }

        if (operation != "^2")
        {
            Console.WriteLine("Введите второе число:");
            string numStr2 = Console.ReadLine();
            if (double.TryParse(numStr2, out num2))
            {
                num2 = Convert.ToDouble(numStr2);
            }
            else
            {
                Console.WriteLine("Вы ввели не число :(");
                continue;
            }
        }

        switch (operation)
        {
            case "+":
                Console.WriteLine($"\nОтвет: {num1} + {num2} = {num1 + num2}\n");
                break;
            case "-":
                Console.WriteLine($"\nОтвет: {num1} - {num2} = {num1 - num2}\n");
                break;
            case "/":
                Console.WriteLine($"\nОтвет: {num1} / {num2} = {num1 / num2}\n");
                break;
            case "*":
                Console.WriteLine($"\nОтвет: {num1} * {num2} = {num1 * num2}\n");
                break;
            case "%":
                Console.WriteLine($"\nОтвет: {num1} % {num2} = {num1 % num2}\n");
                break;
            case "^2":
                Console.WriteLine($"\nОтвет: {num1} ^2 = {num1 * num1}\n");
                break;
            default:
                break;
        }

        Console.WriteLine("Желаете попробовать снова? - Введите 1");
        string next = Console.ReadLine();

        if (next != "1")
        {
            return;
        }

        Console.Clear();
    }
}


