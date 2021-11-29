using System;
using Caelum.Stella.CSharp.Vault;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Globalization;

namespace MoneyTypes
{
    // this function can be used for manipulate the different coins
    
    class Program
    {
        static void Main(string[] args)
        {
            Money money = 10.00;
            Debug.WriteLine(money);

            double var1 = 10.00;
            double var2 = 20.00;

            Money equals = var1 + var2;

            Debug.WriteLine(equals);

            decimal x = 20m;
            decimal y = 15m;

            Money minus = x - y;

            Debug.WriteLine(minus);

            // another coin 
            //euro
            Money euro = new Money(Currency.EUR, 1000);
            Debug.WriteLine(euro);

            //dolar
            Money dolar = new Money(Currency.USD, 1000);
            Debug.WriteLine(dolar);

            // change the culture of the coin 
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            Debug.WriteLine(dolar);
            // default br
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

            // sun 2 diferents coins 
            // this case the program will have a exception because we need to convert the currency before the sum
            Money sumcoins = euro + dolar;
            Debug.WriteLine(sumcoins);

        }
    }
}
