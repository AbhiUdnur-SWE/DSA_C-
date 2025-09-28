namespace WorkSpace.MathsForDSA
{
    public static class FindUnique
    {
        public static int Find(int[] arr)
        {
            int unique = 0;
            foreach (int num in arr)
            {
               unique ^= num; // XOR operation to find the unique element
            }
            return unique;
        }
    }
}