﻿using System;

namespace MediaGeralPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "### Média Geral dos Alunos ###";

            Console.Write("Quantos Alunos ? ");
            int nalunos = int.Parse(Console.ReadLine());
     
            Aluno[] alunos = new Aluno[nalunos];//Aluno é o tipo do Array ; nalunos é o tamanho do Array;

            for (int i = 0; i < alunos.Length; i++)
            {
                Console.Clear();

                Console.Write("Aluno # : " + ( i + 1) + " Nome.. ");
                string nome = Console.ReadLine();

                Console.Write("Aluno # : " + (i + 1) + " Provas.. "); 
                int provas = int.Parse(Console.ReadLine());

                alunos[i] = new Aluno(nome, provas);

                Console.Write("Insira as notas do aluno " + nome);
                alunos[i].InserirNotas();
            }











        }
    }
}
