using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SCD_Frontend.models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace SCD_Frontend.services
{
    internal class DepartmentService
    {
        public List<DepartmentVO> GetAllDepartments(string apiUrl, string jwtToken)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwtToken);

                    HttpResponseMessage response = client.GetAsync(apiUrl).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = response.Content.ReadAsStringAsync().Result;
                        List<DepartmentVO> departments = JsonConvert.DeserializeObject<List<DepartmentVO>>(responseBody);
                        return departments;
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

        public Department findByName(string apiUrl, string depName, string JWT)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", JWT);

                    HttpResponseMessage response = client.GetAsync(apiUrl + "/" + depName).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = response.Content.ReadAsStringAsync().Result;
                        Department department = JsonConvert.DeserializeObject<Department>(responseBody);
                        return department;
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

        public void createNewDepartment(string apiUrl, Department department, long parentId, string JWT)
        {
            using (HttpClient client = new HttpClient())
            {

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", JWT);
                string jsonData = department.ToString();
                HttpContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync(apiUrl + "/" + parentId, content).Result;

                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                }
            }
        }

        internal void deleteDepartment(string apiUrl, long departmentId, string JWT)
        {
            using (HttpClient client = new HttpClient())
            {

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", JWT);
                HttpResponseMessage response = client.DeleteAsync(apiUrl + "/" + departmentId).Result;

                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                }
            }
        }

        internal void editDepartment(string apiUrl, DepartmentDTO departmentDTO, long departmentId, string JWT)
        {
            using (HttpClient client = new HttpClient())
            {

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", JWT);
                string jsonData = departmentDTO.ToString();
                HttpContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PutAsync(apiUrl + "/" + departmentId, content).Result;

                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                }
            }
        }
    }
}
