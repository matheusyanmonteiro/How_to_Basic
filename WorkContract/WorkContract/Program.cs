using System;

namespace WorkContract
{
  class Program
  {
    static void Main(string[] args)
    {
      var contract = new
      {
        Empresa = new
        {
          razaoSocial = "Alcapone serviços de alcool LTDA.",
          CNPJ = "67942488000147"
        },
        Funcionario = new
        {
          nome = "Mateus Maia",
          CPF = "14290678025",
          RG = "123456789-00",
          nacionalidade = "brhue",
          estadoCivil = "casado"
        },
        Inicio = new DateTime(2018, 1, 1),
        Cargo = "Cobrador",
        Salario = 3002.22
      };

      string document = $@"                     
                                                CONTRATO INDIVIDUAL DE TRABALHO TEMPORÁRIO

        EMPREGADOR: {contract.Empresa.razaoSocial}, com sede à(LOGRADOURO), (NUMERO), (BAIRRO), CEP(CEP), (LOCALIDADE), (UF), inscrita no CNPJ sob nº {contract.Empresa.CNPJ};

        EMPREGADO: {contract.Funcionario.nome}, {contract.Funcionario.nacionalidade}, {contract.Funcionario.estadoCivil}, portador da cédula de identidade R.G.nº {contract.Funcionario.RG} e CPF/ MF nº {contract.Funcionario.CPF}, residente e domiciliado na(LOGRADOURO), (NUMERO), (BAIRRO), CEP(CEP), (LOCALIDADE), (UF).

        Pelo presente instrumento particular de contrato individual de trabalho, fica justo e contratado o seguinte:

            Cláusula 1ª - O EMPREGADO prestará ao EMPREGADOR, a partir de {contract.Inicio} e assinatura deste instrumento, seus trabalhos exercendo a função de {contract.Cargo}, prestando pessoalmente o labor diário no período compreendido entre 9 horas às 18 horas, e intervalo de 1 hora para almoço;

            Cláusula 2ª - Não haverá expediente nos dias de sábado, sendo prestado a compensação de horário semanal;

            Cláusula 3ª - O EMPREGADOR pagará mensalmente, ao EMPREGADO, a título de salário a importância de {contract.Salario} (SALÁRIO POR EXTENSO), com os descontos previstos por lei;

            Cláusula 4ª - Estará o EMPREGADO subordinado a legislação vigente no que diz respeito aos descontos de faltas e demais sanções disciplinares contidas na Consolidação das Leis do Trabalho.

            Cláusula 5ª - O prazo de duração do contrato é de 2(dois) anos, contados a partir da assinatura pelos contratantes;

            Cláusula 6ª - O EMPREGADO obedecerá o regulamento interno da empresa, e filosofia de trabalho da mesma.

            Como prova do acordado, assinam instrumento, afirmado e respeitando seu teor por inteiro, e firmam conjuntamente a este duas testemunhas, comprovando as razões descritas.

            (LOCALIDADE), (DATA POR EXTENSO)


            _______________________________________________________
            {contract.Empresa.razaoSocial}

            _______________________________________________________
            {contract.Funcionario.nome}

            _______________________________________________________
            (Nome, R.G, Testemunha)

            _______________________________________________________
            (Nome, R.G, Testemunha)";

      Console.WriteLine(document);
      Console.ReadKey();

    }
  }
}
