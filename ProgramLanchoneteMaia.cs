using System;

namespace LanchoneteMaia
{
    class Program
    {
        

        static void Main(string[] args)
        {
            double total = 0;

            Console.Title = "Lanchonete Maia";

            Console.WriteLine("Quantos pedidos deseja fazer ? ");
            int qnt = int.Parse(Console.ReadLine());


            for (int i = 0; i < qnt; i++)
            {
                Console.WriteLine("+++++ Opções de Lanches +++++");
                Console.WriteLine("[1] Dogão Simples R$ 6,25 ");
                Console.WriteLine("[2] Dogão Duplo R$ 6,75 ");
                Console.WriteLine("[3] X-Salada R$ 10,75 ");
                Console.WriteLine("[4] X-Egg R$ 11,75 ");
                Console.WriteLine("[5] X-Bacon R$ 13,50 ");
                int codigo = int.Parse(Console.ReadLine());

                double pedido = 0;
                switch (codigo)
                {
                    case 1:
                        pedido = 6.25;
                        break;

                    case 2:
                        pedido = 6.75;
                        break;
                    case 3:
                        pedido = 10.75;
                        break;
                    case 4:
                        pedido = 11.75;
                        break;
                    case 5:
                        pedido = 13.50;
                        break;
                }

                total = pedido;


                Console.Clear();
  

            }

            total += total;

            Console.WriteLine("Pedido Finalizado.");
            Console.WriteLine("Valor total a pagar é de R$ " + total);



            Console.Read();

            

           
            
            


        }
    }
}
