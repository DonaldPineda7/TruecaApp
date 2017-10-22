using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TruecaApp.Classes;

namespace TruecaApp.Services
{
    public class ApiService
    {
        public async Task<TokenResponse> LoginFacebook(string urlBase, string servicePrefix, string controller, FacebookResponse profile)
        {
            try
            {
                var request = JsonConvert.SerializeObject(profile);
                var content = new StringContent(request, Encoding.UTF8, "application/json");
                var client = new HttpClient();
                client.BaseAddress = new Uri(urlBase);
                var url = string.Format("{0}{1}", servicePrefix, controller);
                var response = await client.PostAsync(url, content);

                if(!response.IsSuccessStatusCode)
                {
                    return null;
                }

                var tokenResponse = await GetToken(urlBase, profile.Id, profile.Id);
                return tokenResponse;
            }
            catch
            {
                return null;
            }
        }

        public async Task<TokenResponse> GetToken(string urlBase, string userName, string password)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(urlBase);
                var response = await client.PostAsync("Token",
                  new StringContent(string.Format("grant_type = password&username={0}&password={1}",
                  userName, password),
                   Encoding.UTF8, "application/x-www-form-urlencoded"));

                var resultJson = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<TokenResponse>(resultJson);
                return result;

            }
            catch
            {
                return null;
            }
        }
    }
}
