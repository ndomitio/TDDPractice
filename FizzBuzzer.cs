﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class FizzBuzzer
    {
        public void sampleTest()
        {

        }

        public static string GetValue(int input)
        {

            if (input % 15 == 0)
            { return "FizzBuzz"; }

            if (input %5 == 0)
            {
                return "Buzz";
            }
            if (input % 3 == 0)
            { return "Fizz"; }

            return input.ToString();
        }
    }
}
