using Basics;
using System;
using System.Reflection;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        //variable variable = new variable();
        // variable.show();

        //operators operators = new operators();
        //operators.show();

        //condition condition = new condition();
        //condition.show();

        //loops loops = new loops();
        //loops.Show();

        //method method = new method();
        //methos.display();

        //arrays arrays = new arrays();
        //arrays.show();

        //Exceptions exceptions = new Exceptions ();
        //exceptions.show();

        //collections collections = new collections();
        //collections.show();

        //student s1 = new student("rudhra",20);
        //   s1.Display();

        //smartphone phone1 = new smartphone();
        //phone1.brand = "Apple";
        //phone1.name = "iPhone 13";
        //phone1.price = 999;

        //smartphone phone2 = new smartphone();
        //phone2.brand = "Samsung";
        //phone2.name = "Galaxy S21";

        //Console.WriteLine("Phone 1:");
        //Console.WriteLine("Brand: " + phone1.brand);
        //Console.WriteLine(phone2.brand);


        //employee emp1 = new employee();
        //emp1.Id = 1;
        //emp1.FirstName = "Rudhra";
        //emp1.LastName = "Sundar";

        //emp1.display();


        //Employee emp = new Employee();

        //        emp.ShowEmployeeInfo();
        //MathOperations math = new MathOperations();

        //Console.WriteLine(math.Add(10, 20));
        //Console.WriteLine(math.Add(10, 20, 30));

        //Car car = new Car();

        //car.Start();

        //lambda lambda = new lambda();
        //lambda.Hello();

        //linqs linqs = new linqs();
        //linqs.Show();

        // Programs Programs = new Programs();

        //await Programs.Show();

        //int  amount = await Programs.CheckBalance();

        //Console.WriteLine(amount);

        //Programs Programs = new Programs();
        //await Programs.method1();

        //Programs programs = new Programs();
        //await programs.method2();

        //Task task = Task.Run(() =>
        //{
        //    Console.WriteLine("task running");
        //});

        //task.Wait();

        //Task <int> task = Task.Run(() =>
        //{
        //    return 200;
        //});

        //Console.WriteLine( task.Result);

        //Emailservice email = new Emailservice();

        //Userservices user = new Userservices(email);

        //user.Register();


        //Messageservice message = new Messageservice();

        //studentservices student = new studentservices(message);

        //student.Display();

        //{
        //    Employee emp = new Employee(1, "Rudhra");

        //    Console.WriteLine(emp.id);
        //    Console.WriteLine(emp.name);
        //}

        //Type type = typeof(emplo);
        //PropertyInfo[] properties = type.GetProperties();

      


        //foreach (PropertyInfo property in properties)
        //{
        //    Console.WriteLine(property.Name);
        //}




        Type type = typeof(emplo);
        MethodInfo[] methods = type.GetMethods();

        foreach (MethodInfo method in methods) {
            Console.WriteLine(method.Name);

        }

    }
}