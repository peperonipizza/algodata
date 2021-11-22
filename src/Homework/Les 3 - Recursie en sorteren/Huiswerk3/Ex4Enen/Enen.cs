namespace AD
{
    public class Opgave4
    {
        public static int Enen(int n)
        {
            int count = 0;
            int[] a = new int[11];
            for (int i = 0; n>0; i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            foreach (int b in a)
            {
                if (b == 1)
                    count++;
            }
            return count;

            /*if (n == 0)
                return 0;
            if (n % 2 == 0)
            {
                return (n / 2) + Enen(n - 1);
            }
            else return (n / 2) + 1 + Enen(n - 1);
*/
        }

        public static void Run()
        {
            for (int i = 0; i < 20; i++)
            {
                System.Console.WriteLine("Enen({0,4}) = {1,2}", i, Enen(i));
            }
            System.Console.WriteLine("Enen(1024) = {0,2}", Enen(1024));
            System.Console.WriteLine();
        }
    }
}
