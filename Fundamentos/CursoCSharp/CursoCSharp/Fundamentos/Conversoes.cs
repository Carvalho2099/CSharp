using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado;
            quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine(notaTruncada);

            Console.Write("Digite a sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine(idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine(idadeInteiro);

            Console.Write("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);
            Console.WriteLine(numero1);
            
            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2); 
            Console.WriteLine(numero2);

        }
    }
}
