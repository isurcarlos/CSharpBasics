using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "Go to your c:\\ drive";
            //string myString = "My \"so called\" life";
            //string myString = "\t Y si quiero \n una nueva linea?";
            //string myString = @"Go to your c:\ drive"; // verbatim
            //string myString = @"Y si quiero
            //una nueva linea?";
            //string myString = "";
                        //myString = string.Format("{0}! {1} .. this is {2} {1}", "Hello", "World", "csharp");
            //myString = string.Format("{0:C}", 123.45);
            //myString = string.Format("{0:N}", 1234567890);
            //myString = string.Format("{0:P}", .123);
            //myString = string.Format("Phone number: {0:(##) ###-####}", 1234567890);

            /*StringBuilder myString = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                //myString = myString + "--" + i.ToString();
                //myString += "--" + i.ToString();
                myString.Append("--");
                myString.Append(i);
                
            }
            myString.Replace("-", "a");
            Console.WriteLine("Longitud " + myString.Length.ToString()); */

            string myString = "  .It's better to be lucky than good.  ";
            
            //myString = myString.Substring(5, 12);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");
            myString = String.Format("Length Before: {0} -- After: {1}", myString.Length, myString.Trim(' ', '.').Length);
            

            #region MyRegion

            // 
            

            // 
            /*  */
            // verbatim

            // string myString = string.Format("{0}!", "Hello");
            //string myString = string.Format("Make: {0} (Model: {1})", "BMW", "745li");

            //

            //string 

            //string 

            //string 


            //string myString = "";

            /*
            

            for (int i = 0; i < 100; i++)
            {
                //myString = myString + "--" + i.ToString();
               // myString += "--" + i.ToString();

                

            }
            */

            //
            #endregion

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
