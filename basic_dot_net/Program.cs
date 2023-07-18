namespace HelloWord
{
    class Program
    {
        static void Main(string[] args)
        {

            // object
            Employee em = new Employee("Ram", "Bahadur", 20000);

            Console.WriteLine($"name:{em.FirstName} {em.LastName} and salary is : {em.Salary}");

            Employee em1 = new Employee("Hari", "", 500);

            Console.WriteLine($"name:{em1.FirstName} and salary is : {em1.Salary}");



            // printing a line
            // Console.WriteLine("What is your name?");
            // reading a line form the user
            // var name = Console.ReadLine();

            // var currentDate = DateTime.Now;

            // string interpolation
            // Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            // Console.Write($"{Environment.NewLine}Press any key to exit...");

            // holding a key for termination
            // Console.ReadKey(true);


            // Data type 
            // int, short , long, char, string, bool, float, decimal, double, object
            // int number = 30;
            // Console.WriteLine($"this is number: {number}");
            // double pointNum = 5.5;
            // Console.WriteLine($"this is floating: {pointNum}");
            // char latters = 'T';
            // Console.WriteLine($"this is char: {latters}");
            // bool boolType = true;
            // Console.WriteLine($"this is bool: {boolType}");
            // string nameD = "didi";
            // Console.WriteLine($"this is string: {nameD}");

            // opertor are same as other

            //condition are same as other too

            // switch is same as other


            // loop is same as other

            // Array

            // int[] arr = { 2, 3, 5, 3, 45, 3634 };


            // function

            // static void testFunction()
            // {
            //     Console.WriteLine("This is f1 function");
            // }

            // creating an object
            //         Point p = new Point(2, 5);
            //         p.X = 50;
            //         p.Y = 90;
            //         p.show();

            //         Console.WriteLine("x:" + p.X);

            //     }
        }

        // // oop

        // class Point
        // {
        //     private int x;
        //     private int y;
        //     public int X
        //     {
        //         get { return x; }
        //         set { x = value; }
        //     }

        //     public int Y
        //     {
        //         get { return y; }
        //         set { y = value; }

        //     }


        //     public Point(int x, int y)
        //     {

        //         this.X = x;
        //         this.Y = y;
        //     }



        //     public void show()
        //     {
        //         Console.WriteLine("This is show function of class pioint");
        //         Console.WriteLine($"a:{x}");
        //         Console.WriteLine($"a:{y}");
        //     }


    }



}