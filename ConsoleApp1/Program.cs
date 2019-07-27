using System;
using System.Collections;


namespace ConsoleApp1
{
    class Rectangle
    {
        double length;
        double width;
        public void AcceptDetails()
        {
            length = 4.5;
            width = 3.5;

        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine($"legth: {length}");
            Console.WriteLine($"width: {width}");
            Console.WriteLine("area: {0}", GetArea());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            Console.WriteLine("Hello World!");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine($"a is {a}");

            ArrayList al = new ArrayList();

            Console.WriteLine("Adding some numbers:");
            al.Add(45);
            al.Add(78);
            al.Add(33);
            al.Add(56);
            al.Add(12);
            al.Add(23);
            al.Add(9);

            Console.WriteLine("Capacity: {0} ", al.Capacity);
            Console.WriteLine("Count: {0}", al.Count);

            Console.Write("Content: ");
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.Write("Sorted Content: ");
            al.Sort();
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            var nemes = new ArrayList { "java", "c", "c#"};
            foreach (var name in nemes)
            {
                Console.WriteLine($"name is {name}");
            }

            Rectangle r = new Rectangle();
            r.AcceptDetails();
            r.Display();
            
            //nullable
            int? num1 = null;
            int? num2 = 45;
            double? num3 = new double?();
            double? num4 = 3.14157;
         
            bool? boolval = new bool?();

            // 显示值
         
            Console.WriteLine("显示可空类型的值： {0}, {1}, {2}, {3}", 
                            num1, num2, num3, num4);
            Console.WriteLine("一个可空的布尔值： {0}", boolval);

            //array
            Console.WriteLine("Array: ");
            int[] list = { 34, 72, 13, 44, 25, 30, 10 };

            Console.Write("原始数组： ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // 逆转数组
            Array.Reverse(list);
            Console.Write("逆转数组： ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // 排序数组
            Array.Sort(list);
            Console.Write("排序数组： ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
