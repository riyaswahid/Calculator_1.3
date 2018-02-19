using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class ObjectReturn
    {
        public Calculator ReturnObject(string operand)
        {
            Calculator calculator = null;
            if (operand == "+" || operand == "-" || operand == "/" || operand == "*")
            {               

                switch (operand)
                {
                    case "+":
                        Addition addition = new Addition();
                        return calculator = addition;

                    case "-":
                        Substraction substraction = new Substraction();
                        return calculator = substraction;

                    case "*":
                        Multiplication multiplication = new Multiplication();
                        return calculator = multiplication;

                    case "/":
                        Division division = new Division();
                        return calculator = division;
                }
            }
            return calculator;
        }
    }
}
