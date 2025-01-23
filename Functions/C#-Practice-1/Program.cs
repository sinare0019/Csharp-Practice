using System.Diagnostics.CodeAnalysis;

var resultSum = sum(2, 6);
printNumbers(resultSum);
Console.WriteLine();

int outNumber = 50;
int refNumber = 50;
int number = 50;
paramFunction(out outNumber, ref refNumber, number);
Console.Write("Out: "+ outNumber + " ref: "+refNumber+" param: "+number);
Console.WriteLine();

//function
int sum(int number1, int number2)
{
    return number1 + number2;
}

//recursive function
void printNumbers(int number)
{
    if (number > 0)
    {
        Console.WriteLine("number: " + number);
        number--;
        printNumbers(number);
    }
}

//parameter Function
void paramFunction(out int a, ref int b, int c)
{
    a = 10; b = 20; c = 30;
}