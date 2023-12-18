using PadroesCriacao.PatternsCriacao.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesCriacao.PatternsCriacao.Repositories
{
    public class MasterRepository: IServico
    {
        public MasterRepository()
        {
            Console.WriteLine("Master");
        }

        public void ExecutaCobranca()
        {
            
        }
    }
}
