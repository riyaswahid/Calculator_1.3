using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Addition : Calculator
    {
        int total = 0;
        string input = "";
        public int AddManyNumbers()
        {
            Console.WriteLine("Enter a number or = for answer");            
            input = Console.ReadLine();
            if (input == "=")
            {
                return total;
            }
            else
            {
                total += Convert.ToInt32(input);
                Console.WriteLine("Total is: " + total + "\n");
                AddManyNumbers();
            }
            return total;
        }
        public override float Answer(float number1, float number2)
        {
            return number1 + number2;
        }
    }
}
