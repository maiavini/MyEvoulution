using System;
using System.Collections.Generic;
using System.Text;

namespace MediaGeralPoo
{
    class Aluno
    {
        public string Nome { get; private set; }

        private double[] _notas;

        public double Media
        {
            get
            {
                return CalcularMedia();
            }
        }

        public Aluno(string nome, int provas)
        {
            Nome = nome;
            _notas = new double[provas];


        }

        public void InserirNotas()
        {
            for (int i = 0; i < _notas.Length; i++)
            {
                Console.WriteLine(" Nota # " + (i + 1));
                _notas[i] = double.Parse(Console.ReadLine());//Conversão do número pois Read, sempre lê STRING
            }
        }

        private double CalcularMedia()
        {
            double total = 0;

            for (int i = 0; i < _notas.Length; i++)
            {
                total += _notas[i];
            }

            return total / _notas.Length;
        }


    }
}
