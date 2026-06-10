  //public student()
    //{
    //    Console.WriteLine("Constructor is called");

    //}
    
    //public string Name;
    // public int Age;

    //public student(string name,int age)

    //{ 
    //    Name = name;
    //    Age = age;

    //}

    //public void Display()
    //{
    //    Console.WriteLine("Name: " + Name);
    //    Console.WriteLine("Age: " + Age);
    //}     

    
using System;

class Person
{
    public string Name = "Rudhra";

    public void Display()
    {
        Console.WriteLine("Name: " + Name);
    }
}

    class Employee : Person
    {
        public int EmployeeId = 123;
        public void ShowEmployeeInfo()
        {
            Console.WriteLine("Employee ID: " + EmployeeId);
            Console.WriteLine("Employee Name: " + Name); 
        }
}

