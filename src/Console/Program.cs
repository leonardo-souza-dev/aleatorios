using System;
using System.Collections.Generic;

namespace Exercicio
{
    public class Program
    {
        static void Main(string[] args)
        {
            int qtd;

            if (args == null || args.Length == 0 || string.IsNullOrEmpty(args[0]))
            {
                qtd = 1;
            }
            else
            {
                qtd = Convert.ToInt32(args[0]);
            }

            for(int i = 0; i < qtd; i++)
            {
                List<string> numeros = new Gerador().Gerar();
                Console.WriteLine(string.Join(' ', numeros));    
            } 
        }
    }
}
