using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using Translater.Models;

namespace Translater.Sevices
{
    public class DataService
    {
        private static readonly DataService _dataService = new DataService();

        private readonly HttpClient _httpClient = new HttpClient
        {
            DefaultRequestHeaders = { IfModifiedSince = DateTimeOffset.Now }
        };

        private readonly string _baseUrl = "https://dictionary.yandex.net/api/v1/dicservice.json/";
        private readonly string _apiKey = "dict.1.1.20170616T135053Z.39838230c520d14a.5f03f9d45b88a01c120c7c944c38a98c8cf87681";

        protected DataService()
        {

        }

        public static DataService GetInstance()
        {
            return _dataService;
        }

        public async Task<ResponseModel> TranslateAsync(string lang, string word)
        {
            try
            {
                var uri = $"{_baseUrl}lookup?key={_apiKey}&lang={lang}&text={word}";
                var json = await _httpClient.GetStringAsync(new Uri($"{uri}"));
                Debug.WriteLine(json);
                var response = JsonConvert.DeserializeObject<ResponseModel>(json);
                return response;
            } catch (Exception e)
            {
                Debug.WriteLine("=================");
                Debug.WriteLine(e.Message);
                Debug.WriteLine("=================");
                return new ResponseModel();
            }
        }
}
}
