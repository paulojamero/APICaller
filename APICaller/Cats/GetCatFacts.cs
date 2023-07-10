using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.IO;
using System.Text.Json;

namespace APICaller.Cats
{
    public class GetCatFacts
    {
        private readonly HttpClient _httpClient;

        public string fact { get; set; }
        public int lenght { get; set; }

        public GetCatFacts()
        {
            _httpClient = new HttpClient();
        }

        public async Task FactsCaller(int factsLenght)
        {
            string apiUrl = $"https://catfact.ninja/fact?max_length={factsLenght}";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        GetCatFacts getCatFacts = Newtonsoft.Json.JsonConvert.DeserializeObject<GetCatFacts>(jsonResponse);
                        Console.WriteLine($"Number of lenght: {factsLenght}");
                        Console.WriteLine($"Fact is: {getCatFacts.fact}");

                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error message: {ex.Message}");
            }
            finally
            {
                _httpClient.Dispose();
            }
        }
    }
}
