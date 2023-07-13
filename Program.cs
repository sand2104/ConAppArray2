using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppArray2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] myRectArray = new string[4, 3];
            for (int i = 0; i < myRectArray.GetLength(0); i++)
            {
                for (int j = 0; j < myRectArray.GetLength(1); j++)
                {
                    myRectArray[i, j] = "[" + i + "," + j + "]";
                }
            }
            Console.WriteLine("Stored Values are:");
            for (int i = 0; i < myRectArray.GetLength(0); i++)
            {
                for (int j = 0; j < myRectArray.GetLength(1); j++)
                {
                    Console.WriteLine(myRectArray[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
