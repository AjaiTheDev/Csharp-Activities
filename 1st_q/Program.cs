
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("enter the Limit");
        int Limit = Convert.ToInt32(Console.ReadLine());
        string[] MyArray = new string[Limit];
        string temp;


        for (int i = 0; i < MyArray.Length; i++)
        {

            MyArray[i] = Console.ReadLine();

        }

        Console.WriteLine("\nbefore sorting\n");

        for (int i = 0; i < MyArray.Length; i++)
        {
            Console.WriteLine(MyArray[i]);
        }

        // sorting

        for (int i = 0; i < MyArray.Length; i++)
        {
            for (int j = i + 1; j < MyArray.Length; j++)
            {
                int isGreater = string.Compare(MyArray[i].ToLower(), MyArray[j].ToLower());

                if (isGreater == 1)
                {
                    temp = MyArray[i];
                    MyArray[i] = MyArray[j];
                    MyArray[j] = temp;
                }
            }
        }

        // after sorting
        Console.WriteLine("\nafter sorting\n");
        for (int i = 0; i < MyArray.Length; i++)
        {
            Console.WriteLine(MyArray[i]);
        }


        // reverse sorting
        Console.WriteLine("\nReverse Sorting\n");
        for (int i = MyArray.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(MyArray[i]);
        }
    }
}