using System;
using System.Text.RegularExpressions;

namespace ChequePorExtenso.ConsoleApp
{
    public class Humanizador
    {
        public static string EscreverPorExtenso(Decimal numero)
        {
            string strComE = " e ";

            string realOuReais = (numero == 1) ? "real" : "reais";

            if (numero == 1000000 || numero == 1000000000)
                realOuReais = "de reais";

            long antesDoPontoDecimal = (long)Math.Floor(numero);

            string strAntesPontoDecimal = $"{NumeroPorExtenso(antesDoPontoDecimal)} {realOuReais}";

            if (antesDoPontoDecimal == 0)
            {
                strAntesPontoDecimal = "";
                strComE = "";
            }

            string strDepoisPontoDecimal =
                $"{strComE}{DecimalPorExtenso((int)((numero - antesDoPontoDecimal) * 100), "")} centavos";

            if (EhApenasCentavos(strAntesPontoDecimal))
                strDepoisPontoDecimal += " de real";

            if (EhNumeroInteiro(numero))
                strDepoisPontoDecimal = "";

            string resultado = $"{strAntesPontoDecimal}{strDepoisPontoDecimal}";

            string resultadoFormatado = (resultado.Contains("mil ")) ? Formatar(resultado) : resultado;

            return EscreverPrimeiraLetraMaiuscula(resultadoFormatado);
        }

        private static string NumeroPorExtenso(long numero)
        {
            if (numero == 0)
                return "zero";

            if (numero < 0)
                return "menos " + NumeroPorExtenso(Math.Abs(numero));

            string palavras = "";

            if (numero / 1000000000 > 0)
            {
                string sufixo = (NumeroPorExtenso(numero / 1000000000) == "um") ? "bilhão " : "bilhões ";
                palavras += NumeroPorExtenso(numero / 1000000000) + $" {sufixo}";
                numero %= 1000000000;
            }

            if (numero / 1000000 > 0)
            {
                string sufixo = (NumeroPorExtenso(numero / 1000000) == "um") ? "milhão " : "milhões ";
                palavras += NumeroPorExtenso(numero / 1000000) + $" {sufixo}";
                numero %= 1000000;
            }

            if ((numero / 1000) > 0)
            {
                palavras += $"{NumeroPorExtenso(numero / 1000)} mil ";
                numero %= 1000;
            }

            if (numero / 100 > 0)
            {
                palavras += CentenaPorExtenso(numero, palavras);
                numero %= 100;
            }

            palavras = DecimalPorExtenso(numero, palavras);

            return palavras;
        }

        private static string CentenaPorExtenso(long numero, string palavras)
        {
            if (numero <= 0) return palavras;
            if (palavras != "")
                palavras += " ";

            string[] centenas = new[] { "zero", "cem", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos" };

            palavras += (centenas[numero / 100] == "cem" && (numero % 100) > 0) ? "cento" : centenas[numero / 100];
            if ((numero % 100) > 0)
                palavras += " e";

            return palavras;
        }

        private static string DecimalPorExtenso(long numero, string palavras)
        {
            if (numero <= 0) return palavras;
            if (palavras != "")
                palavras += " ";

            string[] unidades = new[] { "zero", "um", "dois", "tres", "quatro", "cinco", "seis", "sete", "oito", "nove", "dez", "onze", "doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };
            string[] dezenas = new[] { "zero", "dez", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };

            if (numero < 20)
                palavras += unidades[numero];
            else
            {
                palavras += dezenas[numero / 10];
                if ((numero % 10) > 0)
                    palavras += " e " + unidades[numero % 10];
            }

            return palavras;
        }

        private static bool EhApenasCentavos(string strAntesPontoDecimal)
        {
            return string.IsNullOrEmpty(strAntesPontoDecimal);
        }

        private static bool EhNumeroInteiro(decimal numero)
        {
            return numero % 1 == 0;
        }

        private static string EscreverPrimeiraLetraMaiuscula(string resultado)
        {
            if (string.IsNullOrEmpty(resultado))
            {
                return string.Empty;
            }
            return char.ToUpper(resultado[0]) + resultado.Substring(1);
        }

        private static string Formatar(string resultado)
        {
            string[] sort = resultado.Split(new String[] { "mil " }, 2, StringSplitOptions.None);

            string resultadoFormatado = sort[1];

            resultadoFormatado = Regex.Replace(resultadoFormatado, " {2,}", " ");

            return resultadoFormatado;
        }
    }
}
