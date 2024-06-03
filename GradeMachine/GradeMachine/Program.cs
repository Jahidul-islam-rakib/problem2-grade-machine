using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a C# program using if, else if, and else statements to determine the grade based on a student's score. The grading criteria are as follows:
Score 90 and above: Grade A
Score 80 to 89: Grade B
Score 70 to 79: Grade C
Score 60 to 69: Grade D
Score below 60: Grade F
*/

namespace GradeMachine
{
    public class Problem2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your score :");

            int score = Convert.ToInt32(Console.ReadLine());

            if (score < 60)
            {
                Console.WriteLine("Your grade is : F");
            }
            else if (score < 70)
            {
                Console.WriteLine("Your grade is : D");
            }
            else if (score < 80)
            {
                Console.WriteLine("Your grade is : C");
            }
            else if (score < 90)
            {
                Console.WriteLine("Your grade is : B");
            }

            else
            {
                Console.WriteLine("Your grade is : A");
            }
        

        }
    }
}
