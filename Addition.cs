using System;

public class Addition : Calculator
{
    public Addition(int firstNumber = 0, int secondNumber = 0) : base(firstNumber, secondNumber)
    {

    }
    public override float answer()
    {
        return num1 + num2;
    }
    public override void print()
    {
        Console.WriteLine("Answer is: " + num1 + "+" + num2 + "= " + answer());
        Console.ReadLine();
    }
}
