using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            string fechar;
            int valor1, valor2,total,operador;
            bool Ligado = true;
            while (Ligado) {
                Console.WriteLine("A calculadora foi iniciada");
                Console.WriteLine("Digite o primeiro valor");
                valor1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Escolha o operador 1: + , 2: * , 3: / , 4: -");
                operador = Convert.ToInt32(Console.ReadLine());
                while (operador > 4 || operador < 1)
                {
                    Console.WriteLine("Escolha o operador 1: + , 2: * , 3: / , 4: -");
                    operador = Convert.ToInt32(Console.ReadLine());
                    
                }


                Console.WriteLine("Digite o segundo valor");
                valor2 = Convert.ToInt32(Console.ReadLine());
                if (operador == 1)
                {
                    total = valor1 + valor2;
                    Console.WriteLine("total: " + total);
                }
                if (operador == 2)
                {
                    total = valor1 * valor2;
                    Console.WriteLine("total: " + total);
                }

                if (operador == 3)
                {
                    total = valor1 / valor2;
                    Console.WriteLine("total: " + total);
                }

                if (operador == 4)
                {
                    total = valor1- valor2;
                    Console.WriteLine("total: " + total);
                }
                Console.WriteLine("Se quiser fechar a calculadora digite D ");
                fechar = Convert.ToString(Console.ReadLine());
                if (fechar == "d")
                {
                    break;
                }
                else
                {

                }

                Console.ReadKey();

            }
        }
    }
}
