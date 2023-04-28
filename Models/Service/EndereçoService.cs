using Register_with_address.Models.ViewModel;
using System.Drawing;
using System.Security.Cryptography.Xml;
using System.Text.Json;

namespace Register_with_address.Models.Service
{
    public class CepService
    {
        private readonly HttpClient _httpClient;

        public CepService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Endereço> GetCepInfo(string cep)
        {
            var response = await _httpClient.GetFromJsonAsync<Endereço>($"https://viacep.com.br/ws/{cep}/json/");

            return response;
        }
    }
}
