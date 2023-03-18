
using System.Globalization;
using M1S3_SistemaBanco;
ClienteService  _clienteService = new ClienteService(); 
TicketService _ticketeService = new TicketService(); 

//clientes.Add(new Cliente("Vitor", "123456", "vitor@email","123", "rua", // 'Ocultando isso por enquando, era só exemplo de qualquer
                                                                            // forma'
       //      new DateTime(2002, 5, 15), 1));
            
//clientes.Add(new Cliente("Fernando", "123456", "Fernando@email","123", "rua",// Ia passar um vazio mas já tem um de mesmo nome com 
       //      new DateTime(2002, 5, 15), 2));                                 // a lista que pode ficar bagunçado com o return. 
            
//clientes.Add(new Cliente("Vanessa", "123456", "Vanessa@email","123", "rua",
        //     new DateTime(2002, 5, 15), 3));
           

///clientes.Add(new Cliente("Lucas", "123456", "Lucas@email","123", "rua",
 //           new DateTime(2002, 5, 15), 4));



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