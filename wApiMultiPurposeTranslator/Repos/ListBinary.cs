namespace wApiMultiPurposeTranslator.Repos
{
    public static class ListBinary
    {
        public static string GetBinary(string MyChar)
        {
            if (MyChar.Equals("A"))
                return "01000001";
            else if (MyChar.Equals("B"))
                return "01000010";
            else if (MyChar.Equals("C"))
                return "01000011";
            else if (MyChar.Equals("D"))
                return "01000100";
            else if (MyChar.Equals("E"))
                return "01000101";
            else if (MyChar.Equals("F"))
                return "01000110";
            else if (MyChar.Equals("G"))
                return "01000111";
            else if (MyChar.Equals("H"))
                return "01001000";
            else if (MyChar.Equals("I"))
                return "01001001";
            else if (MyChar.Equals("J"))
                return "01001010";
            else if (MyChar.Equals("K"))
                return "01001011";
            else if (MyChar.Equals("L"))
                return "01001100";
            else if (MyChar.Equals("M"))
                return "01001101";
            else if (MyChar.Equals("N"))
                return "01001110";
            else if (MyChar.Equals("O"))
                return "01001111";
            else if (MyChar.Equals("P"))
                return "01010000";
            else if (MyChar.Equals("Q"))
                return "01010001";
            else if (MyChar.Equals("R"))
                return "01010011";
            else if (MyChar.Equals("S"))
                return "01000010";
            else if (MyChar.Equals("T"))
                return "01010100";
            else if (MyChar.Equals("U"))
                return "01010101";
            else if (MyChar.Equals("V"))
                return "01010110";
            else if (MyChar.Equals("W"))
                return "01010111";
            else if (MyChar.Equals("X"))
                return "01011000";
            else if (MyChar.Equals("Y"))
                return "01011001";
            else if (MyChar.Equals("Z"))
                return "01011010";

            //Minusculas
            else if (MyChar.Equals("a"))
                return "01100001";
            else if (MyChar.Equals("b"))
                return "01100010";
            else if (MyChar.Equals("c"))
                return "01100011";
            else if (MyChar.Equals("d"))
                return "01100100";
            else if (MyChar.Equals("e"))
                return "01100101";
            else if (MyChar.Equals("f"))
                return "01100110";
            else if (MyChar.Equals("g"))
                return "01100111";
            else if (MyChar.Equals("h"))
                return "01101000";
            else if (MyChar.Equals("i"))
                return "01101001";
            else if (MyChar.Equals("j"))
                return "01101010";
            else if (MyChar.Equals("k"))
                return "01101011";
            else if (MyChar.Equals("l"))
                return "01101100";
            else if (MyChar.Equals("m"))
                return "01101101";
            else if (MyChar.Equals("n"))
                return "01101110";
            else if (MyChar.Equals("o"))
                return "01101111";
            else if (MyChar.Equals("p"))
                return "01110000";
            else if (MyChar.Equals("q"))
                return "01110001";
            else if (MyChar.Equals("r"))
                return "01110010";
            else if (MyChar.Equals("s"))
                return "01110011";
            else if (MyChar.Equals("t"))
                return "01110100";
            else if (MyChar.Equals("u"))
                return "01110101";
            else if (MyChar.Equals("v"))
                return "01110110";
            else if (MyChar.Equals("w"))
                return "01110111";
            else if (MyChar.Equals("x"))
                return "01111000";
            else if (MyChar.Equals("y"))
                return "01111001";
            else if (MyChar.Equals("z"))
                return "01111010";
            else
                return "XXXXXXXXXXX";
        }
    }
}
