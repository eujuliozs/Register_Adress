namespace Register_with_address.Models.Service.Exceptions
{
    public class ServiceException : ApplicationException
    {
        public ServiceException(string message): base(message) { }
    }
}
