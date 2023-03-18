using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M1S3_SistemaBanco.Model;

namespace M1S3_SistemaBanco.Interfaces
{
    public interface IClienteService
    {
        void CriarConta(); 
        void CriarContaPessoaJuridica(); 
        Cliente BuscarClientePorNumeroDeConta(); 
        void ExibirClientes(); 
    }
}