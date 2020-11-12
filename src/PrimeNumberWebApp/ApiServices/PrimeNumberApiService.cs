using System;

using System.Collections.Generic;

using System.Linq;

using System.Net.Http;

using System.Text;

using System.Threading.Tasks;

using PrimeNumberWebApp.ApiInterfaces;

using PrimeNumberWebApp.Models;

using Microsoft.Extensions.Configuration;

using Newtonsoft.Json;



namespace PrimeNumberWebApp.ApiServices

{

    public class PrimeNumberApiService: IPrimeNumberApiService

    {

        private readonly IConfiguration _config;

        private readonly string _apiUrl = string.Empty;



        public PrimeNumberApiService(IConfiguration config)

        {

            _config = config;

            _apiUrl = _config.GetSection("ApiUrl").Value;

        }



        public async Task<List<PrimeNumber>> GetPrimeNumbers()

        {

            var httpClient = new HttpClient();

            var url = $"{_apiUrl}/api/PrimeNumbers";

            var list = new List<PrimeNumber>();

            try

            {

                var response = await httpClient.GetAsync(url);

                var json = await response.Content.ReadAsStringAsync();

                list = JsonConvert.DeserializeObject<List<PrimeNumber>>(json);

            }

            catch (Exception ex)

            {

                _ = ex.Message;

            }

            return list;

        }



        public async Task<PrimeNumber> GetPrimeNumber(long Id)

        {

            var httpClient = new HttpClient();

            var url = $"{_apiUrl}/api/PrimeNumbers/{Id}";

            var item = new PrimeNumber();

            try

            {

                var response = await httpClient.GetAsync(url);

                var json = await response.Content.ReadAsStringAsync();

                item = JsonConvert.DeserializeObject<PrimeNumber>(json);

            }

            catch (Exception ex)

            {

                _ = ex.Message;

            }

            return item;

        }



        public async Task<string> AddPrimeNumber(PrimeNumber PrimeNumber)

        {

            var httpClient = new HttpClient();

            var url = $"{_apiUrl}/api/PrimeNumbers/";

            var statusCode = string.Empty;

            try

            {

                var json = JsonConvert.SerializeObject(PrimeNumber);

                HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync(url, content);

                if (response.IsSuccessStatusCode)

                {

                    statusCode = response.StatusCode.ToString();

                }

            }

            catch (Exception ex)

            {

                _ = ex.Message;

            }

            return statusCode;

        }

    }

}

