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
            string x;
            char operador, i = 'S';
            while (i == 'S')
            {
                Console.WriteLine("Informe um número: ");
                x = Console.ReadLine();
                resp = Int32.Parse(x);

                Console.WriteLine("Informe outro número: ");
                x = Console.ReadLine();
                num = Int32.Parse(x);

                Console.WriteLine("Informe a operação (+, -, *, /)");
                x = Console.ReadLine();
                operador = Convert.ToChar(x);
                     
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
                x = Console.ReadLine().ToUpper();
                i = Convert.ToChar(x);

                if (i != 'S')
                {
                    i = 'N';
                }
            }
            
        }
    }
}
