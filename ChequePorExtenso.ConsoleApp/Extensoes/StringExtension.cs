
namespace ChequePorExtenso.ConsoleApp.Extensoes
{
    public static class StringExtension
    {
        public static string EscreverPrimeiraLetraMaiuscula(string resultado)
        {
            if (string.IsNullOrEmpty(resultado))
            {
                return string.Empty;
            }
            return char.ToUpper(resultado[0]) + resultado.Substring(1);
        }
    }
}
