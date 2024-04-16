// See https://aka.ms/new-console-template for more information

//Task7_2

Console.WriteLine("Enter your first operand:");
int a = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your second operand:");
int b = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your sign:");
string sign = Console.ReadLine();

switch (sign)
{
    case "+":
        static int Addition(int a, int b)
        {
            return a + b;
        }
        Console.WriteLine($"The result of addition is: {Addition(a, b)}");
        break;

    case "-":
        static int Subtraction(int a, int b)
        {
            return a - b;
        }
        Console.WriteLine($"The result of subtraction is: {Subtraction(a, b)}");
        break;

    case "*":
        static int Multiplication(int a, int b)
        {
            return a * b;
        }
        Console.WriteLine($"The result of multiplication is: {Multiplication(a, b)}");
        break;

    case "/":
        static double Division(int a, int b)
        {
            if (b == 0)
                return default;
            return Math.Round(((float)a / b), 3);
        }
        Console.WriteLine($"The result of division is: {Division(a, b)}");
        break;
        
    default:
        Console.WriteLine($"There is no such sign as: {sign}");
        break;
}

Console.ReadKey();