using C__Practice_1;
//redord instance
// model 1
var (name, lastName) = new Person(Name: "Sina", LastName: "Rezaei");
Console.WriteLine("Name: " + name + " LastName: " + lastName);


Person person = new Person(Name: "Reza", LastName: "Rezaei");
// copy and edit
var person2 = person with { Name = "Ali" };
Console.WriteLine(person2.Name);

// model 2
Register register = new Register
{
    Name = "Hasan",
    LastName = "Dalir",
    Age = 27
};
Console.WriteLine(register);
// copy and edit
var register2 = register with { Name="Hosein"};
Console.WriteLine(register2);

// Error becose Name is Redonly
//register.Name = "dddd";