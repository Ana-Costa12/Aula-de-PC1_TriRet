using System;

namespace Aula_de_PC1_TriRet
{
    class Program
    {
        static void Main(string[] args)
        {
            double Base;
            double Altura;
            double Area;

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Vamos calcular a área de um triângulo retângulo");
            Console.WriteLine("-----------------------------------------------\n");
            //Adição de valores para variáveis//
            Console.WriteLine("Digite o valor da base:");
            Console.ForegroundColor = ConsoleColor.Red;
            Base = double.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine("\nAgora digite o valor da altura:");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Altura = double.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine("Tecle enter para calcular a área de seu triângulo...");
            Console.ReadLine();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Sendo {Base} a base e {Altura} a altura, a área de seu triângulo é: {Area = Base * Altura / 2}");
            Console.ResetColor();
        }
    }
}
