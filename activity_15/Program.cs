int weightDiff;

string[] BoardPass = new string[3];
int[] Weight = new int[3];
int[] WeightDIffArray = new int[Weight.Length];

for (int i = 0;i < BoardPass.Length; i++)
{
    Console.WriteLine("enter your name");
    string name = Console.ReadLine();
    BoardPass[i] = name;
    Console.WriteLine("weigth");
    int weightElement = Convert.ToInt32(Console.ReadLine());
    Weight[i] = weightElement;
    

}

Console.WriteLine("\n");
for (int i = 0;i < BoardPass.Length; i++)
{
    
    Console.WriteLine("name-{0}", BoardPass[i]);
    Console.WriteLine("Weight-{0}kg", Weight[i]);
    Console.WriteLine($"weigth charge {weightFun(Weight[i])}$");
    WeightDIffArray[i] = weightFun(Weight[i]);
    Console.WriteLine("\n");
}

int weightFun(int Weight)
{
    int weightDiffInFun = (Weight - 23);
    if(weightDiffInFun > 0)
    {
        return (20 +(weightDiffInFun * 15));
    }
    else
    {
        return 20;
    }
}

Console.WriteLine("Descending Overweight fare");
Array.Sort(WeightDIffArray);
for (int i = (WeightDIffArray.Length - 1);i >= 0; i--)
{
    Console.WriteLine($"{WeightDIffArray[i]}$");
}
