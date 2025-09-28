namespace WorkSpace.MathsForDSA
{
    public static class NoOfDigits
    {
        public static int Count(int n, int b)
        {
            var a = (int)Math.Log(n, b) + 1;

            return a;
            
        }
    }
}