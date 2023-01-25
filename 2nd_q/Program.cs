Console.WriteLine("\n different fares\n");
Console.WriteLine("enter the Fare");
double Fare = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\nenter the BookingTime");
int BookingTime = Convert.ToInt32(Console.ReadLine());
double ChangedFare = 0;

if (BookingTime > 6 & BookingTime < 9)
{
    ChangedFare = Fare + (Fare * 10 / 100);
    Console.WriteLine("\nfare = {0}", ChangedFare);
}
if (BookingTime > 9 & BookingTime < 17)
{
    ChangedFare = Fare + (Fare * 20 / 100);
    Console.WriteLine("\nfare = {0}", ChangedFare);
}
if (BookingTime > 17 & BookingTime < 23)
{
    ChangedFare = Fare + (Fare * 7 / 100);
    Console.WriteLine("\nfare = {0}", ChangedFare);
}
if (BookingTime < 6)
{
    ChangedFare = Fare + (Fare * 5 / 100);
    Console.WriteLine("\nfare = {0}", ChangedFare);
}














