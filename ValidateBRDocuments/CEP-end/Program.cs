using Caelum.Stella.CSharp.Http;
using System;
using System.Diagnostics;
using System.Net.Http;

namespace CEP_end
{
    class Program
    {
        // you can consume cep through net.http, is a very simple to do. 
        static void Main(string[] args)
        {
            // in net.http 
            //string cep = "71884300";
            //string url ="https://viacep.com.br/ws/"+cep+"/json/";
            //string result = new HttpClient().GetStringAsync(url).Result;
            //Debug.WriteLine(result);


            //Caelum  library way
            string cep = "71884300";
            string adressJson = new ViaCEP().GetEnderecoJson(cep);
            Debug.WriteLine(adressJson);
            // this library allows XML format and the object ENDERECO can takes one atribute or more atributes of the json
            // the exceptions is better formatted
        }

    }
}
