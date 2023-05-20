using System;

namespace PascalTriangleGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalRows;

            while (true)
            {
                Console.Write("Input the total number of rows: ");
                totalRows = int.Parse(Console.ReadLine());

                if (totalRows < 0)
                {
                    Console.WriteLine("Invalid row count for Pascal's triangle. Please try again.");
                }
                else
                {
                    break;
                }
            }

            for (int row = 0; row <= totalRows; row++)
            {
                int currentVal = 1;
                for (int col = 0; col <= row; col++)
                {
                    Console.Write(currentVal + " ");
                    currentVal = currentVal * (row - col) / (col + 1);
                }
                Console.WriteLine();
            }
        }
    }
}
