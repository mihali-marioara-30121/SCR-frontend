using SCD_Frontend.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SCD_Frontend
{
    internal class LoginService
    {
        public string SendAuthenticatedRequest(string username, string password)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {     
                    string jsonData = new LoginRequest(username, password).ToString();
                    HttpContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = client.PostAsync("http://localhost:8080/api/v1/users/login", content).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        string json = response.Content.ReadAsStringAsync().Result;
                        LoginResponse tokenResponse = JsonSerializer.Deserialize<LoginResponse>(json);

                        return tokenResponse.token;
                    }
                    else
                    {
                        return "Authentication failed";
                    }
                }
                catch (Exception ex)
                {
                    return "Authentication failed";
                }
            }
        }


}
}
