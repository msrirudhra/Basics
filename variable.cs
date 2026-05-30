using System;
 class  variable
{
    public void show()
    {
        Console.WriteLine("Enter a name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter a age:");
        int age = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine(name);
        Console.WriteLine(age);
    }
}