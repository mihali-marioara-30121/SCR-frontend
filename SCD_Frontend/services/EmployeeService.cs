using Newtonsoft.Json;
using SCD_Frontend.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace SCD_Frontend.services
{

internal class EmployeeService
    {
        public List<Employee> GetManagersByDepartment(string departmentName, string apiUrl, string jwtToken)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwtToken);

                    HttpResponseMessage response = client.GetAsync(apiUrl + "/" +departmentName).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = response.Content.ReadAsStringAsync().Result;
                        List<Employee> managers = JsonConvert.DeserializeObject<List<Employee>>(responseBody);
                        return managers;
                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                    return null;
                }
            }
        }

        internal void createEmployee(EmployeeRequest request, string apiUrl, string JWT)
        {

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", JWT);
                    string jsonData = request.ToString();
                    HttpContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = client.PostAsync(apiUrl, content).Result;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Creating employee failed!"); 
                }
            }
        }

        internal void deleteEmployee(string currentSelectedEmployeeId, string apiUrl, string JWT)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", JWT);               
                    HttpResponseMessage response = client.DeleteAsync(apiUrl + "/" + currentSelectedEmployeeId).Result;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Creating employee failed!");
                }
            }
        }

        internal void updateEmployee(EmployeeRequest request, string currentSelectedEmployeeId, string apiUrl, string JWT)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", JWT);
                    string jsonData = request.ToString();
                    HttpContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = client.PutAsync(apiUrl + "/" + currentSelectedEmployeeId, content).Result;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Updating employee failed!");
                }
            }
        }
    }
}
