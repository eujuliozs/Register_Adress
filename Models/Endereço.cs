
using Microsoft.Build.Framework;
using System.Text.Json.Serialization;

namespace Register_with_address.Models
{
    public class Endereço
    {
        public int Id { get; private set; }
        public string Cep { get; set; }

        [Required]
        public string Logradouro { get; set; }

        [Required]
        public string Complemento { get; set; }

        [Required]
        public string Bairro { get; set; }

        [Required]
        public string Localidade { get; set; }

        [Required]
        public string Uf { get; set; }

        [Required]
        public string Ibge { get; set; }

        [Required]
        public string Gia { get; set; }

        [Required]
        public string ddd { get; set; }

        [Required]
        public string Siafi { get; set; }

        [JsonIgnore(Condition= JsonIgnoreCondition.Always)]
        [Required]
        public string Numero { get; set; }
    }
}
