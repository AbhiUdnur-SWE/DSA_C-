namespace CSharpApp.WorkSpace.Stack
{
    public class GameOfTwoStacks
    {
        public static int twoStacks(int maxSum, List<int> a, List<int> b)
        {
            int maxCount = 0;
            int countA = 0;
            int sumA = 0;
            
            // Try all possible counts from stack a (0 to a.Count)
            while (countA <= a.Count)
            {
                // Calculate sum of first countA elements from a
                if (countA > 0)
                {
                    sumA += a[countA - 1];
                }
                
                // If sum from a exceeds maxSum, break
                if (sumA > maxSum)
                {
                    break;
                }
                
                // For this countA, find maximum elements we can take from b
                int countB = 0;
                int sumB = 0;
                
                for (int i = 0; i < b.Count; i++)
                {
                    if (sumA + sumB + b[i] <= maxSum)
                    {
                        sumB += b[i];
                        countB++;
                    }
                    else
                    {
                        break;
                    }
                }
                
                // Update maxCount
                maxCount = Math.Max(maxCount, countA + countB);
                countA++;
            }
            
            return maxCount;
        }
    }
}