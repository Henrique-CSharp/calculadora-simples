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
        
    }
}
