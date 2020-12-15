using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralsKata
{
    public class RomanNumeralsConverter
    {

        public string Convert(int number)
        {
            string numeral = "nulla";
            if(number < 10)
            {
                numeral = GetUnitsAsNumeral(number);
            }
            else if(number > 10 && number < 100)
            {
                int units = number % 10;
                int tens = number / 10;
                numeral = GetTensAsNumeral(tens) + GetUnitsAsNumeral(units);
            }
            else if (number > 100 && number < 1000)
            {
                int hundreds = number / 100;           
                int tens = number % 100;
                int units = tens % 10;
                tens = (tens - units)/10;
                numeral = GetHundredsAsNumeral(hundreds) +GetTensAsNumeral(tens) + GetUnitsAsNumeral(units);
            }
            else if (number > 1000 && number < 4000) //max number in roman numerals is 3999
            {
                int thousands = number / 1000;
                int hundreds = number % 1000; 
                int tens = number % 100;
                int units = tens % 10;  
                hundreds = (hundreds - tens) / 100;
                tens = (tens - units) / 10;
              
                numeral = GetThousandsAsNumeral(thousands)+ GetHundredsAsNumeral(hundreds) + GetTensAsNumeral(tens) + GetUnitsAsNumeral(units);
            }
            return numeral;
        }


        private string GetUnitsAsNumeral(int units)
        {
            string numeral = "nulla";
            switch (units)
            {
                case 1:
                    numeral = "I";
                    break;
                case 2:
                    numeral = "II";
                    break;
                case 3:
                    numeral = "III";
                    break;
                case 4:
                    numeral = "IV";
                    break;
                case 5:
                    numeral = "V";
                    break;
                case 6:
                    numeral = "VI";
                    break;
                case 7:
                    numeral = "VII";
                    break;
                case 8:
                    numeral = "VIII";
                    break;
                case 9:
                    numeral = "IX";
                    break;
                default:
                    break;
            }

            return numeral;
        }

        private string GetTensAsNumeral(int tens)
        {
            string numeral = "nulla";
            switch (tens)
            {
                case 1:
                    numeral = "X";
                    break;
                case 2:
                    numeral = "XX";
                    break;
                case 30:
                    numeral = "XXX";
                    break;
                case 4:
                    numeral = "XL";
                    break;
                case 5:
                    numeral = "L";
                    break;
                case 6:
                    numeral = "LX";
                    break;
                case 7:
                    numeral = "LXX";
                    break;
                case 8:
                    numeral = "LXXX";
                    break;
                case 9:
                    numeral = "XC";
                    break;
                default:
                    break;
            }
            return numeral;
        }

        private string GetHundredsAsNumeral(int hundreds)
        {
            string numeral = "nulla";
            switch (hundreds)
            {
                case 1:
                    numeral = "C";
                    break;
                case 2:
                    numeral = "CC";
                    break;
                case 3:
                    numeral = "CCC";
                    break;
                case 4:
                    numeral = "CD";
                    break;
                case 5:
                    numeral = "D";
                    break;
                case 6:
                    numeral = "DC";
                    break;
                case 7:
                    numeral = "DCC";
                    break;
                case 8:
                    numeral = "DCCC";
                    break;
                case 9:
                    numeral = "CM";
                    break;
                default:
                    break;
            }
            return numeral;
        }

        private string GetThousandsAsNumeral(int thousands)
        {
            string numeral = "nulla";
            switch (thousands)
            {
                case 1:
                    numeral = "M";
                    break;
                case 2:
                    numeral = "MM";
                    break;
                case 3:
                    numeral = "MMM";
                    break;
                default:
                    break;
            }
            return numeral;
        }
    }
}
