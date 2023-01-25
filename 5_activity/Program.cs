double[] Arr = new double[10];
double[] Arr2 = new double[50];
for (int i = 0; i < Arr.Length; i++)
{
    Arr[i] = Convert.ToDouble(Console.ReadLine());
}
int j = -1;
for (int i = 0; i < Arr.Length; i++)
{
    if ((int)Arr[i] % 2 != 0)
    {
        j += 2;
        Arr2[j] = Arr[i];
    }
}
int p = 0;
for (int i = 0; i < Arr.Length; i++)
{
    if ((int)Arr[i] % 2 == 0)
    {
        p += 2;
        Arr2[p] = Arr[i];
    }
}
foreach (var item in Arr2)
{
    Console.WriteLine(item);
}

