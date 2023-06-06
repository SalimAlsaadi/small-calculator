using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            string num1 = Console.ReadLine();//first number will enter by user
            int integerNum1 = int.Parse(num1);

            Console.WriteLine("enter operatore ");
            String operatorName = Console.ReadLine();//operstor will enter by user as string

            Console.WriteLine("enter second number ");
            string num2 = Console.ReadLine();//second number will enter by user 
            int intergerNum2 = int.Parse(num2);

            string operastorFunction1 = "*";//here is string operator, use to compare with operator that user will enter. 
            string operastorFunction2 = "/";//by compare of two string operators we can make operation algorithm 
            string operastorFunction3 = "+";
            string operastorFunction4 = "-";


            ; if (string.Compare(operatorName/*will enter by user*/, operastorFunction1) == 0){

                int num3 = integerNum1 * intergerNum2;
                Console.WriteLine("the resulte of multiply : " + num3);

            }
            else if(string.Compare(operatorName/*will enter by user*/, operastorFunction2) == 0){

                int num4 = integerNum1 / intergerNum2;
                Console.WriteLine("the resulte of divid : " + num4);
            }
            else if(string.Compare(operatorName/*will enter by user*/, operastorFunction3) == 0)
            {

                int num5 = integerNum1 + intergerNum2;
                Console.WriteLine("the result of addition : " + num5);
            }
            else if(string.Compare(operatorName/*will enter by user*/, operastorFunction4) == 0)
            {
                int num6 = integerNum1 - intergerNum2;
                Console.WriteLine("the result of subtraction : " + num6);

            }
            else 
            {
                Console.WriteLine(" wrong operation");
            }

        }
    }
}