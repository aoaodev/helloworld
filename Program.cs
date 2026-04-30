var names = new List<string> { "AoAo", "Ana", "Felipe" };

names.Add("David");
names.Add("Sydney");
names.Add("Stan");
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}