using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fouad_Ouardi_Exercise01
{
    class Program
    {
        static Func<string, string, string, string> Minimum = (string1, string2, string3) =>
        {
            if (string.Compare(string1, string2, StringComparison.OrdinalIgnoreCase) < 0 && string.Compare(string1, string3, StringComparison.OrdinalIgnoreCase) < 0)
            {
                return string1;
            }
            else if (string.Compare(string2, string1, StringComparison.OrdinalIgnoreCase) < 0 && string.Compare(string2, string3, StringComparison.OrdinalIgnoreCase) < 0)
            {
                return string2;
            }
            else
            {
                return string3;
            }
        };

        static Action<double, double, double> AvgGrade = (value1, value2, value3) =>
        {
            double avg = (value1 + value2 + value3) / 3;
            Console.WriteLine("The average grade is " + avg + ":D");
        };

        static void Main(string[] args)
        {
            Console.WriteLine("The smallest string is " + Minimum("Testing", "tested", "test") + " :D");
            AvgGrade(78, 23, 65);
            Console.ReadLine();
        }
    }
}
