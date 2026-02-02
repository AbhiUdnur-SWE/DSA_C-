using System;
using System.Collections.Generic;

namespace CSharpApp.WorkSpace.Stack
{
    public class LargestHistogram
    {
        public static int CalcLargestHistogram(int[] heights)
        {
            int max = 0;
            Stack<(int index, int heaight)> stack = [];

            for (int i = 0; i < heights.Length; i++)
            {
                int start = i;
                while (stack.Count != 0 && stack.Peek().heaight > heights[i])
                {
                    var (index, heaight) = stack.Pop();
                    max = Math.Max(max, heaight * (i - index));

                    start = index;
                }

                stack.Push((start, heights[i]));
            }

            while (stack.Count!= 0)
            {
                var val = stack.Pop();

                max = Math.Max(max, val.heaight * (heights.Length - val.index));
            }
            return max;
        }


    }
}