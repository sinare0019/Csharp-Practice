
int[] numbers = new int[6];
numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;
numbers[3] = 4;
numbers[4] = 5;
numbers[5] = 6;

var numberSelect = numbers[..4];
foreach (var number in numberSelect)
{
   // 1,2,3,4
    Console.WriteLine(number);
}

var numberSelect2 = numbers[2..5];
foreach (var number in numberSelect2)
{
    // 3,4,5
    Console.WriteLine(number);
}