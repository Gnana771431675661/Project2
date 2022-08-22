using System;
using System.Text;

namespace convert_float_to_int
{
    class Program
    {
        static void Main(string[] args)
        {
            float n;
            Console.WriteLine("Enter Float value: ");
            n = float.Parse(Console.ReadLine());
            int i = (int)n;
            Console.WriteLine("Converted float {0} to int {1}", n, i);

        }
    }
}
