using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infotag
{
    public class Umrechner
    {



        public static int Addieren(int parameter)
        {
            int i = 1;
            int summe = 0;
            summe = i + parameter;
            return summe;

        }

        public static string Umrechnen(int Ausgangszahl)
        {
            if ((Ausgangszahl < 0) || (Ausgangszahl > 3999)) {
                throw new ArgumentOutOfRangeException("Zahl ist größer als 3999");
            } 
            switch (Ausgangszahl)
            {
                case int n when n >= 1000:
                    return "M" + Umrechnen(Ausgangszahl - 1000);
                case int n when n >= 900:
                    return "CM" + Umrechnen(Ausgangszahl - 900);
                case int n when n >= 500:
                    return "D" + Umrechnen(Ausgangszahl - 500);
                case int n when n >= 400:
                    return "CD" + Umrechnen(Ausgangszahl - 400);
                case int n when n >= 100:
                    return "C" + Umrechnen(Ausgangszahl - 100);
                case int n when n >= 90:
                    return "XC" + Umrechnen(Ausgangszahl - 90);
                case int n when n >= 50:
                    return "L" + Umrechnen(Ausgangszahl - 50);
                case int n when n >= 40:
                    return "XL" + Umrechnen(Ausgangszahl - 40);
                case int n when n >= 10:
                    return "X" + Umrechnen(Ausgangszahl - 10);
                case int n when n >= 9:
                    return "IX" + Umrechnen(Ausgangszahl - 9);
                case int n when n >= 5:
                    return "V" + Umrechnen(Ausgangszahl - 5);
                case int n when n >= 4:
                    return "IV" + Umrechnen(Ausgangszahl - 4);
                case int n when n >= 1:
                    return "I" + Umrechnen(Ausgangszahl - 1);
                case int n when n < 1:
                    return "";
                default:
                    throw new ArgumentOutOfRangeException("Da ist wohl etwas schief gelaufen");
            }
        }
    }
}


