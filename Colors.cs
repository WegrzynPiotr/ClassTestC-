using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMĆwiczenia
{
    internal class Colors
    {
        static string currentColor = "";
        public static string Print(string color) {
            if(color == "blue")
            currentColor = "Jestem Niebieski!";
            if (color == "red")
              currentColor =  "Jestem czerwony!";
        return currentColor;
        }

    }
}
