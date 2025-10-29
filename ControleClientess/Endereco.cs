using System.Text.Json.Serialization;

namespace ControleClientess
{
    class Endereco
    {
        [JsonPropertyName("cep")]
        public string CEP { get; set; }

        [JsonPropertyName("logradouro")]
        public string Logradouro { get; set; }

        [JsonPropertyName("numero")]
        public string Numero { get; set; }

        [JsonPropertyName("complemento")]
        public string Complemento { get; set; }

        [JsonPropertyName("bairro")]
        public string Bairro { get; set; }

        [JsonPropertyName("localidade")]
        public string Localidade { get; set; }

        [JsonPropertyName("UF")]
        public string UF { get; set; }
    }
}
