using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fouad_Ouardi_Exercise02
{
    class Program
    {
        public delegate bool GradesPredicate(double grade);
        static void Main(string[] args)
        {
            int Min = 5;
            int Max = 50;
            double[] stGrade = new double[10];

            Random rNum = new Random();
            for (int i = 0; i < stGrade.Length; i++)
            {
                stGrade[i] = rNum.Next(Min, Max);
            }
            
            GradesPredicate gradesPredicate = (grade) => { return grade >= 15.0; };

            GradesFilter(stGrade, gradesPredicate);
            Console.ReadLine();

        }

        public static void GradesFilter(double[] stGrade, GradesPredicate gradesPredicate)
        {
            var filteredStGrade = stGrade.Where(grade => gradesPredicate(grade));
            foreach (var grade in filteredStGrade)
            {
                Console.WriteLine(grade);
            }
        }
    }
}
