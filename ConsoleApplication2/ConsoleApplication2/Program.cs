using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, resp = 0;
            char operador, i = 'S';

            while (i == 'S')
            {
                Console.WriteLine("Informe um número: ");
                resp = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Informe outro número: ");
                num = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Informe a operação (+, -, *, /)");
                operador = Convert.ToChar(Console.ReadLine());
                     
                switch (operador)
                {
                    case '+': resp = resp + num;
                              break;
                    case '-': resp = resp - num;
                              break;
                    case '*': resp = resp * num;
                              break;
                    case '/': if (num != 0)
                              {
                                 resp = resp / num;
                              }
                              else
                              {
                                 Console.WriteLine("Erro. Tentativa de divisão por 0");
                              }
                                 break;
                   default: break;     
                }
                Console.WriteLine("\nResultado: " + resp);
                Console.WriteLine("Deseja continuar? (S ou N)");
                i = Convert.ToChar(Console.ReadLine().ToUpper());
            }
            
        }
    }
}
