

using Microsoft.VisualBasic;




Console.WriteLine("1.sorting");
Console.WriteLine("2.reverse sorting");
Console.WriteLine("3.search");
Console.WriteLine("4.minimum Fare");
Console.WriteLine("5.maximum Fare");
Console.WriteLine("6.duplicate");
Console.WriteLine("7.exit");

double[] array = new double[3];
double temp = 0;

Console.WriteLine("enter the elements\n");

for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToDouble(Console.ReadLine());


}
// sorting

for (int i = 0; i < array.Length; i++)
{
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[j] < array[i])
        {
            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
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
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }

}
void RevSortingFun()
{
    for (int i = array.Length - 1; i >= 0; i--)
    {
        Console.WriteLine(array[i]);
    }
}

void SearchFun()
{
    Console.WriteLine("\n enter the search element");
    double searchVal = Convert.ToDouble(Console.ReadLine());
    int count = 0;
    foreach (var item in array)
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
    Console.WriteLine("minimum value = {0}", array[0]);
}

void MaximumVal()
{
    Console.WriteLine("maximum value = {0}", array[(array.Length) - 1]);
}

void Duplicate()
{

    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] == array[i])
            {
                Console.WriteLine($"{array[i]} at position {i} and {j}");

            }

        }
    }

}

void Exit()
{
    m = false;
}
