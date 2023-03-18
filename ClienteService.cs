using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M1S3_SistemaBanco
{
    public class ClienteService :IClienteService 
    {
         static List<Cliente> clientes = new List<Cliente>();

    public  void CriarConta(){
    Cliente cliente = new PessoaFisica(); // Essa vai ser a opção da pessoa física, chorou pedindo os argumentos 
    Console.WriteLine("Data de Nascimento do cliente:");
    cliente.DataNascimento = DateTime.Parse(Console.ReadLine());
    if(!cliente.EhMaior()){ // Com o override ele entende isso, mas cria um elemento meio besta na PessoaJuridica.
      Console.WriteLine("não é possivel abrir a conta pois o CLiente é menor de idade");
      return ;
    }
    Console.WriteLine("A idade do cliente é " + cliente.Idade);
    Console.WriteLine("Nome do cliente:");
    cliente.Nome = Console.ReadLine();
    Console.WriteLine("CPF do cliente:");
    cliente.CPF = Console.ReadLine();
    Console.WriteLine("Endereco do cliente:");
    cliente.Endereco = Console.ReadLine();
    Console.WriteLine("Telefone do cliente:");
    cliente.Telefone = Console.ReadLine();
    Console.WriteLine("Email do cliente:");
    cliente.Email = Console.ReadLine();
    Console.WriteLine("Numero Da Conta");
    cliente.NumeroConta = int.Parse(Console.ReadLine());
    clientes.Add(cliente);
}
public void CriarContaPessoaJuridica(){ 
// Essa vai ser a opção da pessoa juridica, então toda essa parte de idade é tirada 
   // Console.WriteLine("Data de Nascimento do cliente:");
  //  cliente.DataNascimento = DateTime.Parse(Console.ReadLine());
   // if(!cliente.EhMaior()){ // Com o override ele entende isso, mas cria um elemento meio besta na PessoaJuridica.
    //  Console.WriteLine("não é possivel abrir a conta pois o CLiente é menor de idade");
   //   return ;
    
  //  Console.WriteLine("A idade do cliente é " + cliente.Idade);

    PessoaJuridica cliente = new PessoaJuridica(); //Eu achei que tinha ficar como classe cliente, mas não tá dando certo. Se pegar a filha ele entende que são propriedades da Cliente
    Console.WriteLine("Razão social da empresa:"); // Razão social ao invés de nome 
    cliente.RazaoSocial = Console.ReadLine();
    Console.WriteLine("CNPJ da empresa:");
    cliente.CNPJ = Console.ReadLine();
    Console.WriteLine("Endereco do cliente:");
    cliente.Endereco = Console.ReadLine();
    Console.WriteLine("Telefone do cliente:");
    cliente.Telefone = Console.ReadLine();
    Console.WriteLine("Email do cliente:");
    cliente.Email = Console.ReadLine();
    Console.WriteLine("Numero Da Conta");
    cliente.NumeroConta = int.Parse(Console.ReadLine());
    //clientes.Add(cliente);
}
public Cliente BuscarClientePorNumeroDeConta (int numeroConta){; 
  foreach(Cliente cliente in clientes){
    if(cliente.NumeroConta == numeroConta){
      return cliente;
    }
  }
  // mesma coisa que o foreach
  // for(int i =0; i < clientes.Count; i++){
  //    if(clientes[i].NumeroConta == numeroConta); 'Anotação do professor'
  //     return clientes[i];
  // }
  return null;
}
public void ExibirClientes(){
   Console.WriteLine("Número da conta        | Nome         | CPF    ");
  for(int i =0; i < clientes.Count; i++){
    Console.WriteLine(clientes[i].ResumoCliente());
  }
}

    public Cliente BuscarClientePorNumeroDeConta()
    {
      throw new NotImplementedException();
    }
  }
}