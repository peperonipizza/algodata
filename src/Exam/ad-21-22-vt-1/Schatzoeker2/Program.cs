using System;

namespace AD
{
    public class Schatzoeker2
    {
        public static int ZoekSchat(char[,] arr, int row, int col)
        {
            // Implement here
            char c = arr[row, col];
            if (c == 'X') return 0;
            if (c == '@')
            {
                return ZoekSchat(arr, row + 1, col) + 1;
            }
            return ZoekSchat(arr, row, (col + 1) % 5) + 1;
        }

        static void Main(string[] args)
        {
            char[,] arr1 =
            {
                {'.', '@', '.', '.', '.' },
                {'.', '.', '.', '@', '.' },
                {'.', 'X', '.', '.', '.' },
                {'.', '.', '.', '.', '.' },
                {'.', '.', '.', '.', '.' },
            };
            char[,] arr2 =
            {
                {'@', '.', '.', '.', '.' },
                {'.', '.', '.', '@', '.' },
                {'.', '.', '.', '@', '.' },
                {'@', '.', '.', '.', '.' },
                {'.', 'X', '.', '.', '.' },
            };
            Console.WriteLine(ZoekSchat(arr1, 0, 2));
            Console.WriteLine(ZoekSchat(arr2, 0, 3));
        }
    }
}
