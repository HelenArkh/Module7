using System;

namespace Module7
{
    class Program
    {
        static void Main(string[] args)
        {
            Obj obj = new Obj();
            obj.Display(345);

            int num1 = 4;
            int num2 = 10;
            Swap(ref num1, ref num2);

            Console.WriteLine("{0} {1}", num1, num2);

            Console.ReadKey();
        }

        public static void Swap<T>(ref T x, ref T y)
        {
            T t = x;
            x = y;
            y = t;
        }
    }
}
