namespace WorkSpace.MathsForDSA;

class PrimeNumber
{
    public static bool IsPrimeNum(int n)
    {
        if (n <= 1)
        {
            return false;
        }

        int c = 2;

        while (c * c <= n)
        {
            if (n % c is 0)
            {
                return false;
            }
            c += 1;
        }

        return true;
    }

    public static void FetchPrrimeNum(int num, bool[] primeArr)
    {
        for (int i = 2; i * i <= num; i++)
        {
            if (!primeArr[i])
            {
                for (int j = i*2; j <= num; j += i)
                {
                    primeArr[j] = true;
                }
            }
        }

        for (int i = 2; i <= num; i++)
        {
            if (!primeArr[i])
            {
                Console.Write($"  {i}");

            }
        }

        Console.WriteLine();
    }
}