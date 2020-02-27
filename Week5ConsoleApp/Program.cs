using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello();
            SayGoodbye();
            string name = " something";
            SayHelloTo(name);
            SayGoodbyeTo(name);

            int left = 25;
            int right = 99;
            int middle = Sum(25, 99);
            Console.WriteLine("left = " + left) ;
            Console.WriteLine("right = " + right);
            Console.WriteLine("middle = " + middle);
            Console.WriteLine("Output of sum= " + middle);

            string phrase = "How is your day";

           
           
        }


        public static void SayHello()
        {
            Console.WriteLine("Hello");
        }


        public static void SayGoodbye()
        {
            Console.WriteLine("Goodbye");

        }

        public static void SayHelloTo(string name)
        {
            Console.WriteLine("Hello" + name);
        }


        public static void SayGoodbyeTo(string name)
        {
            Console.WriteLine("Goodbye" + name);
        }

        public static int Sum(int left, int right)
        {
            return left + right;
            
        }

        public static int Countspaces(string phrase)
        {
            


            int count = 0;           
            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase[i].Equals (""))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
