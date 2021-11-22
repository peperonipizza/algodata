using System;

namespace AD
{
    public class Schatzoeker2
    {
        public static int ZoekSchat(char[,] arr, int row, int col)
        {
            // Implement here
            throw new NotImplementedException();
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
