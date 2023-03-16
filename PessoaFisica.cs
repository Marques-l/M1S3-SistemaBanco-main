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
        public override bool EhMaior(){ // Se colocasse só nessa classe muito do que está no código teria que mudar, 
            return Idade >= 18;        // preferi criar pelo abstract e retornar true no PessoaJuridica
        }

    protected override double GetSaldo() //Implementou uma classe protected, indicação do VsCode
    {
      throw new NotImplementedException();
    }

    
  }
}