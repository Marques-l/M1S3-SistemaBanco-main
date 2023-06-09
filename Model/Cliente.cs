
namespace M1S3_SistemaBanco.Model
{
    public abstract class Cliente //Transformado em abstract.
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public DateTime DataNascimento { get; set; }
        public int NumeroConta { get; set; }
        public double Saldo {  get {return GetSaldo(); }  private set{} } //Tirei o private daqui, pois ele não conseguiria preecher isso aqui, acho. 


     public int Idade { get {return (int)(Math.Floor((DateTime.Now - DataNascimento).TotalDays / 365.25)); } private set {} }
        
        public List<Transacao> Extrato { get; set; }
        

        public Cliente()
        {
            Extrato = new List<Transacao>();
        }
        public Cliente(string nome, string cpf, string email, string telefone, 
                       string end, DateTime dtNascimento,int numeroConta ) :this()
        {
            Nome = nome;
            CPF = cpf;
            Email=email;
            Telefone =telefone; 
            Endereco = end;
            DataNascimento = dtNascimento;
            NumeroConta = numeroConta;
            
        }


        public abstract string ResumoCliente(); //Transformando o ResumoCliente em abstract.
       
        public abstract bool EhMaior();

        public virtual double GetSaldo() // Tentando pelo virtual para manter a estrutura e ver se ele retorna o saldo
        {
            return Saldo; 
        } 
        
  }
}
