using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wApiMultiPurposeTranslator.Repos
{
    public class ListMorse
    {
        public static string GetMorse(string MyChar)
        {
            string auxiliarChar = " ";
            if (MyChar.Equals("A"))
                return ".-" + auxiliarChar;
            else if (MyChar.Equals("B"))
                return "-..." + auxiliarChar;
            else if (MyChar.Equals("C"))
                return "-.-." + auxiliarChar;
            else if (MyChar.Equals("D"))
                return "-.." + auxiliarChar;
            else if (MyChar.Equals("E"))
                return "." + auxiliarChar;
            else if (MyChar.Equals("F"))
                return "..-." + auxiliarChar;
            else if (MyChar.Equals("G"))
                return "--." + auxiliarChar;
            else if (MyChar.Equals("H"))
                return "...." + auxiliarChar;
            else if (MyChar.Equals("I"))
                return ".." + auxiliarChar;
            else if (MyChar.Equals("J"))
                return ".---" + auxiliarChar;
            else if (MyChar.Equals("K"))
                return "-.-" + auxiliarChar;
            else if (MyChar.Equals("L"))
                return ".-.." + auxiliarChar;
            else if (MyChar.Equals("M"))
                return "--" + auxiliarChar;
            else if (MyChar.Equals("N"))
                return "-." + auxiliarChar;
            else if (MyChar.Equals("O"))
                return "---" + auxiliarChar;
            else if (MyChar.Equals("P"))
                return ".--." + auxiliarChar;
            else if (MyChar.Equals("Q"))
                return "--.-" + auxiliarChar;
            else if (MyChar.Equals("R"))
                return ".-." + auxiliarChar;
            else if (MyChar.Equals("S"))
                return "..." + auxiliarChar;
            else if (MyChar.Equals("T"))
                return "-" + auxiliarChar;
            else if (MyChar.Equals("U"))
                return "..-" + auxiliarChar;
            else if (MyChar.Equals("V"))
                return "...-" + auxiliarChar;
            else if (MyChar.Equals("W"))
                return ".--" + auxiliarChar;
            else if (MyChar.Equals("X"))
                return "-..-" + auxiliarChar;
            else if (MyChar.Equals("Y"))
                return "-.--" + auxiliarChar;
            else if (MyChar.Equals("Z"))
                return "--.." + auxiliarChar;
            else if (MyChar.Equals(" "))
                return "   ";
            else
                return "";

        }
    }
}
