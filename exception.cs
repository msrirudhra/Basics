using System;
class Exceptions
{
    public void show()
    {
        try
        {

            ////int a = 10, b = 1;
            ////int c = a / b;
            //Console.WriteLine(c);

            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("number:" + num);

       }
        catch
        {
            Console.WriteLine("error");
        }


        //catch(Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
     
        //} 

        finally
        {
            Console.WriteLine("finally block");
        }
    }
}