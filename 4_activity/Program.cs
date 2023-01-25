var Today = DateTime.Today;

Console.WriteLine("enter dob in YYYY-MM-DD format");
var Bday = Console.ReadLine();
var MyDate = Convert.ToDateTime(Bday);
var Day = (Today - MyDate).TotalDays;

int DaysInt = (int)Day;
int Age = DaysInt / 365;
int AgeHours = DaysInt * 24;
int AgeWeeks = DaysInt / 7;
int AgeMonths = Age * 12;


Console.WriteLine($"You are {Age} years old");
Console.WriteLine($"You are {AgeHours} Hours old");
Console.WriteLine($"You are {DaysInt} days old");
Console.WriteLine($"You are {AgeWeeks} Weeks old");
Console.WriteLine($"You are {AgeMonths} Months old");

if ((MyDate.Year) % 4 == 0)
{
    Console.WriteLine("leap year");
}
else
{
    Console.WriteLine("not a leap year");
}
