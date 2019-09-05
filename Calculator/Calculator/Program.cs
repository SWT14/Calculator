using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            double A = 0;
            double B = 0;
            int caseSwitch = 0;
            Console.WriteLine("tryk 1 for addere");
            Console.WriteLine("tryk 2 for treakke fra");
            Console.WriteLine("tryk 3 for gange");
            caseSwitch = Console.Read();
            Console.WriteLine("intast værdi for A");
            A = Console.Read();
            Console.WriteLine("indtast værdi for B");
            B = Console.Read();
            switch (caseSwitch)
            {
                case 1:
                    Add(A, B);
                    break;
                case 2:
                    Subtract(A, B);
                    break;
                case 3:
                    Multiply(A, B);
                    break;
            }
            Console.ReadKey();
        }
        public static double Add(double A, double B)
        {
            double resultat = A + B;
            return resultat;
        }
        public static double Subtract(double A, double B)
        {
            double resultat = A - B;
            return resultat;
        }
        public static double Multiply(double A, double B)
        {
            double resultat = A * B;
            return resultat;
        }

    }
}
