﻿namespace Register_with_address.Models
{
    public class Endereço
    {
        public int Id { get; private set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }
        public string Ibge { get; set; }
        public string Gia { get; set; }
        public string ddd { get; set; }
        public string Siafi { get; set; }
    }
}
