using PadroesCriacao.PatternsCriacao.FactoryMethod.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesCriacao.PatternsCriacao.FactoryMethod;

public class Cliente
{
    public void Executar ()
    { 
        var cliente = new SelecionaServico();
        var continuar = true;
        while (continuar)
        { 

            Console.WriteLine("Selecione O Tipo de Servico");
            Console.WriteLine("0- Tradicional");
            Console.WriteLine("1- Premium");
            Console.WriteLine("2- Master");
            Console.WriteLine("3- Cobertura");
            Console.WriteLine("Digite o numero do servico desejado");

            int tipoServico = Convert.ToInt32 (Console.ReadLine());
            var servicoProduto = cliente.FabricarProduto((eTiposServicos)tipoServico);

            Console.WriteLine("Deseja Continuar?\n1-Sim\n2-nao");
            int resp = Convert.ToInt32(Console.ReadLine());
            continuar = resp == 1;

        }
    }

    } 


