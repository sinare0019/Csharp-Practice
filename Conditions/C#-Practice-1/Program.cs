// IF
int age;
string nameFamily;
Console.Write("Your Age: ");
age = int.Parse(Console.ReadLine());
if (age < 19)
{
    Console.WriteLine("Im Sorry, You Not Register");
}
else if (age > 40)
{
    Console.WriteLine("Im Sorry, You Not Register");
}
else
{
    Console.Write("Your Name and Family: ");
    nameFamily = Console.ReadLine();
    Console.WriteLine("WellCom " + nameFamily);
}

//IF 2
object keyVal = Console.ReadLine();
if (keyVal is int number)
{
    Console.WriteLine(number + "is Number");
}
else if (keyVal is string text1)
{
    Console.WriteLine(text1 + "is String");
}
else
{
    Console.WriteLine("Is Null");
}


//Swich
var randomNumber = (new Random()).Next(1, 6);
Console.WriteLine("Random Number " + randomNumber);
switch (randomNumber)
{
    case 1:
        Console.WriteLine("One");
        break;
    case 2:
        Console.WriteLine("Two");
        goto case 1;
    case 3:
    case 4:
        Console.WriteLine("Three or four");
        goto case 1;

    default:
        Console.WriteLine("Default");
        break;
}