using Entities.DB;
using Entities.DTO.Record;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ReliefContacts : IContact
    {
        public async Task<ContactRes> CreateContact(Contacts contactReq)
        {
            throw new NotImplementedException();
        }

        public async Task<ContactRes> DeleteContact(int contactId)
        {
            throw new NotImplementedException();
        }

        public async Task<ContactRes> GetContact(int contactId)
        {
            throw new NotImplementedException();
        }

        public async Task<ContactRes> GetContacts()
        {
            throw new NotImplementedException();
        }

        public async Task<ContactRes> UpdateContact(Contacts contactReq)
        {
            throw new NotImplementedException();
        }
    }
}
