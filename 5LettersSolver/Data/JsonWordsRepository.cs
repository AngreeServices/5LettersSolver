using System.Net.Http.Json;
using System.Text.Json;


namespace _5LettersSolver.Data
{
    public class JsonWordsRepository : IWordsRepository
    {
        private readonly HttpClient _httpClient;
        public JsonWordsRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<WordDB>> GetAll()
        {
            var response =  await _httpClient.GetAsync("data/words.json");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<List<WordDB>>(content, options);
        }
    }
}
