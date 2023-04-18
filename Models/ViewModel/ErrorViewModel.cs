namespace Register_with_address.Models.ViewModel
{
    public class ErrorViewModel
    {
        public string Message { get; set; }
        public string? RequestId { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}