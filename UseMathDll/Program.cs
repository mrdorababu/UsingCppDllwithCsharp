using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace UseMathDll
{
    
    class Program
    {
        [DllImport("CppMathDll", CallingConvention = CallingConvention.Cdecl)]

        private static extern double Add(double a, double b);

        static void Main(string[] args)
        {
            double num1;
            double num2;
            double result = 0;
            Console.Write("Enter 1st number : ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter 2nd number : ");
            num2 = Convert.ToDouble(Console.ReadLine());
            result = Add(num1, num2);
            Console.WriteLine("The sum of {0} + {1} = {2}  ",num1,num2,result);
            Console.ReadLine();
        }
    }
}
