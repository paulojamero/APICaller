using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace APICaller
{
    public class GetCatBreed
    {
        private readonly HttpClient _httpClient;

        public GetCatBreed()
        {
             _httpClient = new HttpClient();
        }

        public async Task BreedCaller(int numLimit)
        {
            string apiUrl = $"https://catfact.ninja/breeds?limit={numLimit}";

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                Console.Write(responseBody);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An Error occured {ex.Message}.");
            }
            finally
            {
                _httpClient.Dispose();
            }
        }

    }
}
