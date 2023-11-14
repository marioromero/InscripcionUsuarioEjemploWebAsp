using InscripcionUsuarioEjemploWebAsp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using static System.Net.WebRequestMethods;

namespace InscripcionUsuarioEjemploWebAsp.Metodos
{
    public class Api
    {
        private readonly HttpClient _httpClient;

        public Api()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:7029/");
        }

        public dynamic Get(string endpoint)
        {

            var url = "https://localhost:7029/api/v1/usuarios-controller/lista-usuario";
            using (HttpClient httpClient = new HttpClient())
            {
                var rute = url;

                var Apiresponse =  httpClient.GetAsync(rute).Result;
                if (Apiresponse.IsSuccessStatusCode)
                {
                    var content =  Apiresponse.Content.ReadAsStringAsync().Result;
                    var response = JsonConvert.DeserializeObject<ListaUsuarios>(content);

                    return response.Data;
                }
                else
                {
                    return false;
                }
            }
        }

        public string Post(string endpoint, HttpContent content)
        {
            var response = _httpClient.PostAsync(endpoint, content).Result;
            return response.Content.ReadAsStringAsync().Result;
        }

        public string Put(string endpoint, HttpContent content)
        {
            var response = _httpClient.PutAsync(endpoint, content).Result;
            return response.Content.ReadAsStringAsync().Result;
        }

        public string Delete(string endpoint)
        {
            var response = _httpClient.DeleteAsync(endpoint).Result;
            return response.Content.ReadAsStringAsync().Result;
        }
    }
}