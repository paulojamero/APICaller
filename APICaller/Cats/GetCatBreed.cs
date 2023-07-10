using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace APICaller.Cats
{
    public class GetCatBreed
    {
        private readonly HttpClient _httpClient;


        public async Task BreedCaller(int numLimit)
        {
            string apiUrl = $"https://catfact.ninja/breeds?limit={numLimit}";

            try
            {
                using(HttpClient _httpClient = new HttpClient())
                {
                
                    HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
                    if(response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        //GetCatBreed getCatBreed = JsonConvert.DeserializeObject<GetCatBreed>(jsonResponse);

                        Console.WriteLine(jsonResponse);

                    }
                    

                }
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
