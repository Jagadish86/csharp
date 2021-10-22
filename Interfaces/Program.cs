using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = new string[] { "Mumbai", "London", "New York", "" };
            Console.WriteLine(cities[0]);

            int[,] arr2d = new int[3, 2]{
                                {1, 2},
                                {3, 4},
                                {5, 6}
                            };

            int[][] jArray = new int[2][];

            jArray[0] = new int[3] { 1, 2, 3 };

            jArray[1] = new int[4] { 4, 5, 6, 7 };

            Console.WriteLine("Hello World!");

            IFile fileInfo = new FileInfo();

            fileInfo.ReadFile();
            fileInfo.WriteFile("Writing the file");

            IFile tfile = new test();
            test tfile1 = new test();
            tfile.ReadFile();
            tfile1.ReadFile();


        }
    }

    class test : IFile
    {
        public void ReadFile()
        {
            Console.WriteLine("Reading the file");
        }

        void IFile.WriteFile(string text)
        {
            throw new NotImplementedException();
        }
    }

    class FileInfo : IFile
    {
        public void ReadFile()
        {
            Console.WriteLine("Reading the file");
        }

        public void WriteFile(string text)
        {
            Console.WriteLine(text);
        }
    }

    interface IFile
    {
        void ReadFile();
        void WriteFile(string text);
    }
}
