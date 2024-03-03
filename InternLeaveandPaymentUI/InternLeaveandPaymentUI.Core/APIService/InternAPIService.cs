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
    }
}
