using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculatorConsoleApplication.Classes
{
    class Calculations
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int Add()
        {
            int x = X;
            int y = Y;
            int result = x + y;
            return result;
        }

        public int Subtract()
        {
            int x = X;
            int y = Y;
            int result = x - y;
            return result;
        }

        public int Divide()
        {
            int x = X;
            int y = Y;
            int result = x / y;
            return result;
        }

        public int Multiply()
        {
            int x = X;
            int y = Y;
            int result = x * y;
            return result;
        }




    }
}
