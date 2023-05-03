
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Register_with_address.Models
{
    public class Endereço
    {
        public int Id { get; set; }

        [Required]
        [JsonIgnore(Condition =JsonIgnoreCondition.Always)]
        [StringLength(100, MinimumLength =3, ErrorMessage ="Nome deve ser entre 3 e 100 caracteres")]
        [Display(Name ="Nome")]
        public string Morador  { get; set; }
        public string Cep { get; set; }

        [Required]
        public string Logradouro { get; set; }

        public string Complemento { get; set; }

        [Required]
        public string Bairro { get; set; }

        [Required]
        public string Localidade { get; set; }

        [Required]
        public string Uf { get; set; }

        public string Numero { get; set; }
    }
}
