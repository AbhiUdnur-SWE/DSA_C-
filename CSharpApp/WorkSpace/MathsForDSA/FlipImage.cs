namespace WorkSpace.MathsForDSA
{
    public static class FlipImage
    {
        public static int[][] Flip(int[][] image)
        {
            foreach (var row in image)
            {
                for (int i = 0; i < ((image[0].Length + 1) / 2); i++)
                {
                    int temp = row[i] ^ 1;
                    row[i] = row[image[0].Length - 1 - i] ^ 1;
                    row[image[0].Length - 1 - i] = temp;
                }
            }
            
            return image;
        }
    }
}