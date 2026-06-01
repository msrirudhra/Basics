using System;
class student
{
    //public student()
    //{
    //    Console.WriteLine("Constructor is called");

    //}
    
    public string Name;
     public int Age;

    public student(string name,int age)

    { 
        Name = name;
        Age = age;

    }

    public void Display()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }     

    
}