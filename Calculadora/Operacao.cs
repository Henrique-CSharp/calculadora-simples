using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Operacao
    {
        public double A;
        public double B;
        public int C;

        public double Subtracao(double a, double b)
        {
           return a - b;
        }
        
        public double Soma(double a, double b)
        {
           return a + b;
        }
        
        public double Multiplicacao(double a, double b)
        {
           return a * b;
        }
        
        public double Divisao(double a, double b)
        {
           return a / b;
        }

        public double Potencia(double a, double b)
        {
           return Math.Pow(a, b);
        }

        public double Raiz(double a)
        {
           return Math.Sqrt(a);
        }

        public int Fatorial(int a)
        { 
           int resultado = 1;
           for (int i = a; i > 1; i--)
             
               resultado = resultado * i;

        return resultado;

            }
            

        }

        

     
        
    
}
