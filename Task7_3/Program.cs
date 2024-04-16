// See https://aka.ms/new-console-template for more information

//Task7_3


Console.Write("Write an amount to convert PLN to USD: ");

float valueToConvert = Int32.Parse(Console.ReadLine());

Console.Write("Write the current exchange rate: ");

float exchangeRate = float.Parse(Console.ReadLine());


static float ConvertMethod(float valueToConvert, float exchangeRate)
{
    return valueToConvert / exchangeRate;
}

double result= Math.Round(ConvertMethod(valueToConvert, exchangeRate), 2);


Console.WriteLine($"\n{valueToConvert} PLN is {result} USD");



