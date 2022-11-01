using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] myArray = { 'H', 'e', 'l', 'l', 'o' };
            foreach (char ch in myArray)
            {
                Console.WriteLine(ch);
            }
            Console.ReadLine();
        }
    }
}