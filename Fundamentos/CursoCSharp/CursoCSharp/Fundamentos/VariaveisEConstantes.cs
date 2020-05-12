using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area da circuferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            //PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine($"Área é {area}");

            //tipos internos

            bool estaChovendo = true;
            Console.WriteLine($"Está chovendo {estaChovendo}");

            byte idade = 45;
            Console.WriteLine($"Idade {idade}");

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine($"O saldo de gols {saldoDeGols}");

            short salario = short.MaxValue;
            Console.WriteLine($"Salário {salario}");

            int menorValorInt = int.MinValue;
            Console.WriteLine($"Menor valor int {menorValorInt}");

            uint populacaoBrasileita = 207_600_000;
            Console.WriteLine($"população brasileira {populacaoBrasileita}");

            long menorValorLong = long.MinValue;
            Console.WriteLine($"Menor valor long {menorValorLong}");

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine($"população Mundial {populacaoMundial}");

            float precoComputador = 1299.99f;
            Console.WriteLine($"preço do comptuador {precoComputador}");

            double valorDeMercadoDaApple = 1_000_000_000_000.00;
            Console.WriteLine($"Valor de mercado da Apple {valorDeMercadoDaApple}");

            decimal distanciaEntreAsEstrelas = decimal.MaxValue;
            Console.WriteLine($"Distancia entre esttrelas {distanciaEntreAsEstrelas}");

            char letra = 'a';
            Console.WriteLine($"letra {letra}");

            string texto = "Seja bem vindo ao Curso de C#";
            Console.WriteLine(texto);
        }
    }
}
