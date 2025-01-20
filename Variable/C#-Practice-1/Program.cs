//create Variableس
string name = "Sina";
int number1 = 1, number2 = 2, number3 = 3;
double number4 = 4.78;

//converts Variableس
number1 = (int)number4;
number2 = Convert.ToInt32(number4);
string numberToString = number1.ToString();
var number5 = int.Parse(numberToString);
Console.Write(numberToString + "\n" + number2 + "\n" + number5.GetType() + "\n");

//Operators
number1 = 5;
number2 = 5;
var operatNumber1 = ++number1;
var operatNumber2 = number2++;
Console.WriteLine(operatNumber1 + "\n" + operatNumber2 + " __ " + number2);

//Operators Logical
number1 = 26;
var result = (number1 > 18) && (number1 < 25);
Console.WriteLine(result); // rersult false
var result2 = (number1 > 18) || (number1 < 25);
Console.WriteLine(result2);// result true
var result3 = !(number1 > 18);
Console.WriteLine(result3); // result false
