using System;
using System.Text.RegularExpressions;

namespace maskcreditcardnumber
{
    class Program
    {
        static void Main(string[] args)
        {


            //program to mask all but the last 4 digits in string, except when there are 4 or less digits,
            //then just return digits

            string cc = "00000034";







            if (cc.Length > 4)
            {
                var lastFourDigits = cc.Substring(cc.Length - 4, 4);

                var concealDigits = new string('#', cc.Length - lastFourDigits.Length);

                var hiddenInfo = string.Concat(concealDigits, lastFourDigits);


                Console.WriteLine($"{hiddenInfo}");



            }
            else
            {
                Console.WriteLine($"{cc}");
            }



            
            Console.ReadLine();




        }
    }
}
