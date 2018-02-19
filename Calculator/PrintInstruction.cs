using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class PrintInstruction
    {
        public void Print()
        {
            string[] lines = {"Enter a valid operand or 'E' to exit",
                              "------------------------------------",
                                "1. Addition: + ",
                                "2. Substraction: - ",
                                "3. Multiplication: * ",
                                "4. Division: / ",
                                    " "};

            foreach (string line in lines)
                Console.WriteLine(line);
        }
    }
}
