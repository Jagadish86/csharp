using System;

namespace Generics
{
    using Class.Extension;
    using System.IO;
    using System.Text;

    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyCollection<string> strCollection = new MyCollection<string>();
            Console.WriteLine(strCollection.GetT("Generic List"));

            MyCollection<int> intCollection = new MyCollection<int>();
            Console.WriteLine(intCollection.GetT(12345));

            var numbers = (1, 2, 3, 4, 5);

            Console.WriteLine("numbers.Item5: " + numbers.Item5);
            MyDelegate del = MethodA;

            Func<int, int> funcPrint = (x) => x + 10;

            Console.WriteLine(funcPrint(100));

            Action<int> printNumber = (x) => Console.WriteLine(x);

            printNumber(104200);

            Predicate<int> predicate = x => x < 10;

            Console.WriteLine(predicate(11));

            del("i am a delegate");

            int i = 101;
            Console.WriteLine(i.IsGreaterThan100() ? "Greater" : "Lesser");

            string path = @"F:\Projects\CSharp.Concepts\Generics\FileSystem\abc.txt";
            string movePath = @"F:\Projects\CSharp.Concepts\Generics\abc.txt";
            string destinationPath = @"F:\Projects\CSharp.Concepts\Generics\FileSystem\def.txt";

            StringBuilder sb = new StringBuilder();
            sb.Append("C# includes static File class to perform I/O operation on physical file system. The static File class includes various utility" +
                " method to interact with physical file of any type e.g. binary, text etc. Use this static File class to perform some quick operation on physical file.It is not recommended to use File class for multiple operations on multiple files at the same time due to performance reasons.Use FileInfo class in that scenario.");

            if (!File.Exists(path))
            {
                File.AppendAllText(path, sb.ToString());
            }
            else
            {
                File.WriteAllText(path, "This is dummy text");
                File.AppendAllText(path, "\nThis is File testing");
            }

            //File.Copy(path, destinationPath);
            File.Move(path, movePath);
            //File.Move(@"C:\DummyFile.txt", @"D:\DummyFile.txt");

            MyException my = new MyException();
            Console.WriteLine(my.GetException());
        }

        // target method
        static void MethodA(string message)
        {
            Console.WriteLine(message);
        }
    }

    public delegate void MyDelegate(string msg);

    class MyCollection<Y>
    {
        private Y varCollection;

        public Y GetT(Y v)
        {
            varCollection = v;
            return varCollection;
        }
    }

    class MyException : BaseException
    {

    }

    abstract class BaseException : Exception
    {

        public string GetException()
        {
            return "Hello Exception";
        }
    }
}

namespace Class.Extension
{
    public static class ExtensionClass
    {
        public static bool IsGreaterThan100(this int i)
        {
            return i > 100;
        }
    }
    
}
