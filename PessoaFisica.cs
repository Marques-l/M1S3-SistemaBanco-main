using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M1S3_SistemaBanco
{
    public class PessoaFisica :Cliente // Herdando a classe cliente 
    {
         public string Nome { get; set; }   //Colocando as propriedades.
         public string CPF { get; set; }
         public override string ResumoCliente(){ // Feito o override.
           return  $"{NumeroConta} |  {Nome}  | {CPF}"; //Com o CPF para a pessoa física.
        }
        public override double GetSaldo(double valor){ // Feito o override.
            double saldo = 0;
            foreach(Transacao transacao  in Extrato){
                saldo += transacao.Valor;
            }
            return saldo;
        }
        public override bool EhMaior(){ //Override feito
            return Idade >= 18;
        }
    }
}