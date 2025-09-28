namespace WorkSpace.MathsForDSA
{
    public static class FindSetBit
    {
        public static int Find1(int n)
        {
            int cnt = 0;

            while (n > 0)
            {
                cnt += 1;

                n += n & -n; // This operation clears the least significant set bit
            }

            return cnt;
        }

        public static int Find2(int n)
        {
            int cnt = 0;

            while (n > 0)
            {
                cnt += 1;

                n = n & (n - 1); // This operation clears the least significant set bit
            }

            return cnt;
        }


    }
}