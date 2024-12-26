namespace ConversorDeMoedas.Models
{
    public class ConversorMoeda
    {
        public double Valor { get; set; }
        public string MoedaOrigem { get; set; }
        public string MoedaDestino { get; set; }
        public double ValorConvertido { get; set; }

        // Taxas de conversão fixas
        private static readonly Dictionary<string, double> taxasDeConversao = new Dictionary<string, double>
        {
            { "USD", 1.0 }, // USD é a moeda base
            { "BRL", 5.24 }, // Taxa fictícia de conversão do USD para BRL
            { "EUR", 0.92 }, // Taxa fictícia de conversão do USD para EUR
            { "GBP", 0.80 }  // Taxa fictícia de conversão do USD para GBP
        };

        public void Converter()
        {
            if (taxasDeConversao.ContainsKey(MoedaOrigem) && taxasDeConversao.ContainsKey(MoedaDestino))
            {
                double taxaOrigem = taxasDeConversao[MoedaOrigem];
                double taxaDestino = taxasDeConversao[MoedaDestino];
                ValorConvertido = Valor * (taxaDestino / taxaOrigem);
            }
            else
            {
                ValorConvertido = 0;
            }
        }
    }
}
