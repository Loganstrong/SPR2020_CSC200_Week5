using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Week6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 25;
            int b = 23;

            Console.WriteLine("a: {0},b: {1}", a, b);
            Swap(ref a, ref b);
            Console.WriteLine("a: {0},b: {1}", a, b);

            Zero(out a);
            Console.WriteLine("a:{0}", a);

            Foo(ref a);
            Console.WriteLine(a);
            //
            MyValue myValue = new MyValue();
            myValue.A = 25;
            Foo(myValue);
            Console.WriteLine(myValue.A);

            Zero(out a);
            Console.WriteLine("a:{0}", a);


            // Extract year, month, and day from a date 


            
            int year;
            int month;
            int day;
            

            Extract(DateTime.Today, out year, out month, out day);
            Console.WriteLine("year:{0},month:{1},day: {2}", year, month, day);
            

        }




        private static void Extract(DateTime date, out int year, out int month, out int day)
        {
            year = date.Year;
            month = date.Month;
            day = date.Day;
            
        }

        private static void Zero(out int a)
        {
            a = 0;
            
        }
        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
            
           
           
        }

        static void Foo(int a)
        {
            a = a * 25;
        }

        static void Foo(MyValue myValue)
        {
            myValue.A = myValue.A * 25;
        }


        static void Foo( ref int a)
        {
            a = a * 25;
        }

    internal class MyValue
    {
            public int A { get; set; }

    }

        
    }
}
