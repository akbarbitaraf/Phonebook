using Entities.DB;
using Entities.DTO.Record;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IContact
    {

        public Task<ContactRes> CreateContact(ContactReq contactReq); 
        public Task<ContactRes> UpdateContact(ContactReq contactReq);
        public Task<ContactRes> DeleteContact(int contactId);
        public Task<ContactRes> GetContact(int contactId);
        public Task<ContactRes> GetContacts();
        


    }
}
