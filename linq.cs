using System;
using System.Collections.Generic;
using System.Linq;

class linqs
{
    public void Show()
    {
         
        //where
        List <int> numbers = new List<int>()
        {

          12,  4,5,6,7,8,9
        };

        //var evenNumbers = numbers.Where(x => x % 2 == 0);

        //select

        //var squares = numbers.Select(x => x * x);

        //var result = numbers.OrderBy(x => x);

        //var result = numbers.FirstOrDefault(x => x > 25);


        //foreach (var item in result)
        //{
        //Console.WriteLine(result);
        //}

        //int count = numbers.Count();
        //Console.WriteLine(count);

        bool result = numbers.Any(x => x > 23);
        Console.WriteLine(result);
    }
}