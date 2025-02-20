
int[] numbers = new int[6];
numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;
numbers[3] = 4;
numbers[4] = 5;
numbers[5] = 6;

//var numberSelect = numbers[..4];
//foreach (var number in numberSelect)
//{
//   // 1,2,3,4
//    Console.WriteLine(number);
//}

//var numberSelect2 = numbers[2..5];
//foreach (var number in numberSelect2)
//{
//    // 3,4,5
//    Console.WriteLine(number);
//}

string name = "Samantha Jones";
int lengthOfFirst = name.IndexOf(' ');
int lengthOfLast = name.Length - lengthOfFirst - 1;
string firstName = name.Substring(startIndex: 0,
length: lengthOfFirst);
string lastName = name.Substring(startIndex: name.Length -
lengthOfLast, length: lengthOfLast);
Console.WriteLine($"First name: {firstName}, Last name: {lastName}");
ReadOnlySpan<char> nameAsSpan = name.AsSpan();
var firstNameSpan = nameAsSpan[0..lengthOfFirst];
var lastNameSpan = nameAsSpan[^lengthOfLast..^0];
Console.WriteLine("First name: {0}, Last name: {1}",
arg0: firstNameSpan.ToString(),
 arg1: lastNameSpan.ToString());