using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using CepApi.Models;
using System.Net.Http.Json;


namespace CepApi.Services
{
    internal class CepService
    {
        private static readonly HttpClient _client = new HttpClient();


        public async Task<CepModel> GetCep(string url)
        {
            CepModel cep = new CepModel();
            HttpResponseMessage response = await _client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
               return await response.Content.ReadFromJsonAsync<CepModel>();
            }
            else
            {
                throw new Exception($"Erro : {response.StatusCode}");
            }
   
        }


        public async Task TaskAsync(string cep)
        {
            _client.BaseAddress = new Uri("https://viacep.com.br/ws/");
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
         
                //return data from api
                var url = await GetCep(cep);
                Console.WriteLine(url);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

    }
}
