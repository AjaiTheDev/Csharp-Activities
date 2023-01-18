
string?[] nameArray = new string[3];
string?[] destinationArray = new string[3];


Console.WriteLine("enter the names of passengers");

for (int i = 0; i < 3; i++)
{
    nameArray[i] = Console.ReadLine();
}

Console.WriteLine("\nenter the destinations");

for (int i = 0; i < 3; i++)
{
    destinationArray[i] = Console.ReadLine();
}


var arr = nameArray.Concat(destinationArray).ToArray();
Console.WriteLine("\njoined array\n");
foreach (var item in arr)
{
    Console.WriteLine(item);
}
