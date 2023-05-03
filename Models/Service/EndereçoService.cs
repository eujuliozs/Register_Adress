using Microsoft.EntityFrameworkCore;
using Register_with_address.Data;
using Register_with_address.Models.Service.Exceptions;

namespace Register_with_address.Models.Service
{
    public class EndereçoService
    {
        private readonly register_and_addressContext _context;
        public EndereçoService(register_and_addressContext context)
        {
            _context = context;
        }
        public void Insert(Endereço endereço)
        {
            if(endereço is null)
            {
                throw new ServiceException("Object is null");
            }

            _context.Add(endereço);
            _context.SaveChanges();
            
        }
        public List<Endereço> FindAll()
        {
            return _context.Endereço.ToList();
        }
        public void DeleteById(int id)
        {
            var query = _context.Endereço.Where(end => end.Id == id).SingleOrDefault();
            _context.Remove(query);
            _context.SaveChanges();
        }
        public void Update(Endereço endereço)
        {
            _context.Endereço.Update(endereço);
            _context.SaveChanges();
        }
        public Endereço? FindById(int id)
        {
            return _context.Endereço.Where(end => end.Id == id).SingleOrDefault();
        }
    }
}
