using Register_with_address.Models.Service.Exceptions;
using Register_with_address.Data;

namespace Register_with_address.Models.Service
{
    public class PessoaSerivce
    {
        private readonly register_and_addressContext _context;
        public PessoaSerivce(register_and_addressContext cotext) 
        { 
            _context = cotext;
        }
        public void Insert(Pessoa pessoa)
        {
            try
            {
                _context.Add(pessoa);
            }
            catch
            {
                throw new ServiceException("Não foi possivel inserir pessoas no banco de dados"); 
            }
        }
    }
}
