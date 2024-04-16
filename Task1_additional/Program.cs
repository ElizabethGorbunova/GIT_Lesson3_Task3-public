// See https://aka.ms/new-console-template for more information


//Task7_additional

Console.WriteLine("Enter your first number:");
int number1 = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your second number:");
int number2 = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your third number:");
int number3 = Int32.Parse(Console.ReadLine());


static int Calculate(int number1, int number2, int number3)
{
    return (number1 + number2 + number3) / 3;
}

Console.WriteLine($"The average arithmetic result is: {Calculate(number1, number2, number3)}");