using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M1S3_SistemaBanco.Model
{
    public class PessoaFisica :Cliente // Herdando a classe cliente 
    {
         public new string Nome { get; set; }   //Colocando as propriedades.
         public new string CPF { get; set; } // O VsCode deu essa opção de new para omitir 
         public new double Saldo {  get {return GetSaldo(); }  private set{} }

    public PessoaFisica(){

        }
          public PessoaFisica(string nome, string cpf, double saldo){
          Nome =nome; 
          CPF = cpf; 
          Saldo = saldo; 
        }
       
         public override string ResumoCliente(){ // Feito o override.
           return  $"{NumeroConta} |  {Nome}  | {CPF}"; //Com o CPF para a pessoa física.
        }
        public override double GetSaldo(){ // Feito o override.
            double saldo = 0;
            foreach(Transacao transacao  in Extrato){
                saldo += transacao.Valor;
            }
            return saldo;
        }
        public override bool EhMaior(){ // Se colocasse só nessa classe muito do que está no código teria que mudar, 
            return Idade >= 18;        // preferi criar pelo abstract e retornar true no PessoaJuridica
        }

    
  }
}