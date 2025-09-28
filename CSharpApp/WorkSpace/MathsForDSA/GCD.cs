namespace WorkSpace.MathsForDSA
{
    public static class GCD
    {
        public static int Euclidian(int a, int b)
        {
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            if (a == 0)
            {
                return b;
            }

            return Euclidian(b % a, a);
        }
    }
}