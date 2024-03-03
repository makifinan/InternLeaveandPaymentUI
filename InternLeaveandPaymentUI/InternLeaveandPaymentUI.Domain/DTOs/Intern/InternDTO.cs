using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternLeaveandPaymentUI.Domain.DTOs.Intern
{
    public class InternDTO
    {
        public int InternId { get; set; }
        public string InternName { get; set; }
        public string InternSurname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public int? InternCompanyId { get; set; }
        public string InternSchool { get; set; }
        public string InternSchoolDepartment { get; set; }
        public int? InternManagerId { get; set; }
        public int? InternDepartmentId { get; set; }
        public int? InternDutyStationId { get; set; }
        public int? InternIntershipTypeId { get; set; }
        public string InternPhoneNumber { get; set; }
        public string InternResponsibleTeacher { get; set; }
        public string InternTeacherPhone { get; set; }
        public string InternContactPerson { get; set; }
        public string InternContactPersonPhone { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? IsActive { get; set; }
    }
}
