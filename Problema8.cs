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
            {
                List<decimal> list = new List<decimal>();
                List<decimal> taxas = new List<decimal>();

                decimal p;
                int mes;
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

                Console.WriteLine("Qauntos meses deseja ?");
                mes = int.Parse(Console.ReadLine());
                mes = mes * 30;

                Console.WriteLine("Quantos dias a mais?");
                mes = mes + int.Parse(Console.ReadLine());
                


                esc = 1;

                while (esc != 0)
                {
                    Console.WriteLine("Adicione o valor da taxa(mes) em porcetagem:");
                    p = decimal.Parse(Console.ReadLine());
                    p = p / 100m;
                    p = p / 30;
                    taxas.Add(p);

                    Console.WriteLine("Deseja adicionar mais? 1 para sim e 0 para não:");
                    esc = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Digite o mes de saque");
                int diaSaque = int.Parse(Console.ReadLine()) * 30;
                Console.WriteLine("Digite a quantidade do saque");
                decimal saque = decimal.Parse(Console.ReadLine());

                foreach (decimal vpOriginal in list)
                {
                    Console.WriteLine("=============================================================================");
                    foreach (decimal taxa in taxas)
                    {
                        fator = 1;
                        decimal somaTaxa = taxa + 1;
                        decimal saldo = vpOriginal;


                        for (int j = 1; j <= mes; j++)
                        {
                            saldo *= somaTaxa;

                            if (j == diaSaque)
                            {
                                Console.WriteLine($"Saque realizado no {j/30} mes: {saque:C}");
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