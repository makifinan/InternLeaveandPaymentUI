using InternLeaveandPaymentUI.Core.ReturnType;
using InternLeaveandPaymentUI.Domain.DTOs.Department;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace InternLeaveandPaymentUI.Core.APIService
{
    public class DepartmentAPIService
    {
        private readonly HttpClient _httpClient;

        public DepartmentAPIService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<GeneralReturnType<DepartmentListDTO>> GetByIDDepartment(int id)
        {
            var requestData = new { id = id };

            var content = new StringContent(JsonConvert.SerializeObject(requestData));
            var result = await _httpClient.PostAsync($"GetAllDepartment/{id}", content);
            GeneralReturnType<DepartmentListDTO> data;
            if (result.IsSuccessStatusCode)
            {
                data= JsonConvert.DeserializeObject<GeneralReturnType<DepartmentListDTO>>(await result.Content.ReadAsStringAsync());
                return data;
            }
            return null;
        }
    }
}
