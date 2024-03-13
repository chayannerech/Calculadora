using System.Diagnostics;

namespace Calculadora.ConsoleApp
{

    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                decimal resultado = 0;
                Console.Clear();
                Console.WriteLine("Calculadora TopShow\n");
                Console.WriteLine("Digite: \n 1 - para somar \n 2 - para subtrair \n 3 - para multiplicar \n 4 - para dividir \n S - para sair");
                string operacao = Console.ReadLine();

                if (operacao == "S" || operacao == "s")break;
                if (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4") Console.WriteLine("\nOpção inválida. Por favor, tente novamente");
                else
                {
                    Console.WriteLine("Digite o primeiro número");
                    string primeiroNumeroString = Console.ReadLine();
                    decimal primeiroNumero = Convert.ToDecimal(primeiroNumeroString);

                    Console.WriteLine("Agora, o segundo número");
                    string segundoNumeroString = Console.ReadLine();
                    decimal segundoNumero = Convert.ToDecimal(segundoNumeroString);

                    if (operacao == "4" && segundoNumero == 0) Console.WriteLine("\nNão é possível dividir um número por zero. Por favor, tente novamente");
                    else
                    {
                        if (operacao == "1") resultado = primeiroNumero + segundoNumero;
                        else if (operacao == "2") resultado = primeiroNumero - segundoNumero;
                        else if (operacao == "3") resultado = primeiroNumero * segundoNumero;
                        else if (operacao == "4") resultado = primeiroNumero / segundoNumero;
                        Console.WriteLine("\nShow! Seu resultado é: " + resultado);
                    }
                }
                Console.WriteLine("Deseja continuar? [S/N]");
                string continuar = Console.ReadLine();

                if (continuar == "N" || continuar == "n") break;
            }    
        }
    }
}
