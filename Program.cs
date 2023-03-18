
using System.Globalization;
using M1S3_SistemaBanco;
IClienteService  _clienteService = new ClienteService(); 
ITicketService _ticketeService = new TicketService(); 

string opcao;
do{
  Console.WriteLine("Bem vindos ao Banco FULL STACK BANCK, escolha uma opção");
  Console.WriteLine("1 - Criar Conta - Pessoa Física");
  Console.WriteLine("2 - Adicionar Transacao");
  Console.WriteLine("3 - Consultar Extrato");
  Console.WriteLine("4 - Sair");
  Console.WriteLine("5 - Exibir Clientes");
  Console.WriteLine("6 - Criar Conta - Pessoa Jurídica");
  opcao = Console.ReadLine();

  if(opcao == "1"){
    _clienteService.CriarConta(); 
  }
  else if (opcao == "5"){
    _clienteService.ExibirClientes();
  }
  else if (opcao == "2"){
    _ticketeService.AdicionarTransacao();
  }
  else if (opcao == "3"){
    _ticketeService.ExibirExtrato();
  }
  else if (opcao == "6"){
    _clienteService.CriarContaPessoaJuridica(); 
  }

  Console.WriteLine("Tecle Enter para continuar");
  Console.ReadLine();
} while(opcao != "4");