var today = DateTime.Today;

Console.WriteLine("enter dob in YYYY:MM:DD format");
var Bday = Console.ReadLine();
var myDate = Convert.ToDateTime(Bday);
var age = (today.Year) - (myDate.Year);





Console.WriteLine($"You are {age} years old");
var ageHours = age * 8220;
Console.WriteLine($"You are {ageHours} Hours old");
var ageDays = age * 365;
Console.WriteLine($"You are {ageDays} days old");
int ageWeeks = Convert.ToInt32(age * 52.176);
Console.WriteLine($"You are {ageWeeks} Weeks old");
int ageMonths = Convert.ToInt32(age * 30.4);
Console.WriteLine($"You are {ageMonths} Months old");

if ((myDate.Year) % 4 == 0)
{
    Console.WriteLine("leap year");
}
else
{
    Console.WriteLine("not a leap year");
}
