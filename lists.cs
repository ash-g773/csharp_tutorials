List<string> names = ["Ash", "Sanju", "Tresa"];
names.Add("Angela");
names.Add("Courtney");
names.Add("Amanda");
names.Remove("Ash");
foreach (var name in names)
{
    Console.WriteLine(name);
}
Console.WriteLine($"There are {names.Count} names in the list");

var index = names.IndexOf("Amanda");
if (index == -1)
{
    Console.Write("Name not found");
}
else
{
    Console.WriteLine($"The name {names[index]} is at index {index}");
}