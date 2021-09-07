using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise01;

namespace Exercise02
{
  public class ProgramConvertor
    {
        static void Main(string[] args)
        {
            try
            {
                //prompt the user to take in the number
                Console.WriteLine("Enter a Number to convert to words");
                // read the the user input
                string number = Console.ReadLine();


                //test if the number has decimals
                string words = "";
                    string[] Arrnumbers = number.ToString().Split('.');
                    if (Arrnumbers.Length > 1)
                    {
                        Console.WriteLine("Number is not integer");
                        Console.ReadKey();
                    }

                 Towords towords = new Towords();
                //pass the number to conversion class
                words = Towords.NumWords(long.Parse(number));

                //output the result
                Console.WriteLine("Number in words is \n{0}", words);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }

}


























//        static void Main(string[] args)
//        {
//            Console.Write("Enter a number to convert to words: ");
//            long n = Int64.Parse(Console.ReadLine());

//            Console.WriteLine("{0}", NumWordsWrapper(n));
//        }


//        static String NumWordsWrapper(long n)
//        {
//            string words = "";
//                  if (n == 0)
//                return "zero";
//            //try
//            //{
//            //    string[] splitter = n.ToString().Split('.');
//            //    intPart = int.Parse(splitter[0]);
//            //    decPart = double.Parse(splitter[1]);
//            //}
//            //catch
//            //{
//            //    intPart = n;
//            //}

//            Towords Towords = new Towords();             
//            words = Towords.ChangeToWords(n);

//            //if (decPart > 0)
//            //{
//            //    if (words != "")
//            //        words += " and ";
//            //    int counter = decPart.ToString().Length;
//            //    switch (counter)
//            //    {
//            //        case 1: words += Towords.ChangeToWords(decPart) + " tenths"; break;
//            //        case 2: words += Towords.ChangeToWords(decPart) + " hundredths"; break;
//            //        case 3: words += Towords.ChangeToWords(decPart) + " thousandths"; break;
//            //        case 4: words += Towords.ChangeToWords(decPart) + " ten-thousandths"; break;
//            //        case 5: words += Towords.ChangeToWords(decPart) + " hundred-thousandths"; break;
//            //        case 6: words += Towords.ChangeToWords(decPart) + " millionths"; break;
//            //        case 7: words += Towords.ChangeToWords(decPart) + " ten-millionths"; break;
//            //    }
//            //}


//            return words;
//        }



////--------------------------------------------

//    }
//}
