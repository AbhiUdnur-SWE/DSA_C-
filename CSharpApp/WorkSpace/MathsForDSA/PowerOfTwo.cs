namespace WorkSpace.MathsForDSA
{
    public static class PowerOfTwo
    {
        public static bool IsPowerOfTwo(int n)
        {
            if (n <= 0)
            {
                return false;
            }
            return (n & (n - 1)) == 0;
        }
    }
}