
string?[] NameArray = new string[10];
string?[] DestinationArray = new string[10];


Console.WriteLine("enter the names of passengers");

for (int i = 0; i < 10; i++)
{
    NameArray[i] = Console.ReadLine();
}

Console.WriteLine("\nenter the destinations");

for (int i = 0; i < 10; i++)
{
    DestinationArray[i] = Console.ReadLine();
}

var Arr = new String[NameArray.Length];

for (int i = 0; i < NameArray.Length; i++)
{
    Arr[i] = $"{NameArray[i]} : {DestinationArray[i]}";
}

foreach (var item in Arr)
{
    Console.WriteLine(item);
}