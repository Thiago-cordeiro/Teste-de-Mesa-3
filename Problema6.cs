using System;
using System.Collections.Generic;
using System.ComponentModel;
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

            //PROBLEMA 6:	Crie uma Tabela e Programa C# que leia um menu para diversos valores da Entrada. 8 meses e 10 dias

            List<decimal> list = new List<decimal>();
            List<decimal> taxas = [0.03m/30, 0.0248m/30, 0.02m/30];

            decimal p;
            int mes = (8*30)+10;
            decimal fator = 1;

            int esc = 1;

            while (esc != 0)
            {
                Console.WriteLine($"Adicione o valor presentes");
                p = decimal.Parse(Console.ReadLine());
                list.Add(p);

                Console.WriteLine($"Deseja adicionar mais? 1 para sim e 0 para nao");
                esc = int.Parse(Console.ReadLine());
            }


            foreach (int vp in list)
            {
                Console.WriteLine($"=============================================================================");
                foreach (decimal taxa in taxas)
                {
                    
                    fator = 1;
                    decimal somaTaxa = taxa + 1;
                    for (int j = 1; j <= mes; j++)
                    {
                        fator *= somaTaxa;

                    }
                    decimal F = vp * fator;
                    Console.WriteLine($"| valor investido: {vp:C} | valor futuro é : {F:C} | taxa ao dia: {taxa} |");

                }
            }
            
        }
    }
}