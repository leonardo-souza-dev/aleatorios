using System.Collections.Generic;
using System;

namespace Exercicio
{
    public class Gerador
    {
        public List<string> Gerar()
        {
            List<string> numeros = new List<string>();
            Random r = new Random();

            for(int i = 0; i < 6; i++)
            {
                int numero = r.Next(1, 60);
                string numeroFormatado = numero.ToString().PadLeft(2, '0');

                if (!numeros.Contains(numeroFormatado))
                    numeros.Add(numeroFormatado);
                else
                {
                    i--;
                    Console.WriteLine($"ocorreu repeticao, numero era {numero}. Horario {DateTime.Now.Ticks.ToString()}");
                }
            }

            numeros.Sort();

            return numeros;
        }
    }
}