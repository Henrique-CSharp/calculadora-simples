using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Operacao o = new Operacao();

            int opcao, confirmacao;
                
            
            Console.WriteLine("CALCULADORA SIMPLES");
            do { 
                
                Console.WriteLine("Qual operação deseja fazer?");
                Console.WriteLine("1. Subtração");
                Console.WriteLine("2. Adição");
                Console.WriteLine("3. Multiplicação");
                Console.WriteLine("4. Divisão");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine("Entre com os números:");
                
                o.A = double.Parse(Console.ReadLine());
                o.B = double.Parse(Console.ReadLine());
                
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine($"{o.A} - {o.B} = {o.Subtracao(o.A, o.B)}");
                        break;
                    
                    case 2:
                        Console.WriteLine($"{o.A} + {o.B} = {o.Soma(o.A, o.B)}");
                        break;
                    
                    case 3:
                        Console.WriteLine($"{o.A} * {o.B} = {o.Multiplicacao(o.A, o.B)}");
                        break;
                    
                    case 4:
                        
                        if (o.A == 0 || o.B == 0) 
                        {

                            Console.WriteLine("Impossivel fazer divsão por 0.");
                            break;
                        }
                        else 
                        { 

                            Console.WriteLine($"{o.A} / {o.B} = {o.Divisao(o.A, o.B).ToString("F2", CultureInfo.InvariantCulture)}");
                             break;
                        }

                    default:
                            Console.WriteLine("Voltando ao menu principal.");
                        break;
                }
                Console.WriteLine("Pressione 1 para voltar ao munu de operações ou 0 para sair.");
                confirmacao = int.Parse(Console.ReadLine());

                if (confirmacao != 0)
                {
                    continue;
                }
                else
                {
                    opcao = confirmacao;
                    
                }
               
       

               
            } while (opcao != 0);
            
            Console.WriteLine("Programa encerrado.");
            Environment.Exit(0);
            
        }
    }
}
