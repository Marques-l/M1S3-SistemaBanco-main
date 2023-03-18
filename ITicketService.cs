using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M1S3_SistemaBanco
{
    public interface ITicketService
    {
        void AdicionarTransacao(); 
        void ExibirExtrato(); 
    }
}