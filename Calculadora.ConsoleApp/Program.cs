using System.Diagnostics;
namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static int operacoesRealizadas = 0;
        static void Main(string[] args)
        {
            string[] historico = new string[100];

            while (true)
            {
                string operacao = MostrarMenu();

                #region Resto do código
                if (SaidaSelecionada(operacao)) break;
                if (OpcaoInvalida(operacao)) Console.WriteLine("\nOpção inválida. Por favor, tente novamente");
                else RealizarCalculo(operacao, historico);
                if (DeveContinuar()) break;
                #endregion
            }
        }
        static string MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("Calculadora TopShow\n");
            Console.WriteLine("Digite: \n 1 - para somar \n 2 - para subtrair \n 3 - para multiplicar \n 4 - para dividir \n 5 - para mostrar a tabuada\n 6 - para visualizar o histórico de operações\n X - para sair\n");
            string operacao = Console.ReadLine();

            return operacao;
        }
        static bool SaidaSelecionada(string opcao)
        {
            bool saidaSelecionada = opcao == "X" || opcao == "x";
            return saidaSelecionada;
        }
        static bool OpcaoInvalida(string opcao)
        {
            bool opcaoInvalida = opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5" && opcao != "6";
            return opcaoInvalida;
        }
        static void RealizarCalculo(string operacao, string[] historico)
        {
            decimal resultado = 0, primeiroNumero = 1, segundoNumero = 1;
            string simbolo = "";

            if(operacao != "5" && operacao != "6")
            {
                primeiroNumero = PegarValor("\nDigite o primeiro número");
                segundoNumero = PegarValor("\nAgora, o segundo número");
            }

            if (operacao == "4" && segundoNumero == 0) Console.WriteLine("\nNão é possível dividir um número por zero :( Por favor, tente novamente");
            else
            {
                switch (operacao)
                {
                    case "1":
                        resultado = primeiroNumero + segundoNumero;
                        simbolo = "+";
                        break;
                    case "2":
                        resultado = primeiroNumero - segundoNumero;
                        simbolo = "-";
                        break;
                    case "3":
                        resultado = primeiroNumero * segundoNumero;
                        simbolo = "x";
                        break;
                    case "4":
                        resultado = primeiroNumero / segundoNumero;
                        simbolo = "/";
                        break;
                    case "5":
                        primeiroNumero = PegarValor("\nInforme o número:");
                        historico[operacoesRealizadas] = $"Tabuada de {primeiroNumero}";
                        Console.WriteLine();

                        for (int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine(i + " x " + primeiroNumero + " = " + (primeiroNumero * i));
                        }
                        break;
                    case "6":
                        Console.WriteLine("\nHistórico de operações:\n");

                        for (int i = 0; i < 100; i++)
                        {
                            if (historico[i] != null) Console.WriteLine(historico[i]);
                        }
                        break;
                }

                if (operacao != "5" && operacao != "6")
                {
                    Console.WriteLine("\nShow! Seu resultado é: " + resultado);
                    historico[operacoesRealizadas] = $"{primeiroNumero}{simbolo}{segundoNumero} = {resultado}";
                }
                operacoesRealizadas++;
            }
        }
        static decimal PegarValor(string texto)
        {
            Console.WriteLine(texto);
            return Convert.ToDecimal(Console.ReadLine());
        }
        static bool DeveContinuar()
        {
            Console.WriteLine("\nDeseja continuar? [S/N]");
            string continuar = Console.ReadLine();
            return continuar == "N" || continuar == "n";
        }
    }
}
