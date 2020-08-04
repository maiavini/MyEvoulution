using System;

namespace Entrega_Doc
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente Celeiro = new Cliente("Celeiro", 27421093, "Leticia", "celeiro@yahoo.com", 74);

            Departamento Fiscal = new Departamento("Fiscal", "Vinicius");

            Documento Livros = new Documento(2, "Livros Fiscais");

            Entrega entrega = new Entrega(Fiscal, "03/08/2020");


        }
    }
}
