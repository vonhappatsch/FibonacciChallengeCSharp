using System;

using System.Collections.Generic;
using System.Linq;

namespace Codenation.Challenge
{
    public class Math
    {
        public List<int> Fibonacci()
        {
            List<int> list = new List<int>();
            int n = 350, n1 = 0, n2 = 1;
            list.Add(n1);
            while (n1 < n)
            {
                int sum = n1 + n2;
                n1 = n2;
                list.Add(n1);
                n2 = sum;
            }
            return list;
        }

            public bool IsFibonacci(int numberToTest)
        {
            return Fibonacci().Contains(numberToTest);
        }
    }
}
