Console.WriteLine("enter 000 to quit and display the items");

List<int> List = new List<int>();

do
{
    int element = Convert.ToInt32(Console.ReadLine());
    // if entered element is 000 it will display the array elements and then break the execution
    if(element == 000)
    {
        MyFun();
        break;

    }
    else
    {
        List.Add(element);
    }
}while(true);

void MyFun()
{
   foreach(var i in List)
    {
        Console.WriteLine(i);
    }
    
}