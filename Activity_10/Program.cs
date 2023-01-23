Console.WriteLine("enter the limit");
int limit = Convert.ToInt32(Console.ReadLine());

int[] BoardingPassArray = new int[limit];

int[] CheckInArray1 = new int[3];
int[] CheckInArray2 = new int[3];
int[] CheckInArray3 = new int[3];

//int remaining = 0;
//var remainArr = new int[];

var remainArr = new List<int>();

Random random = new Random();

int intex = random.Next(1, 3);

Console.WriteLine("enter flight boarding number");

for (int i = 0; i < limit; i++)
{
    BoardingPassArray[i] = Convert.ToInt32(Console.ReadLine());
}
int j = 0;
int k = 0;
int l = 0;

for (int i = 0; i < limit; i++)
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
    else if (i >= 6 && i < 9)
    {
        if (l < 3)
        {
            CheckInArray3[l] = BoardingPassArray[i];
            l++;
        }
    }
    else if(i >= 9)
    {
        remainArr.Add(BoardingPassArray[i]);
    }
}






Console.WriteLine("\nbefore");
Display();

void Display()
{

    foreach (var item in CheckInArray1)
    {
        Console.WriteLine("counter 1 - {0}", item);
    }
    foreach (var item in CheckInArray2)
    {
        Console.WriteLine("counter 2 - {0}", item);
    }
    foreach (var item in CheckInArray3)
    {
        Console.WriteLine("counter 3 - {0}", item);
    }
   

}


foreach (var item in remainArr)
{
    int myRandom = random.Next(1, 3);
    if (myRandom > 0)
    {

        if (myRandom == 1)
        {
            CheckInArray1[0] = CheckInArray1[1];
            CheckInArray1[1] = CheckInArray1[2];
            CheckInArray1[2] = item;

        }
        else if (myRandom == 2)
        {
            CheckInArray2[0] = CheckInArray2[1];
            CheckInArray2[1] = CheckInArray2[2];
            CheckInArray2[2] = item;

        }
        else if (myRandom == 3)
        {
            CheckInArray3[0] = CheckInArray3[1];
            CheckInArray3[1] = CheckInArray3[2];
            CheckInArray3[2] = item;

        }
    }
    Console.WriteLine("\nAfter");
    Display();

}














