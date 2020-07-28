using System;

namespace CaculadoraST
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorProdutos, valorIPI, MVA, valorMVA, total, baseCalculo, pagST;
            double ICMS, ICMSexterno;
            int opcao;

            Console.WriteLine("Operação Interna [1]");
            Console.WriteLine("Operação Interestadual [2]");
            opcao = int.Parse(Console.ReadLine());


            if(opcao == 1)
            {
                ICMS = 20;
                ICMSexterno = 20;
            }
            else
            {
                ICMS = 19;
                ICMSexterno = 12;
            }

            Console.Clear();
           

            Console.Write("Qual o valor da Mercadora ? R$ ");
            valorProdutos = double.Parse(Console.ReadLine());

            Console.Write("Valor de IPI ? R$ ");
            valorIPI = double.Parse(Console.ReadLine());

            Console.Write("Porcentagem da MVA(Margem de Valor Agregado) ? ");
            MVA = double.Parse(Console.ReadLine());

            total = valorProdutos + valorIPI;
            valorMVA = total * MVA / 100;
            baseCalculo = valorMVA + total;
            pagST = (baseCalculo * ICMS / 100) - (valorProdutos * ICMSexterno / 100);

            Console.Clear();

            Console.WriteLine("O ICMS ST Retido será de " + pagST);
            

            





        }
    }
}
