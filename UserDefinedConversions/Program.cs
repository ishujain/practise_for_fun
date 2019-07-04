using System;

namespace UserDefinedConversions
{
    class Program
    {
        class Student
        {
            public string Name { get; set; }
            public int Roll_No { get; set; }

            // This method used to convert int value into 'Student' type  
            static public implicit operator Student(int value)
            {
                // Return type of this method should be of 'Student' type  
                return new Student { Name = "jainy", Roll_No = value };
            }

            // This method used to convert 'Student' type value into 'int' type  
            static public explicit operator int(Student student)
            {
                // Return type of this method should be of 'int' type  
                return student.Roll_No;
            }
        }

        static void Main(string[] args)
        {
            // Object of Student class is initialised  
            Student student = new Student();
            int value = 100;

            // On below line, int value is converted to student type, implicit  
            student = value;
            Console.WriteLine("Student name" + student.Name + " Student Roll No." + student.Roll_No);

            value = 200;
            Console.WriteLine("Roll No. " + value);

            // On below line, student type is converted to int type  
            value = (int)student;
            Console.WriteLine("Roll No. " + value);
            Console.ReadKey();
        }
    }
}
