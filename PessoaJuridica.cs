using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M1S3_SistemaBanco
{
    public class PessoaJuridica :Cliente  // Herdando a classe cliente
    {   
         public string Nome { get; set; }        //Colocando as propriedades  
         public string CNPJ { get; set; }


         public override string ResumoCliente(){ // Feito o override
           return  $"{NumeroConta} |  {Nome}  | {CNPJ}";  //Colocando o CNPJ
        }
        public override double GetSaldo(double valor){ // Feito o override
            double saldo = 0;
            foreach(Transacao transacao  in Extrato){
                saldo += transacao.Valor;
            }
            return saldo;
        }
    }
}