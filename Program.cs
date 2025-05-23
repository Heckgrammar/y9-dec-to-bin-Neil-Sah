using System;

namespace Y9_DEC_TO_BIN_SKELETON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            numberConversion();            
        }
        static string numberConversion()
        {
            Console.Write("Enter an integer: ");
            int myInt = int.Parse(Console.ReadLine());
    
            string binary = Convert.ToString(myInt, 2);
            
            Console.WriteLine($"Binary equivalent: {binary}");

            return binary;
        }
    }
}
