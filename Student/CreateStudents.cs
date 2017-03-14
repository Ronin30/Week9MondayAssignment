using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Student
{
    class Program
    {
        class CreateStudents
        {
            //I wasn't sure what I was to put in this class. Step 6 said to add this class,
            //create two student objects and to assign them some values and display the students. 
            //I wasn't sure because we already instantiated students later in the code. 
        }

        class Student
        {
            private int idNumber;
            private string lastName;
            private double gradePointAverage;

            public const double HIGHEST_GPA = 4.0;
            public const double LOWEST_GPA = 0.0;

            public int IdNumber
            {
                get
                {
                    return idNumber;
                }
                set
                {
                    idNumber = value;
                }
            }
            public String LastName
            {
                get
                {
                    return lastName;
                }
                set
                {
                    lastName = value;
                }
            }

            public double GradePointAverage
            {
                get
                {
                    return gradePointAverage;
                }
                set
                {
                    if (value >= LOWEST_GPA && value <= HIGHEST_GPA)
                        gradePointAverage = value;
                    else
                        gradePointAverage = LOWEST_GPA;
                }
            }
        }

        static void Main(string[] args)
        {
            Student first = new Student();
            Student second = new Student();
            first.IdNumber = 123;
            first.LastName = "Anderson";
            first.GradePointAverage = 3.5;
            second.IdNumber = 789;
            second.LastName = "Daniels";
            second.GradePointAverage = 4.1;

            Display(first);
            Display(second);
        }

        static void Display(Student stu)
        {
            WriteLine("{0, 5} {1, -10} {2, 6}", stu.IdNumber, stu.LastName, stu.GradePointAverage.ToString("F1"));
            ReadKey();
        }
    }
}
