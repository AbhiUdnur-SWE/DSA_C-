namespace WorkSpace.MathsForDSA
{
    public static class findPowerValueUsingBit
    {
        public static int FindPowerValue(int bs, int p)
        {
            int ans = 1;

            while (p > 0)
            {
                if ((p & 1) == 1)
                {
                    ans *= bs;
                }

                bs *= bs;
                p >>= 1;
            }

            return ans;
        }
    }
}