namespace CSharpApp.WorkSpace.Stack
{
    public class GameOfTwoStacks
    {

        // FYI, you can also solve this using prefix sum

        /* 
            [4,2,4,6,1] // input    
            [2,1,8,5]   // input

            a = [0,4,6,10,16,17]
            b= [0,2,3,11,16]

            i = 0
            j = b.len - 1
            ans = 0

            while(i < a.len && j >= 0)
            {
                if(a[i] + b[j] > max):j-=1
                else: 
                    ans = max(ans, i+j)
                    i+=1
            }
        */
        public static int twoStacks(int maxSum, List<int> a, List<int> b)
        {
            int countA = 0;
            int sumA = 0;
            int maxCount = 0;

            while (countA <= a.Count)
            {
                int sumB = 0;
                int countB = 0;

                if (countA > 0) sumA += a[countA - 1];

                if (sumA > maxSum) break;

                for (int i = 0; i < b.Count; i++)
                {
                    if (sumA + sumB + b[i] <= maxSum)
                    {
                        sumB += b[i];
                        countB += 1;
                    }
                    else break;
                }
                maxCount = Math.Max(maxCount, countA + countB);
                countA += 1;
            }
            
            return maxCount;
        }
    }
}