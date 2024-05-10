using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_bootcamp.models
{
    public class Calculadora
    {
        public void Somar(int x, int y) {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtrair(int x, int y) {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y) {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }

        public void Dividir(int x, int y) {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Potencia(int x, int y) {
            Console.WriteLine($"{x} ^ {y} = {Math.Pow(x, y)}");
        }

        public void Seno(double angulo) {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano); 
            Console.WriteLine($"O seno de {angulo} é {Math.Round(seno, 4)}");
        }

        public void Cosseno(double angulo) {
            double radiano = angulo * Math.PI / 180;
            double cosseno = Math.Cos(radiano); 
            Console.WriteLine($"O seno de {angulo} é {Math.Round(cosseno, 4)}");
        }

        public void Tangente(double angulo) {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano); 
            Console.WriteLine($"A tangente de {angulo} é {Math.Round(tangente, 4)}");
        }

        public void RaizQuadrada(double numero) {
            double raiz = Math.Sqrt(numero);
            Console.WriteLine($"A raiz quadrada de {numero} é {Math.Round(raiz, 4)}");
        }
    }
}