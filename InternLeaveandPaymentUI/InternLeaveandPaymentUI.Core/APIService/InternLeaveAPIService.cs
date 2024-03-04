using InternLeaveandPaymentUI.Core.ReturnType;
using InternLeaveandPaymentUI.Domain.DTOs.InternLeave;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace InternLeaveandPaymentUI.Core.APIService
{
    public class InternLeaveAPIService
    {
        private readonly HttpClient _httpClient;

        public InternLeaveAPIService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<GeneralReturnType<InternLeaveAddDTO>> AddInternLeave(InternLeaveAddDTO internLeaveAddDTO)
        {
            var content = new StringContent(JsonConvert.SerializeObject(internLeaveAddDTO));
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var result = await _httpClient.PostAsync("AddInternLeave",content);

            if (result.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<GeneralReturnType<InternLeaveAddDTO>>(await result.Content.ReadAsStringAsync());
            }
            return null;
        }
    }
}
