using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入x和y（例如12,15）,然后按回车键：");
            string s = Console.ReadLine();
            string[] a = s.Split(',');
            int x = int.Parse(a[0]);
            int y = int.Parse(a[1]);
            int z = ClassLibraryExample.MyClass.Multiplication(x, y);
            Console.WriteLine("x*y={0}", z);
            Console.WriteLine("请按任意键结束程序。");
            Console.ReadKey();
        }
    }
}
