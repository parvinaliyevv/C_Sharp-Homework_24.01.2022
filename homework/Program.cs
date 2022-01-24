using System;

namespace homework
{
    internal class Program
    {
        public delegate void Func(string data);

        public static void Main()
        {
            Console.Write("Enter string: ");
            var str = Console.ReadLine();

            MyClass cls = new MyClass(str);

            Func funcDell = new Func(cls.Space);
            funcDell += cls.Reverse;

            Run run = new Run();
            run.RunFunc(funcDell, str);
        }
    }
}
