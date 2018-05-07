using System;
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

            if (input % 3 ==0)
            { return "Fizz"; }
            return input.ToString();
        }
    }
}
