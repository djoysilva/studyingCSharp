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
            bool i = true;
            int num = 0, resp = 0, opcao = 0;
            char operador;
            while (i)
            {
                Console.WriteLine("Deseja informar um novo número (1) ou operador(2)?");
                opcao = Console.Read();
                if (opcao == '2')
                {
                    Console.WriteLine("Informe o operador: ");
                    opcao = Console.Read();
                    operador = Convert.ToChar(opcao);
                  
                    if (resp != 0)
                    {
                        Console.WriteLine("Informe um número: ");
                        num = Console.Read();
                    }else
                    {
                        Console.WriteLine("Informe um número: ");
                        resp = Console.Read();
                        Console.WriteLine("Informe um novo número: ");
                        resp = Console.Read();
                    }

                    Console.WriteLine(resp);
                    switch (operador)
                    {
                        case '+': resp = resp + num;
                                  break;
                        case '-': resp = resp - num;
                                  break;
                        case '*': resp = resp * num;
                                  break;
                        case '/':
                                  if (num != 0)
                                  {
                                    resp = resp / num;
                                  }else
                                  {
                                    Console.WriteLine("Erro. Tentativa de divisão por 0");
                                  }
                                 break;
                        default: break;     
                    }
                }
                else
                {
                    Console.WriteLine("Informe um número: ");
                    resp = Console.Read();
                }
                Console.WriteLine("\nResposta:" + resp);
                Console.WriteLine("Deseja continuar? (S ou N)");
                opcao = Console.Read();
                opcao = Convert.ToChar(opcao);
                if (opcao == 'S')
                {
                    i = true;
                }
                else
                {
                    i = false;
                }
            }
            
        }
    }
}
