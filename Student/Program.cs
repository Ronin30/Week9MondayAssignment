using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
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
        }
    }
}
