﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    public class Towords
    {
      
       public static String NumWords(long number) // to converts long to words
   
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + NumWords(Math.Abs(number));

            string words = ""; 

            if ((number / 1000000000000000000) > 0)
            {
                words += NumWords(number / 1000000000000000000) + " quintillion, ";
                number %= 1000000000000000000;
            }

            if ((number / 1000000000000000) > 0)
            {
                words += NumWords(number / 1000000000000000) + " quadrillion, ";
                number %= 1000000000000000;
            }

            if ((number / 1000000000000) > 0)
            {
                words += NumWords(number / 1000000000000) + " trillion, ";
                number %= 1000000000000;
            }

            if ((number / 1000000000) > 0)
            {
                words += NumWords(number / 1000000000) + " billion, ";
                number %= 1000000000;
            }

            if ((number / 1000000) > 0)
            {
                words += NumWords(number / 1000000) + " million, ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumWords(number / 1000) + " thousand, ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumWords(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += " " + unitsMap[number % 10];
                }
            }

            return words;
        }
    }
}

