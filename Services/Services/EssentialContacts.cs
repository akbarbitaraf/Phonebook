using Entities.DB;
using Entities.DTO.Record;
using Repositories;
using Services.Interfaces;

namespace Services.Services
{
    public class EssentialContacts : IContact
    {
        private readonly PhoneBookContext _phoneBookContext; 
        public EssentialContacts(PhoneBookContext phoneBookContext)
        {
            _phoneBookContext = phoneBookContext;

        }
        public async Task<ContactRes> CreateContact(Contacts contactReq)
        {
            throw new NotImplementedException();


            //await _phoneBookContext.Contacts.AddAsync(contactReq);
            //await _phoneBookContext.SaveChangesAsync();


            //return new ContactRes();


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