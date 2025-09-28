namespace WorkSpace.MathsForDSA
{
    public static class SquareRoot
    {
        public static void Find(int n, int? p = null)
        {
            int s = 0;
            int e = n;

            double root = 0.0;


            while (s <= e)
            {
                int mid = (s + e) / 2;

                if (mid * mid == n)
                {
                    Console.WriteLine(mid);
                    return;
                }

                if (mid * mid > n)
                {
                    e = mid - 1;
                }
                else
                {
                    s = mid + 1;
                }
            }

            if (p is not null)
            {
                double incr = 0.1;

                for (int i = 0; i < p; i++)
                {
                    while (root * root <= n)
                    {
                        root += incr;
                    }

                    root -= incr;
                    incr /= 10;
                }                
                Console.WriteLine($"{root:F3}");
            }

        }
    }
}