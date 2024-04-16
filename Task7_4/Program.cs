// See https://aka.ms/new-console-template for more information

//Task7_4


Console.WriteLine("Enter your number:");

int number = Int32.Parse(Console.ReadLine());



//Check for Positive or Negative Number
static bool PositiveNegativeNumber(int number)
{
    if (number > 0)
        return true;
    else
        return false;
}

if (PositiveNegativeNumber(number))
{
    Console.WriteLine($"\nThe number {number} is positive");
}
else
{
    Console.WriteLine($"\nThe number {number} is negative");
}




//Check for Simple number or not

static bool CheckSimpleNumber(int number)
{
    int counter = 0;
    for(int i =2; i<number-1; i++)
    {
        if (number % i == 0)
            counter++;
        if (counter > 0)
            break;
    }

    if (counter > 0)
        return true;
    else
        return false;
}


if (CheckSimpleNumber(number))
{
    Console.WriteLine($"\nThe number {number} is not simple");
}
else
{
    Console.WriteLine($"\nThe number {number} is simple");
}




//Check for division by 2,5,3,6,9
static bool CheckDivision(int number, int divident)
{

    if (number%divident==0)
        return true;
    else
        return false;
}

if (CheckDivision(number,6))
{
    Console.WriteLine($"\nThe result doesn't have remainder");
}
else
{
    Console.WriteLine($"\nThe result has remainder");
}



Console.ReadLine();