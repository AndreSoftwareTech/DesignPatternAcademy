using PadroesCriacao.PatternsCriacao.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesCriacao.PatternsCriacao.Repositories
{
    public class TradicionalRepository: IServico
    {
        public TradicionalRepository()
        {
            Console.WriteLine("Tradicional");
        }

        public void ExecutaCobranca()
        {
            
        }
    }
}
