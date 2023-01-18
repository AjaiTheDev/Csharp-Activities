using System.Transactions;

Console.WriteLine("display  nth position");

double[] myArray = new double[3];
string?[] myStringArray = new string[3];
int position;


Console.WriteLine("enter the destinations");
for(int i = 0;i < 3; i++)
{
    myStringArray[i] = Console.ReadLine(); 
}

Console.WriteLine("\nEnter the fares");
for (int i = 0; i < 3; i++)
{
    myArray[i] = Convert.ToDouble(Console.ReadLine());
}


Console.WriteLine("\nenter the position which you want to search");
position= Convert.ToInt32(Console.ReadLine());
if((position > myArray.Length) || (position > myStringArray.Length))
{

    Console.WriteLine("There is no element in that position");
}
else
{
    Console.WriteLine($"Destination: {myStringArray[position-1]}");
    Console.WriteLine($"Fare = {myArray[position-1]}");
}


