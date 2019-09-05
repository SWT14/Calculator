using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            double A = 0;
            double B = 0;
            int caseSwitch = 0;

            Console.WriteLine("Tryk 1 for at addere ");
            Console.WriteLine("Tryk 2 for at treakke fra ");
            Console.WriteLine("Tryk 3 for at gange ");
            Console.WriteLine("Tryk 4 for at dividere ");
            Console.WriteLine("Tryk 5 for at beregne potens");

            caseSwitch = Console.Read();

            Console.WriteLine("intast værdi for A");
            A = Console.Read();
            Console.WriteLine("indtast værdi for B");
            B = Console.Read();


            switch (caseSwitch)
            {
                case 1:
                    Calc.Add(A, B);
                    break;
                case 2:
                    Calc.Subtract(A, B);
                    break;
                case 3:
                    Calc.Multiply(A, B);
                    break;
                case 4:
                    Calc.Divide(A, B);
                    break;
                case 5:
                    Calc.Power(A, B);
                    break;
            }

            Console.ReadKey();
        }
       

    }
}
