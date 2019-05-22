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
            int i = 5;
            int summe = 0;
            summe = i + parameter;
            return summe;

        }
        public static string Umrechnen(int Ausgangszahl)
        {
            if (Ausgangszahl == 1)
            {
                return "I";
            }

            return " ";

        }




    }


}



