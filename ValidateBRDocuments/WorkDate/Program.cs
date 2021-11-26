using System;
using System.Diagnostics;
using System.Globalization;

namespace WorkDate
{
    class Program
    {
        static void Main(string[] args)
        {
            // var tipe Date and time ( dd/mm/aaaa )
            DateTime data = new DateTime(2017, 9, 23);
            Debug.WriteLine(data);
            // toString() type d takes only the date 
            Debug.WriteLine(data.ToString("d"));
            // change the culture for other
            Debug.WriteLine(data.ToString("d", new CultureInfo("pt-Br")));
            // in this case the date as ben presented  in extensive
            Debug.WriteLine(data.ToString("D"));
            // this case we print only month and day
            Debug.WriteLine(data.ToString("m"));
            // only month and year 
            Debug.WriteLine(data.ToString("Y"));

            // the format to convert string in the datetime form
            Debug.WriteLine(data.ToString("O"));
            // showing the convertion works use casting 
            DateTime testingconvert = DateTime.Parse(data.ToString("0"));

            // var tipe Date and time ( dd/mm/aaaa tt:tt)
            DateTime data1 = new DateTime(2017, 9, 23, 13, 14, 933);
            Debug.WriteLine(data1);
            //this tostring takes only hour. change the expression for t is work like same 
            Debug.WriteLine(data1.ToString("HH:mm"));


        }
    }
}
