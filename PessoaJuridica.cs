using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M1S3_SistemaBanco
{
    public class PessoaJuridica :Cliente  // Herdando a classe cliente.
    {   
         public string Nome { get; set; }        //Colocando as propriedades. 
         public string CNPJ { get; set; }


         public override string ResumoCliente(){ // Feito o override.
           return  $"{NumeroConta} |  {Nome}  | {CNPJ}";  //Colocando o CNPJ.
        }
        public override double GetSaldo(double valor){ // Feito o override.
            double saldo = 0;
            foreach(Transacao transacao  in Extrato){
                saldo += transacao.Valor;
            }
            return saldo;
        }
        public override bool EhMaior(){ //Override feito, eu coloquei return true pq pode ser 
           return true;                 //necessário na frente só p passar direto no códico com a condição true.
        }                                // Não queria mudar na program
    }
}