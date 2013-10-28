using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.ToString());
            Console.WriteLine(myValue.ToShortDateString());
            Console.WriteLine(myValue.ToShortTimeString());
            Console.WriteLine(myValue.Month.ToString());

            Console.WriteLine(myValue.AddDays(3).ToShortDateString());
            Console.WriteLine(myValue.AddHours(-3).ToShortTimeString());

            //DateTime myBirthdate = new DateTime(1983, 4, 21);
            DateTime myBirthdate = DateTime.Parse("21/04/1983");

            TimeSpan myAge = DateTime.Now.Subtract(myBirthdate);
            Console.WriteLine(myAge.TotalDays.ToString());

            #region MyRegion
            

            //

            //

            // 
            #endregion

            Console.ReadLine();
        }
    }
}
