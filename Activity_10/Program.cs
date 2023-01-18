int[] BoardingPassArray = new int[10];

int[] CheckInArray1 = new int[3];
int[] CheckInArray2 = new int[3];
int[] CheckInArray3 = new int[3];

Console.WriteLine("enter flight boarding number");

for (int i = 0; i < 10; i++)
{
    BoardingPassArray[i] = Convert.ToInt32(Console.ReadLine());
}
int j = 0;
int k = 0;
int l = 0;
for (int i = 0; i < 10; i++)
{

    if (i < 3)
    {
        if (j < 3)
        {
            CheckInArray1[j] = BoardingPassArray[i];
            j++;
        }

    }
    else if (i is >= 3 and < 6)
    {
        if (k < 3)
        {
            CheckInArray2[k] = BoardingPassArray[i];
            k++;
        }

    }
    else if (i >= 6 && i < 10)
    {
        if (l < 3)
        {
            CheckInArray3[l] = BoardingPassArray[i];
            l++;
        }


    }


}

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("counter 1- {0}", CheckInArray1[i]);
    Console.WriteLine("counter 2- {0}", CheckInArray2[i]);
    Console.WriteLine("counter 3- {0}", CheckInArray3[i]);
}

