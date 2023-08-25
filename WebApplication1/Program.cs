using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("qual operacao deseja fazer?");
            Console.WriteLine("1 - adição");
            Console.WriteLine("2 - subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão\n");

            int operacao = int.Parse(Console.ReadLine()); // nessa variavel que ele vai guardar 


            Console.WriteLine("digite o primeiro numero");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o segundoo numero numero");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = 0;

            switch (operacao)// o switch significa caso, par comparacoes.
            {
                case 1:
                    resultado = Adicao(num1, num2);
                    break;
                case 2:
                    resultado = Subtracao(num1, num2);
                    break;
                case 3:
                    resultado = Multiplicacao(num1, num2);
                    break;
                case 4:
                    resultado = Divisao(num1, num2);
                    break;
                default:
                    Console.WriteLine("numero invalido");
                    break;
            }
            Console.WriteLine("O resultado da operacao é: " + resultado);
            Console.ReadLine();
        }







        // metodos auxiliares par realizar o calculo e voltar o valor
        public static int Adicao(int numero1, int numero2)
        {

            int result = numero1 + numero2;
            return result;



        }

        public static int Subtracao(int numero1, int numero2)
        {
            int result = numero1 - numero2;
            return result;

        }

        public static int Multiplicacao(int numero1, int numero2)
        {
            int result = numero1 * numero2;
            return result;

        }

        public static int Divisao(int numero1, int numero2)
        {
            int result = numero1 / numero2;
            return result;

        }

    }


}
