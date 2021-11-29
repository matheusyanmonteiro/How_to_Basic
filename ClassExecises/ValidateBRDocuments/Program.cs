using System;
using System.Diagnostics;
using Caelum.Stella.CSharp;
using Caelum.Stella.CSharp.Validation;

namespace ValidateBRDocuments
{
    class Program
    {
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

            // vars cnpj 
            string cnpj1 = "51241758000152";
            string cnpj2 = "14128481000120";

            //call the function

            ValidateCNPJ(cnpj1);
            ValidateCNPJ(cnpj2);
        }

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

        // this method is from the same library, now we validate the CNPJ algorithm. 
        // the command CNPJvalidator is basic 
        // the vector has 12 numbers and this numbers as multiplication for another 12 numbers
        // basic algorith for the method
        //int CNPJ[14] = { 1, 1, 4, 4, 4, 7, 7, 7, 0, 0, 0, 1, 0, 0 };
        //int verify1[12] = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
        //int verify2[13] = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
        //int result = 0;
        //int codigoverificador;
        //int codigoverificador2;
        //for (int i = 0; i< 12; i ++) {
        //    result += CNJP[i] * verify1[i];
        //}
        //if ((conta % 11) < 2 )
        //    codigoverificador = 0;
        //else
        //    codigoverificador = 11 - (conta % 11);
        //printf("%d", codigoverificador);
        //CNPJ[12] = codigoverificador;
        //result = 0;
        //for (int i = 0; i< 13; i++){
        //    result += CNJP[i] * verify2[i];
        //}
        //if ((conta % 11) < 2)
        //    codigoverificador2 = 0;
        //else
        //    codigoverificador2 = 11 - (conta % 11);
        //printf("\n%d", codigoverificador2);
        //CNPJ[13] = codigoverificador2;
        //puts("\n");
        //for (int i = 0; i < 14; i++)
        //{
        //    if (i == 12)
        //        printf("-%d", CNPJ[i]);
        //    else
        //        printf("%d", CNPJ[i]);

        public static void ValidateCNPJ (string cnpj)
        {
            if (new CNPJValidator().IsValid(cnpj))
            {
                Debug.WriteLine("CNPJ Válido" + cnpj);
            } else
            {
                Debug.WriteLine("CPNJ Invalido: " + cnpj);
            }
        }
    }
}
