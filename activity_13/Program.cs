Console.WriteLine("enter 000 to quit and display the items");

List<int> list = new List<int>();

do
{
    int element = Convert.ToInt32(Console.ReadLine());

    if(element == 000)
    {
        myFun();
        break;

    }
    else
    {
        list.Add(element);
    }
}while(true);

void myFun()
{
   foreach(var i in list)
    {
        Console.WriteLine(i);
    }
    
}