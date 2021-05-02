using System;

namespace Pascal_s_Triangle_Maker
{
    class Program
    {
        public static void Main()
        {
            int row;
            row = int.Parse(Console.ReadLine());
            while (row < 0)
            {
                Console.WriteLine("Invalid Pascal’s triangle row number.");
                row = int.Parse(Console.ReadLine());
            }
            MakePTriangle(row);
        }

        public static void MakePTriangle(int row)
        {
            for (int amount = 1;
                    amount <= row; amount++)
            {

                int C = 1;
                for (int i = 1; i <= amount; i++)
                {
                    Console.Write(C + " ");
                    C = C * (amount - i) / i;
                }
                Console.WriteLine();
            }
        }
    }
}

