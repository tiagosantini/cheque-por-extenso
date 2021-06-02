using System;
using System.Text.RegularExpressions;

namespace ChequePorExtenso.ConsoleApp.Extensoes
{
    public static class StringExtension
    {
        public static string EscreverPrimeiraLetraMaiuscula(this string resultado)
        {
            if (string.IsNullOrEmpty(resultado))
                return string.Empty;

            resultado = Regex.Replace(resultado, " {2,}", " ");

            return char.ToUpper(resultado[0]) + resultado.Substring(1);
        }

        public static string Formatar(this string resultado)
        {
            string[] sort = resultado.Split(new String[] { "mil " }, 2, StringSplitOptions.None);

            string resultadoFormatado = sort[1];

            return resultadoFormatado;
        }
    }
}
