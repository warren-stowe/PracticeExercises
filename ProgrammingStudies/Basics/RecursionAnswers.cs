using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingStudies.Basics
{
    public class RecursionAnswers
    {

        public int Factorial(int num)
        {
            if (num == 1)
            {
                return 1;
            } else
            {
                return num * Factorial(num - 1);
            }
        }
    }
}
