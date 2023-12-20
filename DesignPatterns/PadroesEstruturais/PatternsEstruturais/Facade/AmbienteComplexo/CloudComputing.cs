using System;
using System.Collections.Generic;

namespace PadroesEstruturais.PatternsEstruturais.Facade.AmbienteComplexo;

public class CloudComputing
{
    public void GeraRealtorioPerdasGanhos(List<object> sul, List<object> norte)
    {
        // Lógica para geração e apresentação de relatório de perdas e ganhos
        Console.WriteLine("Gerando e apresentando relatório de perdas e ganhos:");

        // Simulando a apresentação de dados
        Console.WriteLine("Região Sul:");
        ApresentaDados(sul);

        Console.WriteLine("Região Norte:");
        ApresentaDados(norte);
    }

    private void ApresentaDados(List<object> dados)
    {
        foreach (var item in dados)
        {
            Console.WriteLine($"Cliente: {((dynamic)item).Cliente}, Valor Perdido: {((dynamic)item).ValorPerdido}");
        }
    }

}
