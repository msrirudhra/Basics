using System;
class employee
{
    private int id;
    private string firstName;
    private string lastName;


    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string FirstName
    {
        get { return firstName; }

        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }

    }

    public void display()
    {

        Console.WriteLine("Employee ID: " + Id);
        Console.WriteLine("Employee First Name: " + FirstName);
    }

}