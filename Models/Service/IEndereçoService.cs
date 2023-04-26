namespace Register_with_address.Models.Service
{
    public interface IEndereçoService 
    {
        public Task<Endereço> GetEndereço(string cep);

    }
}
