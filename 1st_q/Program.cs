
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("enter the limit");
        int limit = Convert.ToInt32(Console.ReadLine());
        string[] array = new string[limit];
        string temp;


        for (int i = 0; i < array.Length; i++)
        {

            array[i] = Console.ReadLine();

        }

        Console.WriteLine("\nbefore sorting\n");

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }

        // sorting

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                int isGreater = string.Compare(array[i].ToLower(), array[j].ToLower());

                if (isGreater == 1)
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }

        // after sorting
        Console.WriteLine("\nafter sorting\n");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }


        // reverse sorting
        Console.WriteLine("\nReverse Sorting\n");
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(array[i]);
        }



    }
}