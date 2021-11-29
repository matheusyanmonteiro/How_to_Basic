using Caelum.Stella.CSharp.Inwords;
using System;
using System.Diagnostics;

namespace TextNumbers
{
    // this program use a library for transform int, float and double numbers in write numbers. 
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 75;
            string extenso =  new Numero(valor).Extenso();
            Debug.WriteLine(extenso);

            valor = 1532987;
            extenso = new Numero(valor).Extenso();
            Debug.WriteLine(extenso);

            string extensoBRL = new MoedaBRL(valor).Extenso();
            Debug.WriteLine(extensoBRL);

            valor = 1532987.89;
            extensoBRL = new MoedaBRL(valor).Extenso();
            Debug.WriteLine(extensoBRL);

        }
    }
}
