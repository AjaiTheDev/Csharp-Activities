Console.WriteLine("enter the passenger details");

Console.Write("name:");
string? FName = Console.ReadLine(); // read name from users
Console.WriteLine("enter the miles traveled");
int MilesTraveled = Convert.ToInt32(Console.ReadLine());
int FreqFlightPoints;

if(MilesTraveled > 10000 && MilesTraveled < 20000)
{
    FreqFlightPoints = 10;
}
else if(MilesTraveled > 20000 && MilesTraveled < 50000)
{
    FreqFlightPoints = 20;
}
else if(MilesTraveled > 50000 && MilesTraveled < 100000)
{
    FreqFlightPoints= 30;
}
else if(MilesTraveled > 100000)
{
    FreqFlightPoints= 50;
}
else
{
    FreqFlightPoints= 0;
}

Console.WriteLine($"\n{FName}");
Console.WriteLine("miles traveled: {0} ", MilesTraveled);
Console.WriteLine("flight points: {0}", FreqFlightPoints);
