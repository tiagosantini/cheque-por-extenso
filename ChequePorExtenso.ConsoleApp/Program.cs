using System;
using System.IO;
using System.Text;

namespace ChequePorExtenso.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string strValorPorExtenso = Humanizador.EscreverPorExtenso(10.50m);

            Console.WriteLine(strValorPorExtenso);

            Console.ReadLine();
        }
    }
}
