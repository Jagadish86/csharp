using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            bool present = false;
            switch (present)
            {
                case false:
                    Console.WriteLine("None is present");
                    break;

                case true:
                    break;
            }

            //for (; ; )
            //{
            //    Console.Write(1);
            //}

            int i = 0; // initialization

            while (i < 10) // condition
            {
                Console.WriteLine("i = {0}", i);

                i++; // increment
            }
        }
    }
}
