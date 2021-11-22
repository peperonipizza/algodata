using System;

namespace AD
{
    public static class BracketChecker
    {

        /// <summary>
        ///    Run over all characters in a string, push all '(' characters
        ///    found on a stack. When ')' is found, it shoud match a '(' on
        ///    the stack, which is then popped.
        ///
        ///    If ')' is found when no '(' is on the stack, this method will
        ///    terminate prematurely, no further inspection is needed.
        /// </summary>
        /// <param name="s">The string to check</param>
        /// <returns>Returns True if all '(' are matched by ')'.
        /// Returns False otherwise.</returns>
        public static bool CheckBrackets(string s)
        {
            int count = 0;
            MyStack<char> stack = new MyStack<char>();
            foreach(char c in s)
            {
                if (c == '(')
                {
                    count++; 
                    stack.Push(c);
                }
                if (c == ')')
                {
                    count--;
                    if (stack.IsEmpty())
                        return false;
                    stack.Pop(); 
                }
            }
            if (count < 0 || count > 0)
                return false;
            else
                return true;
        }


        /// <summary>
        ///    Run over all characters in a string, when an opening bracket is
		///    found the closing counterpart from closeChar is pushed on a Stack
        ///    When an closing bracket is found, it should match the top character
		///    from this stack.
		///    
        ///    This method will terminate prematurely if a wrong or missmatched
        ///    closing bracket is found and no further inspection is needed.
		/// </summary>
		/// <param name="s">The string to check</param>
		/// <returns>Returns True if all opening brackets are matched by
		/// it's correct counterpart in a correct order.
        /// Returns False otherwise.</returns>
        public static bool CheckBrackets2(string s)
        {
            int count = 0;
            MyStack<char> stack1 = new MyStack<char>();
            MyStack<char> stack2 = new MyStack<char>();
            MyStack<char> stack3 = new MyStack<char>();
            foreach (char c in s)
            {
                if (c == '(')
                {
                    count++;
                    stack1.Push(c);
                }
                if (c == ')')
                {
                    count--;
                    if (stack1.IsEmpty())
                        return false;
                    stack1.Pop();
                }
                if (c == '{')
                {
                    count++;
                    stack2.Push(c);
                }
                if (c == '}')
                {
                    count--;
                    if (stack2.IsEmpty())
                        return false;
                    stack2.Pop();
                }
                if (c == '[')
                {
                    count++;
                    stack3.Push(c);
                }
                if (c == ']')
                {
                    count--;
                    if (stack3.IsEmpty())
                        return false;
                    stack3.Pop();
                }
            }
            if (count < 0 || count > 0)
                return false;
            else return true;
        }

    }

    class BracketCheckerInvalidInputException : Exception
    {
    }

}
