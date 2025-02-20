ICollection<string> names = new List<string>();
ICollection<string> names2;

names.Add("Sina");
names.Add("Saeed");
names.Add("K1");
names.Add("Vahid");

names.Remove("Vahid");

names2 = names;
foreach (string name in names2)
{
    Console.WriteLine(name);
}
