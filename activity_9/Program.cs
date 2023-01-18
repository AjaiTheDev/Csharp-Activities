var today = DateTime.Today;
Console.WriteLine("Type in your Date of birth:");
var dob = Console.ReadLine();
var myDate = Convert.ToDateTime(dob);
var age = today.Year - myDate.Year;


if (age < 10)
{
    Console.WriteLine($"You are {age} years old - Kid");
}
else if (age > 10 && age < 30)
{
    Console.WriteLine($"You are {age} years old - Youth");
}
else if (age > 30 && age < 60)
{
    Console.WriteLine($"You are {age} years old - Adult");
}
else
{
    Console.WriteLine($"You are {age} years old - Older");
}
