using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life";
            //string myString = "What if I need a\new line?";
            //string myString = "Go to your c:\\ drive";
            //string myString = @"Go to your c:\ drive";

            //string myString = String.Format("{1} = {0}", "First", "Second");

            //string myString = string.Format("{0:C}", 135132.10);
            //string myString = string.Format("{0:N}", 13513234656710);
            //string myString = string.Format("{0:P}", .123);
            //string myString = string.Format("{0:(##) ####-####}", 0854257472);

            //string myString = "   the quick brown fox jumped over the lazy dog   ";
            //myString = myString.Substring(6,15);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");
            //myString = myString.Remove(6, 15);
            //myString = String.Format("Length before: {0} -- Length after: {1}", myString.Length, myString.Trim().Length);

            //string myString = "";
            //for (int i = 0; i < 100; i++)
            //{
            //    myString += "--" + i.ToString();
            //}

            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
