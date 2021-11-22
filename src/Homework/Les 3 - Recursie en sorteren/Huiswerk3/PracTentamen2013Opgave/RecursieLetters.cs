using System;
using System.Collections.Generic;
using System.Text;

namespace AD.PracTentamen2013Opgave
{
    public class RecursieLetters
    {
        public string printletter(int n)
        {
            if (n > 0)
                 return $"A{printletter(n - 1)}Z";
            else return "";
        }

        public string printletter2(int p, int q)
        {
            if (p > 0 && q > 0)
                return $"A{printletter2(p - 1, q - 1)}Z";
            if (p == 0 && q > 0)
                return $"{printletter2(0, q - 1)}Z";
            if (p > 0 && q == 0)
                return $"A{printletter2(p - 1, 0)}";

            else return "";
        }
    }
}
