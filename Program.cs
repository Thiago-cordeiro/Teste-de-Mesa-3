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

    class program
    {
        static void Main(string[] args)
        {
            string escolha;
            do
            {
                Console.WriteLine("\nEscolha um exercício 6, 7, 8 ou 0 para sair:\n");
                escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "6":
                        Problema6.Exec();
                        break;
                    case "7":
                        Problema7.Exec();
                        break;
                    case "8":
                        Problema8.Exec();
                        break;
                    case "0":
                        Console.WriteLine("Ssaindoo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

            } while (escolha != "0");
        }
    }
}
