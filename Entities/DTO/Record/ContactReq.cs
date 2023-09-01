using EmployeePanelServices.Entities.Enums;
using Entities.DB;
using Phonebook.Entities.DTO.Record;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO.Record
{
    public record ContactReq
    {
        public string Name { get; set; }   
        public string Family { get; set; }
        public string Email { get; set; }
        public List<PhoneDTO> PhoneNumber { get; set; }
        public string Address { get; set; }
        public int  ContactType { get; set; }

    }
}
