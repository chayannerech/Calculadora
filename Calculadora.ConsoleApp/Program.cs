using System.Diagnostics;
namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string operacao = MostrarMenu();

                #region Resto do código
                if (SaidaSelecionada(operacao)) break;
                if (OpcaoInvalida(operacao)) Console.WriteLine("\nOpção inválida. Por favor, tente novamente");
                else RealizarCalculo(operacao);

                Console.WriteLine("Deseja continuar? [S/N]");
                string continuar = Console.ReadLine();
                if (continuar == "N" || continuar == "n") break;
                #endregion
            }
        }
        static string MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("Calculadora TopShow\n");
            Console.WriteLine("Digite: \n 1 - para somar \n 2 - para subtrair \n 3 - para multiplicar \n 4 - para dividir \n S - para sair");
            string operacao = Console.ReadLine();

            return operacao;
        }
        static bool SaidaSelecionada(string opcao)
        {
            bool saidaSelecionada = opcao == "S" || opcao == "s";
            return saidaSelecionada;
        }
        static bool OpcaoInvalida(string opcao)
        {
            bool opcaoInvalida = opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4";
            return opcaoInvalida;
        }
        static void RealizarCalculo(string operacao)
        {
            decimal resultado = 0;

            Console.WriteLine("Digite o primeiro número");
            decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Agora, o segundo número");
            decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

            if (operacao == "4" && segundoNumero == 0) Console.WriteLine("\nNão é possível dividir um número por zero :( Por favor, tente novamente");
            else
            {
                switch (operacao)
                {
                    case "1":
                        resultado = primeiroNumero + segundoNumero;
                        break;
                    case "2":
                        resultado = primeiroNumero - segundoNumero;
                        break;
                    case "3":
                        resultado = primeiroNumero * segundoNumero;
                        break;
                    case "4":
                        resultado = primeiroNumero / segundoNumero;
                        break;
                }

                Console.WriteLine("\nShow! Seu resultado é: " + resultado);
            }
        }
    }
}
