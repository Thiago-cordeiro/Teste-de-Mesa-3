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
    public class Problema7
    {
        public static void Exec()
        {
            {
                List<decimal> list = new List<decimal>();
                List<decimal> taxas = new List<decimal> { 0.03m / 30, 0.0248m / 30, 0.02m / 30 };

                decimal p;
                int mes = (8 * 30) + 10; 
                decimal fator;
                int esc = 1;

                while (esc != 0)
                {
                    Console.WriteLine("Adicione o valor presente:");
                    p = decimal.Parse(Console.ReadLine());
                    list.Add(p);

                    Console.WriteLine("Deseja adicionar mais? 1 para sim e 0 para não:");
                    esc = int.Parse(Console.ReadLine());
                }

                foreach (decimal vpOriginal in list)
                {
                    Console.WriteLine("=============================================================================");
                    foreach (decimal taxa in taxas)
                    {
                        fator = 1;
                        decimal somaTaxa = taxa + 1;
                        decimal saldo = vpOriginal;
                        int diaSaque = 5 * 30;
                        decimal saque = 500m; 

                        for (int j = 1; j <= mes; j++)
                        {
                            saldo *= somaTaxa;

                            if (j == diaSaque)
                            {
                                Console.WriteLine($"Saque realizado no 5 mes: {saque:C}");
                                saldo -= saque;
                            }
                        }

                        Console.WriteLine($"| Valor investido: {vpOriginal:C} | Valor futuro após saque: {saldo:C} | Taxa ao dia: {taxa:F6} |");
                        Console.WriteLine($"--");
                    }
                }
            }
        }
    }
}