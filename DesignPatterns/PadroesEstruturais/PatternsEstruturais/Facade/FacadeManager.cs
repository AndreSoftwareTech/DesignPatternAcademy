using PadroesEstruturais.PatternsEstruturais.Facade.AmbienteComplexo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesEstruturais.PatternsEstruturais.Facade;

public class FacadeManager
{
    public void ExecutarComplexidade()
    {
        ZonaNorte zonaNorte = new ZonaNorte();
        ZonaSul zonaSul = new ZonaSul();
        CloudComputing cloudComputing = new CloudComputing();

        var sul = zonaSul.ExecutaRotinaVendaPerdidas(DateTime.Now);
        var norte = zonaNorte.ExecutaRotinaVendaPerdidas(DateTime.Now);

        cloudComputing.GeraRealtorioPerdasGanhos(sul, norte);

    }
}
