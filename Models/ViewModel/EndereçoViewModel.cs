namespace Register_with_address.Models.ViewModel
{
    public class EndereçoViewModel
    {
        public int Id { get; private set; }
        public string Morador { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }
    }
}
