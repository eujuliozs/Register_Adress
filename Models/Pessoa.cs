using System.ComponentModel.DataAnnotations;

namespace Register_with_address.Models
{
    public class Pessoa
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
