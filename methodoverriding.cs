using System;

class Vehicle
{
    public virtual void Start()
    {
        Console.WriteLine("Vehicle Started");
    }
}

class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Car Started");
    }
}
