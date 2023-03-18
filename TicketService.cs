using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace M1S3_SistemaBanco
{
    public class TicketService
    {
  private ClienteService _clienteService = new ClienteService(); 
  public  void AdicionarTransacao(){
  Console.WriteLine("Qual a conta?");
  int numeroConta = int.Parse(Console.ReadLine());

  Cliente contaCliente = _clienteService.BuscarClientePorNumeroDeConta(numeroConta);

  if (contaCliente == null){
    Console.WriteLine("Conta não cadastrada, por favor cadastre uma conta antes"); // Alterando bobagem 
    return;
  }

  Console.WriteLine("Qual o valor da transação?" );
  double valor = double.Parse(Console.ReadLine());
  Transacao transacao = new Transacao(DateTime.Now, valor);

  contaCliente.Extrato.Add(transacao);

}
public void ExibirExtrato(){
  Console.WriteLine("Qual a conta?");
  int numeroConta = int.Parse(Console.ReadLine());

  Cliente contaCliente = _clienteService.BuscarClientePorNumeroDeConta(numeroConta);

  if (contaCliente == null){
    Console.WriteLine("Conta não cadastrada, favor cadastrar antes");
    return;
  }
  double saldo = 0;
  foreach(Transacao transacao  in contaCliente.Extrato){
    Console.WriteLine(" Data: " + transacao.Data + " Valor: " + transacao.Valor.ToString("C2", new CultureInfo("pt-BR")) );
    saldo += transacao.Valor;
    //Console.WriteLine($"Data: {transacao.Data} Valor: R$  {transacao.Valor}" ); 'Anotação do professor'
  }

  Console.WriteLine("Saldo = " + contaCliente.Saldo);

}
    }
}