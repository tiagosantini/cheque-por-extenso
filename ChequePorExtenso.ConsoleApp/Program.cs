using System;
using System.IO;
using System.Text;

namespace ChequePorExtenso.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string strInput, resultado;

            do
            {
                Console.Write("Digite o valor que deseja escrever por extenso: R$ ");

                strInput = Console.ReadLine();

                if (string.IsNullOrEmpty(strInput))
                {
                    Console.Write("Digite algum valor! Pressione alguma tecla para tentar novamente... ");
                    Console.ReadLine();
                    Console.Clear();
                }

            } while (string.IsNullOrEmpty(strInput));

            try
            {
                EscreverPorExtenso(strInput, out resultado);

                ExibirResultado($"R$ {strInput} por extenso: {resultado}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }

        private static void ExibirResultado(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(mensagem);

            Console.ResetColor();
        }

        private static string EscreverPorExtenso(string strInput, out string resultado)
        {
            Decimal conversaoDecimal = Decimal.Parse(strInput);

            resultado = Humanizador.EscreverPorExtenso(conversaoDecimal);

            return resultado;
        }
    }
}
