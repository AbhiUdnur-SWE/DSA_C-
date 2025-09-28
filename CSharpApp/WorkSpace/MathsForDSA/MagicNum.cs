namespace WorkSpace.MathsForDSA
{
    public static class MagicNum
    {
        public static int Find(int n)
        {
            int bs = 5;
            int ans = 0;
            while (n > 0)
            {
                int lastBit = n & 1;
                ans += lastBit * bs;
                bs *= 5;
                n >>= 1;
            }

            return ans;
        }
    }
}