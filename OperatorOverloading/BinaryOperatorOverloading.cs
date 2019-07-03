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
    class MyMathClassBinary
    {
        public int number1 = 0;
        public MyMathClassBinary(int num1)
        {
            number1 = num1;
        }
        public static MyMathClassBinary operator +(MyMathClassBinary mathClass1, MyMathClassBinary mathClass2)
        {
            var mathClass3 = new MyMathClassBinary(0);
            mathClass3.number1 = mathClass1.number1 + mathClass2.number1;
            return mathClass3;

        }
        public void Display()
        {
            Console.WriteLine("number1 : " + number1);
        }
    }
    class BinaryOperatorOverloading
    {
        static void Main(string[] args)
        {
            var math1 = new MyMathClassBinary(100);
            var math2 = new MyMathClassBinary(400);
            var math3 = new MyMathClassBinary(0);
            math1.Display();
            math2.Display();
            math3.Display();
            math3 = math1 + math2;
            math1.Display();
            math2.Display();
            math3.Display();
        }
    }
}
