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
                Console.WriteLine("5. Potência");
                Console.WriteLine("6. Raíz Quadrada");
                Console.WriteLine("7. Fatorial");

                opcao = int.Parse(Console.ReadLine());
                       
                switch (opcao)
                {
                    case 1:
                        
                        Console.Clear();
                        Console.WriteLine("Entre com os números:");
                        o.A = double.Parse(Console.ReadLine());
                        o.B = double.Parse(Console.ReadLine());
                        Console.WriteLine($"{o.A} - {o.B} = {o.Subtracao(o.A, o.B)}");
                        break;
                    
                    case 2:
                        
                        Console.Clear();
                        Console.WriteLine("Entre com os números:");
                        o.A = double.Parse(Console.ReadLine());
                        o.B = double.Parse(Console.ReadLine());
                        Console.WriteLine($"{o.A} + {o.B} = {o.Soma(o.A, o.B)}");
                        break;
                    
                    case 3:
                        
                        Console.Clear();
                        Console.WriteLine("Entre com os números:");
                        o.A = double.Parse(Console.ReadLine());
                        o.B = double.Parse(Console.ReadLine());
                        Console.WriteLine($"{o.A} * {o.B} = {o.Multiplicacao(o.A, o.B)}");
                        break;
                    
                    case 4:
                        
                        Console.Clear();
                        Console.WriteLine("Entre com os números:");
                        o.A = double.Parse(Console.ReadLine());
                        o.B = double.Parse(Console.ReadLine());

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

                    case 5:
                        
                        Console.Clear();
                        Console.WriteLine("Entre com os números:");
                        o.A = double.Parse(Console.ReadLine());
                        o.B = double.Parse(Console.ReadLine());

                        Console.WriteLine($"A {o.A} elevado {o.B} é {o.Potencia(o.A, o.B).ToString("F2", CultureInfo.InvariantCulture)}");
                        break;

                    case 6:
                        
                        Console.Clear();
                        Console.WriteLine("Entre com o número:");
                        o.A = double.Parse(Console.ReadLine());

                        Console.WriteLine($"A raíz quadrada de {o.A} é {o.Raiz(o.A).ToString("F2", CultureInfo.InvariantCulture)}");
                        break;
                    
                    case 7:
                        
                        Console.Clear();
                        Console.WriteLine("Entre com o número:");
                        o.C = int.Parse(Console.ReadLine());

                        if (o.C == 0)
                        {
                            Console.WriteLine("É impossível calcular o fatorial de 0.");
                            break;
                        }
                        else { 
                       
                            Console.WriteLine($"{o.C}! é {o.Fatorial(o.C)}");
                            break;

                        }
            
                }
                Console.WriteLine("Pressione qualquer tecla.");
                Console.ReadKey();
                Console.Clear();
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
