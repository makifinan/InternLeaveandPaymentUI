using InternLeaveandPaymentUI.Core.ReturnType;
using InternLeaveandPaymentUI.Domain.DTOs.Employee;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace InternLeaveandPaymentUI.Core.APIService
{
    public class EmployeeAPIService
    {
        private readonly HttpClient _httpClient;

        public EmployeeAPIService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<GeneralReturnType<EmployeeDetailDTO>> EmployeeLogin(EmployeeLoginDTO employeeLoginDTO)
        {
            var content = new StringContent(JsonConvert.SerializeObject(employeeLoginDTO));
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var result = await _httpClient.PostAsync("GetByEmailPasswordEmployee",content);
            if (result.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<GeneralReturnType<EmployeeDetailDTO>>(await result.Content.ReadAsStringAsync());
            }
            return null;
        }
    }
}
