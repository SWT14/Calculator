using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calc
    {
        
        // Addition:
        public static double Add(double A, double B)
        {
            double resultat = A + B;
            return resultat;
        }

        // Subtract:
        public static double Subtract(double A, double B)
        {
            double resultat = A - B;
            return resultat;
        }

        // Multiply:
        public static double Multiply(double A, double B)
        {
            double resultat = A * B;
            return resultat;
        }

        // Power:
        public static double Power(double A, double B)
        {
            double resultat = Math.Pow(A, B);
            return resultat;
        }
    }
}
