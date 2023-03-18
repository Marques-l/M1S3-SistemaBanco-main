using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M1S3_SistemaBanco
{
    public interface IClienteService
    {
        void CriarConta(); 
        void CriarContaPessoaJuridica(); 
        Cliente BuscarClientePorNumeroDeConta(); 
        void ExibirClientes(); 
    }
}