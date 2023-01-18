

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
            sortingFun();
            break;
        case 2:
            revSortingFun();
            break;
        case 3:
            searchFun();
            break;
        case 4:
            minimumVal();
            break;
        case 5:
            maximumVal();
            break;
        case 6:
            duplicate();
            break;
        default:
            exit();
            break;
    }
} while (m);

void sortingFun()
{

    // after sorting
    Console.WriteLine("\nafter sorting\n");
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }

}
void revSortingFun()
{
    for (int i = array.Length - 1; i >= 0; i--)
    {
        Console.WriteLine(array[i]);
    }
}

void searchFun()
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

void minimumVal()
{
    Console.WriteLine("minimum value = {0}", array[0]);
}

void maximumVal()
{
    Console.WriteLine("maximum value = {0}", array[(array.Length) - 1]);
}

void duplicate()
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

void exit()
{
    m = false;
}
