﻿using System;
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

            Console.WriteLine("tryk 1 for addere");
            Console.WriteLine("tryk 2 for treakke fra");
            Console.WriteLine("tryk 3 for gange");
            Console.WriteLine("tryk 4 for potens");
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
                    Calc.Power(A, B);
            }

            Console.ReadKey();
        }
       

    }
}
