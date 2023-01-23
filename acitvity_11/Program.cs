Console.WriteLine("enter the alphabet");

var oddList = new List<int>();
var evenList = new List<int>();

char FlightAlpha =Convert.ToChar(Console.ReadLine());


for (int i = 100; i < 200; i++)
{
    if (i % 2 == 0)
    {
        evenList.Add(i);
    }
    else
    {
        oddList.Add(i);
    }
}

switch (FlightAlpha)
{
    case 'F' or 'f':
        foreach (int i in oddList)
        {
            Console.WriteLine($"F{i}");
        }
        break;
    case 'w' or 'W':
        foreach (int i in evenList)
        {
            Console.WriteLine($"W{i}");
        }
        break;
}


