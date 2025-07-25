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
    public class Problema8
    {
        public static void Exec()
        {
            Console.Write("Digite o valor presente: ");
            decimal valorPresente = decimal.Parse(Console.ReadLine());

            Console.Write("Digite a taxa de juros mensal (%): ");
            decimal taxaMensal = decimal.Parse(Console.ReadLine()) / 100m;

            Console.Write("Digite quantos meses: ");
            int meses = int.Parse(Console.ReadLine());

            Console.Write("Digite quantso dias extras: ");
            int diasExtras = int.Parse(Console.ReadLine());

            Console.Write("Digite o mes do saque: ");
            int mesDoSaque = int.Parse(Console.ReadLine());

            Console.Write($"Digite o valor a ser sacado no {mesDoSaque} mês: ");
            decimal valorSaque = decimal.Parse(Console.ReadLine());

            DateTime dataAtual = DateTime.Today;

            decimal saldo = valorPresente;
            decimal rendimentoTotal = 0;

            Console.WriteLine("\nMês | Data       | Valor ant  | Saque | Rendimento Mês | qtd saldo");
            Console.WriteLine("--------------------------------------------------------------------------");

            double fator = Math.Pow(1 + (double)taxaMensal, 1);

            for (int i = 1; i <= meses; i++)
            {
                decimal saldoAntes = saldo;
                saldo *= (decimal)fator;

                decimal rendimentoMes = saldo - saldoAntes;
                rendimentoTotal += rendimentoMes;

                decimal saqueMes = 0;
                if (i == mesDoSaque)
                {
                    saqueMes = valorSaque;
                    saldo -= saqueMes;
                    Console.WriteLine($"Saque de {valorSaque:C} realizado em {dataAtual:dd/MM/yyyy}");
                }
                Console.WriteLine($"{i,3} | {dataAtual:dd/MM/yyyy} | {saldoAntes:C} | {saqueMes,8:C} | {rendimentoMes:C} | {saldo:C}");

                dataAtual = dataAtual.AddMonths(1);
            }

            int diasFinais = diasExtras;
            int diasDoMesFinal = DateTime.DaysInMonth(dataAtual.Year, dataAtual.Month);
            double fatorDias = Math.Pow(1 + (double)taxaMensal, (double)diasFinais / diasDoMesFinal);
            decimal saldoAntesExtra = saldo;
            saldo *= (decimal)fatorDias;
            decimal rendimentoDias = saldo - saldoAntesExtra;
            rendimentoTotal += rendimentoDias;

            Console.WriteLine("\n");
            Console.WriteLine($"Dias extras: {diasExtras} dias");
            Console.WriteLine($"Rendimento nos dias extras: {rendimentoDias:C}");
            Console.WriteLine($"Saldo final após {meses} meses e {diasExtras} dias: {saldo:C}");

            Console.WriteLine("\n");
            Console.WriteLine($"Valor Presente Investido: {valorPresente:C}");
            Console.WriteLine($"Taxa de Juros Mensal: {taxaMensal:P2}");
            Console.WriteLine($"Rendimento Total: {rendimentoTotal:C}");
            Console.WriteLine($"valor futuro(liquido): {saldo:C}");
        }
    }
}

