﻿using Entities.DB;
using Entities.DTO.Record;
using Services.Interfaces;

namespace Services.Services
{
    public class NormalContacts : IContact
    {

        public async Task<ContactRes> CreateContact(Contacts contactReq)
        {
            throw new NotImplementedException();
        }

        public Task<ContactRes> DeleteContact(int contactId)
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