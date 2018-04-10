using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisePage36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number would you like to do math operations on?");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            MathOperationsOnNumber mathOperationsOnNumber = new MathOperationsOnNumber();
            Console.WriteLine(mathOperationsOnNumber.addOneToNumber(userNumber));
            Console.WriteLine(mathOperationsOnNumber.multiplyNumberByTwo(userNumber));
            Console.WriteLine(mathOperationsOnNumber.subtractTwentyFromNumber(userNumber));
            Console.ReadLine();
        }
    }
}
