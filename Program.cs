internal class Program
{
    private static void Main(string[] args)
    {
        double a, b , result;
        char o;
        Console.Write("a = ");
        if (double.TryParse(Console.ReadLine(), out a))
        {
            Console.Write("b = ");
            if (double.TryParse(Console.ReadLine(), out b))
            {
                Console.Write("Операция: ");
                if (char.TryParse(Console.ReadLine(), out o))
                {
                    switch (o)
                    {
                        case '+':
                            result = a + b;
                            Console.WriteLine($"{a} + {b} = {result}");
                            break;
                        case '-':
                            result = a - b;
                            Console.WriteLine($"{a} - {b} = {result}");
                            break;
                        case '*':
                            result = a * b;
                            Console.WriteLine($"{a} * {b} = {result}");
                            break;
                        case '/':
                            if (b == 0) { Console.WriteLine("На 0 нельзя делить"); }
                            else
                            {
                                result = a / b;
                                Console.WriteLine($"Результат: {result}");
                            }
                            break;
                        default:
                            Console.WriteLine("Неправильно ввели операцию");
                            break;
                    }
                } else { Console.WriteLine("Ошибка при вводе операций"); }
            }
            else { Console.WriteLine("Ошибка при вводе b"); }
        }
        else { Console.WriteLine("Ошибка при вводе a"); }
    }
}