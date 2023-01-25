

using Microsoft.VisualBasic;




Console.WriteLine("1.sorting");
Console.WriteLine("2.reverse sorting");
Console.WriteLine("3.search");
Console.WriteLine("4.minimum Fare");
Console.WriteLine("5.maximum Fare");
Console.WriteLine("6.duplicate");
Console.WriteLine("7.exit");

double[] MyArray = new double[10];
double Temp = 0;

Console.WriteLine("enter the elements\n");

for (int i = 0; i < 10; i++)
{
    MyArray[i] = Convert.ToDouble(Console.ReadLine());


}
// sorting

for (int i = 0; i < MyArray.Length; i++)
{
    for (int j = i + 1; j < MyArray.Length; j++)
    {
        if (MyArray[j] < MyArray[i])
        {
            Temp = MyArray[i];
            MyArray[i] = MyArray[j];
            MyArray[j] = Temp;
        }
    }
}
bool m = true;
do
{
    Console.WriteLine("\n enter the function");
    int element = Convert.ToInt32(Console.ReadLine());
    switch (element)
    {
        case 1:
            SortingFun();
            break;
        case 2:
            RevSortingFun();
            break;
        case 3:
            SearchFun();
            break;
        case 4:
            MinimumVal();
            break;
        case 5:
            MaximumVal();
            break;
        case 6:
            Duplicate();
            break;
        default:
            Exit();
            break;
    }
} while (m);

void SortingFun()
{

    // after sorting
    Console.WriteLine("\nafter sorting\n");
    for (int i = 0; i < MyArray.Length; i++)
    {
        Console.WriteLine(MyArray[i]);
    }

}
void RevSortingFun()
{
    for (int i = MyArray.Length - 1; i >= 0; i--)
    {
        Console.WriteLine(MyArray[i]);
    }
}

void SearchFun()
{
    Console.WriteLine("\n enter the search element");
    double searchVal = Convert.ToDouble(Console.ReadLine());
    int count = 0;
    foreach (var item in MyArray)
    {
        if (item == searchVal)
        {
            count++;
        }
    }
    if (count > 0)
    {
        Console.WriteLine($"{searchVal} found {count} times");
    }
    else
    {
        Console.WriteLine("sorry not found");
    }
}

void MinimumVal()
{
    Console.WriteLine("minimum value = {0}", MyArray[0]);
}

void MaximumVal()
{
    Console.WriteLine("maximum value = {0}", MyArray[(MyArray.Length) - 1]);
}

void Duplicate()
{

    for (int i = 0; i < MyArray.Length; i++)
    {
        for (int j = i + 1; j < MyArray.Length; j++)
        {
            if (MyArray[j] == MyArray[i])
            {
                Console.WriteLine($"{MyArray[i]} at position {i} and {j}");

            }

        }
    }

}

void Exit()
{
    m = false;
}
