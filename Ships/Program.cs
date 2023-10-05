using System;
using System.Security.Cryptography.X509Certificates;

namespace Ships
{
    class Program
    {
        public const int ShipCell = 1;
        public const int EmptyCell = 0;

        private static int[,] s_ships = new int[10, 10]
        {
            { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, },
            { 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, },
            { 0, 1, 0, 1, 1, 0, 0, 0, 0, 0, },
            { 0, 1, 0, 1, 1, 0, 0, 1, 1, 1, },
            { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
            { 1, 1, 1, 1, 0, 1, 0, 0, 0, 0, },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
            { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, }
        };

        static void Main(string[] args)
        {
            int count = 0;

            count = CountShips(s_ships);

            Console.WriteLine(count);
            Console.ReadLine();
        }

        public static int CountShips(int[,] field) 
        {
            int shipsCount = 0;
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i, j] == ShipCell && IsNotCounted(field, i, j))
                        shipsCount++;
                }
            }
            return shipsCount;
        }

        public static bool IsNotCounted(int[,] field, int i, int j) => IsEmptyLeft(field, i, j) && IsEmptyTop(field, i, j);

        public static bool IsEmptyLeft(int[,] field, int i, int j) => i <= 0 || field[i - 1, j] == EmptyCell;

        public static bool IsEmptyTop(int[,] field, int i, int j) => j <= 0 || field[i, j - 1] == EmptyCell;


    }
}