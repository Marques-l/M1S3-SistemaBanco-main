using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M1S3_SistemaBanco
{
    public class PessoaJuridica :Cliente  // Herdando a classe cliente.
    {   
         public string RazaoSocial { get; set; }        //Colocando as propriedades. 
         public string CNPJ { get; set; }

          public PessoaJuridica(){  //Construtor vazio para aceitar a instância sem argumento

          }
          public PessoaJuridica (string razaoSocial, string cnpj){
              RazaoSocial = razaoSocial; 
              CNPJ = cnpj; 
          }

         public override string ResumoCliente(){ // Feito o override.
           return  $"{NumeroConta} |  {RazaoSocial}  | {CNPJ}";  //Colocando o CNPJ e razão social aqui
        }
        public override double GetSaldo(double valor){ // Feito o override.
            double saldo = 0;
            foreach(Transacao transacao  in Extrato){
                saldo += transacao.Valor;
            }
            return saldo;
        }
        

    protected override double GetSaldo() //Implementou uma classe protected, indicação do VsCode
    {
      throw new NotImplementedException();
    }

    public override bool EhMaior() // 
    {
     return true; 
    }
   
  }
}