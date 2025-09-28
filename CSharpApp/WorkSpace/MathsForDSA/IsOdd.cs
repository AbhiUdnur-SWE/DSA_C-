namespace WorkSpace.MathsForDSA
{
    public static class IsOdd
    {
        public static bool Check(int number)
        {
            return (number & 1) == 1;
        }
    }
}