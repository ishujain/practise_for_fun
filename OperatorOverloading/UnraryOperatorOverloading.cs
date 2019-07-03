using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperator
{
    //SYNTAX
    //access specifier  className operator Operator_symbol (parameters)
    //{
    //    // Code
    //}

        //UNARY OPERATOR
    class MyMathClass
    {
        public int number1 = 0;
        public int number2 = 0;
        public MyMathClass(int num1, int num2)
        {
            number1 = num1;
            number2 = num2;
        }
        public static MyMathClass operator -(MyMathClass myMathClass)
        {
            myMathClass.number1 = -myMathClass.number1;
            myMathClass.number2 = -myMathClass.number2;
            return myMathClass;
        }
        public void Display()
        {
            Console.WriteLine("number1 : " + number1);
            Console.WriteLine("number2 : " + number2);
        }
    }
    class UnraryOperatorOverloading
    {
        static void RemoveMe_Main(string[] args)
        {
            var math = new MyMathClass(123, -989);
            math.Display();
            math = -math;
            math.Display();
        }
    }
}
