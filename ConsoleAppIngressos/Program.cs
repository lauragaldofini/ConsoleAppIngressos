using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppIngressos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int totalIngressos = 30;
            int ingressosVendidos = 0;
            int ingressosIntegrais = 0;
            int ingressosMeia = 0;
            decimal faturamentoTotal = 0;

            for (int i = 1; i <= totalIngressos; i++)
            {
                decimal precoIngresso = 0;

                if (i <= 10)
                {
                    precoIngresso = 100.00m;
                }
                else if (i <= 20)
                {
                    precoIngresso = 150.00m;
                }
                else
                {
                    precoIngresso = 200.00m;
                }

                Console.WriteLine($"Ingresso {i}: R${precoIngresso}");

                // Simulação de pagamento, 0 para estudante e 1 para inteira
                Random rnd = new Random();
                int tipoIngresso = rnd.Next(0, 2);

                if (tipoIngresso == 0)
                {
                    ingressosMeia++;
                    precoIngresso /= 2; // Metade do preço para estudantes
                }
                else
                {
                    ingressosIntegrais++;
                }

                faturamentoTotal += precoIngresso;
                ingressosVendidos++;
            }

            Console.WriteLine($"Faturamento total: R${faturamentoTotal}");
            Console.WriteLine($"Quantidade de ingressos pagos integralmente: {ingressosIntegrais}");
            Console.WriteLine($"Quantidade de meia entrada: {ingressosMeia}");
        }
    }
}

    