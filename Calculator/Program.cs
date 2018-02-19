using System;

namespace Calculator
{
    class Program
    {
        public void Calculate()
        {
            int firstNumber = 0;
            int seconNumber = 0;
            string operand;

            var printInstruction = new PrintInstruction();
            printInstruction.Print();

            operand = Convert.ToString(Console.ReadLine());

            if (operand == "E" || operand == "e")
            {
                return;
            }
            else
            {
                ObjectReturn objectReturn = new ObjectReturn();
                Calculator calculator = objectReturn.ReturnObject(operand);
                Addition addition = new Addition();
                if (calculator != null)
                {
                    if (operand == "+")
                    {
                        var answer1 = addition.AddManyNumbers();
                        var printAnswerAdd = new PrintAnswer();
                        printAnswerAdd.Print(answer1.ToString());
                        Calculate();
                    }
                    else if(operand == "-" || operand == "*" || operand == "/")
                    {
                        Console.WriteLine("Enter first number");
                        firstNumber = Convert.ToInt32(Console.ReadLine());
                        
                        Console.WriteLine("Enter second number");
                        seconNumber = Convert.ToInt32(Console.ReadLine());


                        var answer = calculator.Answer(firstNumber, seconNumber);

                        var printAnswer = new PrintAnswer();
                        printAnswer.Print(answer.ToString());
                        Calculate();
                    }                   

                }
                else
                {
                    Calculate();
                }
            }
            
        }      
    }
}

