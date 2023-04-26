using Register_with_address.Models.ViewModel;
using System.Text.Json;

namespace Register_with_address.Models.Service
{
    public class EndereçoService : IEndereçoService
    {
        private const string apiEndPoint = $"viacep.com.br/ws/";
        private readonly JsonSerializerOptions _Options;
        private readonly IHttpClientFactory _HttpClientFactory;

        private Endereço _Endereço;

        public EndereçoService(IHttpClientFactory clientFactory)
        {
            _HttpClientFactory = clientFactory;
            _Options = new JsonSerializerOptions { PropertyNameCaseInsensitive=true};
        }
        public async Task<Endereço> GetEndereço(string cep)
        {
            var client = _HttpClientFactory.CreateClient("ViaCepApi");
            using (var response = await client.GetAsync(apiEndPoint + cep))
            {
                if(response.IsSuccessStatusCode)
                {
                    var apiResponse = await response.Content.ReadAsStreamAsync();
                    _Endereço = await JsonSerializer.DeserializeAsync<Endereço>(apiResponse, _Options);
                }
                else
                {
                    return null;
                }
                return await Task.FromResult(_Endereço);
            };
        }


    }
}
