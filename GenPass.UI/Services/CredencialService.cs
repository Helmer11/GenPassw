using GenPass.UI.Models;
using GenPass.UI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GenPass.UI.Services
{
    public class CredencialService : ICredencialService
    {
        private readonly HttpClient _http;

        private const string BaseUrl = "https://oqrqibnlgghvnhfvwcwi.supabase.co/rest/v1/";
        private const string ApiKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6Im9xcnFpYm5sZ2dodm5oZnZ3Y3dpIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NjU4MDY0NjQsImV4cCI6MjA4MTM4MjQ2NH0.ucIgA8xYeA6WKYOY1vTj8YUYaDddbKdYv2k2q-EoDXg";

        public CredencialService(HttpClient httpclient)
        {
            _http = httpclient;
            _http.DefaultRequestHeaders.Add("ApiKey", ApiKey);
        }

        public Task<(bool isSuccess, string MessageError)> AddCredentialAsync(Credencial credential)
        {
            throw new NotImplementedException();
        }

        public Task<(bool isSucces, string MessageError)> DeleteCredentialAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<(List<Credencial>?, string MessageError)> GetListCredential(int userId)
        {
            try
            {
                var response = await _http.GetAsync($"{BaseUrl}Credenciales");

                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                var credentials = JsonSerializer.Deserialize<List<Credencial>>(json,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                return (credentials, string.Empty);
            }
            catch (Exception ex)
            {
                return (null, ex.Message);
            }
        }
    }

}
