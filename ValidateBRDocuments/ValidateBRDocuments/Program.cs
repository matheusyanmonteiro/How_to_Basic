using System;
using System.Diagnostics;
using Caelum.Stella.CSharp;
using Caelum.Stella.CSharp.Validation;

namespace ValidateBRDocuments
{
    class Program
    {
        // this method is from the library Caelum.Stella.CSharp.Validation, basically is the algorithm for the validate the CPF
        // var cpf: vector[0...8] int, v1 and v2 int. 
        // the logic is:  for i = 0; i < sizeof(CPF); i++ 
        // validation1 (v1) = v1 + cpf[i] * (9 - ( i mod 10));
        // validation2 (v2) = v2 + cpf[i] * (9 - ((i + 1) mod 10));
        // end for
        // validate cal results
        // v1 = (v1 mod 11) mod 10;
        // v2 = v2 + v1 * 9;
        // v2 = (v2 mod 11) mod 10;

        static void Main(string[] args)
        {
            //vars
            string cpf1 = "86288366757";
            string cpf2 = "98745366797";
            string cpf3 = "22222222222";

            // call the function
            ValidateCPF(cpf1);
            ValidateCPF(cpf2);
            ValidateCPF(cpf3);
        }

        //function for validate
        public static void ValidateCPF(string cpf)
        {
            try
            {
                //this method is from library, this method is responsible from the logic before described
                new CPFValidator().AssertValid(cpf);
                //print in the output 
                Debug.WriteLine("CPF Valido: " + cpf);
            }
            catch (Exception e)
            {
                // this block run access only if have error
                //another print with the error message.
                Debug.WriteLine("CPF Invalido: " + cpf + " : " + e.ToString());
            }
        }
    }
}
