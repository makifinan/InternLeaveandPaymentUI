using InternLeaveandPaymentUI.Core.ReturnType;
using InternLeaveandPaymentUI.Domain.DTOs.Intern;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace InternLeaveandPaymentUI.Core.APIService
{
    public class InternAPIService
    {
        private readonly HttpClient _httpClient;

        public InternAPIService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<GeneralReturnType<InternDTO>> InternLogin(InternLoginDTO internLoginDTO)
        {
            var content = new StringContent(JsonConvert.SerializeObject(internLoginDTO));
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var result = await _httpClient.PostAsync("GetByEmailPassword",content);
            if (result.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<GeneralReturnType<InternDTO>>(await result.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<GeneralReturnType<List<InternListDTO>>> GetAllIntern()
        {
            var result = await _httpClient.GetAsync("GetAllIntern");
            if (result.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<GeneralReturnType<List<InternListDTO>>>(await result.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<GeneralReturnType<InternAddDTO>> AddIntern(InternAddDTO internAddDTO)
        {
            var content = new StringContent(JsonConvert.SerializeObject(internAddDTO));
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var result = await _httpClient.PostAsync("AddIntern",content);
            if (result.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<GeneralReturnType<InternAddDTO>>(await result.Content.ReadAsStringAsync());
            }
            return null;
        }
    }
}
