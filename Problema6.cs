using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeMesa3
{
    public class Problema6
    {
        public static void Exec()
        {

            List<decimal> taxasMensais = [0.03m, 0.0248m, 0.02m];
            List<decimal> valores = new List<decimal>();

            int esc = 1;

            while (esc != 0)
            {
                Console.Write("Digite o valor presente investido: ");
                decimal valor = decimal.Parse(Console.ReadLine());
                valores.Add(valor);

                Console.Write("Deseja adicionar mais valores? 1 sim / 0 não: ");
                esc = int.Parse(Console.ReadLine());
            }

            DateTime dataInicial = DateTime.Today;
            DateTime dataFinal = dataInicial.AddMonths(8).AddDays(10);

            int totalDias = (dataFinal - dataInicial).Days;

            Console.WriteLine("\n================================================================\n");

            foreach (decimal vp in valores)
            {
                Console.WriteLine($"Valor Presente: {vp:C}\n");

                foreach (decimal taxaMensal in taxasMensais)
                {
                    decimal taxaDiaria = taxaMensal / 30m;
                    decimal saldo = vp;

                    for (int i = 0; i < totalDias; i++)
                    {
                        saldo *= (1 + taxaDiaria);
                    }

                    Console.WriteLine($"  Taxa mensal: {taxaMensal:P2}");
                    Console.WriteLine($"  dias: {totalDias} ");
                    Console.WriteLine($"  Valor Futuro: {saldo:C}\n");
                }

                Console.WriteLine("------------------------------------------------------------\n");
            }

            Console.WriteLine("=======================================================================");
        }
    }
}
