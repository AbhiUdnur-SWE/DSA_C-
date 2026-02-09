namespace CSharpApp.WorkSpace.Stack
{
    class ValidParanthesis
    {
        public static bool IsValid(string s)
        {
            Stack<char> stack = [];

            if (string.IsNullOrEmpty(s))
            {
                return true;
            }

            if (s.ToCharArray().Length % 2 != 0)
            {
                return false;
            }

            foreach (char ch in s)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    stack.Push(ch);
                }

                else
                {
                    if (stack.Count == 0)
                        return false;

                    if (!IsMatch(stack.Pop(), ch))
                        return false;
                }
            }

            return stack.Count == 0;
        }

        private static bool IsMatch(char ch1, char ch2)
        {
            return
            (
                (ch1 == '(' && ch2 == ')') ||
                (ch1 == '{' && ch2 == '}') ||
                (ch1 == '[') && ch2 == ']'
            );
        }
    }
}