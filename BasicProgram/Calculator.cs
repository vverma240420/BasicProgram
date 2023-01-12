using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    /// <summary>
    /// Calculator class created to perform arithmetic operations
    /// </summary>
    class Calculator
    {
        //instance variables
        public int first, second, sum;

        /// <summary>
        /// Initializes a new instance of the <see cref="Calculator"/> class.
        /// </summary>
        /// <param name="firstNumb">The first numb.</param>
        /// <param name="secondNumb">The second numb.</param>
        public Calculator(int firstNumb, int secondNumb)
        {
            first = firstNumb;
            second = secondNumb;
        }

        /// <summary>
        /// Addition of 2  numbers to get sum
        /// </summary>
        public void Addition()
        {
            sum = first + second;
            Console.WriteLine("Sum:" + sum);
        }
    }
}
