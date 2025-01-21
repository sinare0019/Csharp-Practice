int number1 = 0;

////While
while (number1 < 5)
{
    Console.WriteLine("Sina");
    number1++;
}

//do While
number1 = 0;
do
{
    Console.WriteLine("Tina");
    number1++;
}
while (number1 < 5);

//for
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Hosna");
}

//foreach
string[] names = ["Sina", "Tina", "Hosna"];
foreach (string item in names)
{
    Console.WriteLine(item);
}