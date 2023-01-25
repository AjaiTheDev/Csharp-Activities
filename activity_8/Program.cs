using System.Transactions;

Console.WriteLine("display  nth Position");

double[] MyArray = new double[10];
string?[] MyStringArray = new string[10];
int Position;


Console.WriteLine("enter the destinations");
for(int i = 0;i < 10; i++)
{
    MyStringArray[i] = Console.ReadLine(); 
}

Console.WriteLine("\nEnter the fares");
for (int i = 0; i < 10; i++)
{
    MyArray[i] = Convert.ToDouble(Console.ReadLine());
}


Console.WriteLine("\nenter the Position which you want to search");
Position= Convert.ToInt32(Console.ReadLine());
if((Position > MyArray.Length) || (Position > MyStringArray.Length))
{

    Console.WriteLine("There is no element in that Position");
}
else
{
    Console.WriteLine($"Destination: {MyStringArray[Position-1]}");
    Console.WriteLine($"Fare = {MyArray[Position-1]}");
}


