using AutoMapper;
using Entities.DB;
using Entities.DTO.Record;
using Services.Interfaces;

namespace Services.Services
{
    public class ContactServices 
    {
        private readonly ICreatorContact _creatorContact ;
        private readonly IMapper _mapper;
        public ContactServices(ICreatorContact creatorContact , IMapper mapper)
        {
            _creatorContact = creatorContact;
            _mapper = mapper;
        }

        public async Task<ContactRes> CreateContact(ContactReq contactReq)
        {
            IContact contact = _creatorContact.CreatorConstructor(contactReq.ContactType);
            return await contact.CreateContact(_mapper.Map<Contacts>(contactReq));
        }

        public async Task<ContactRes> DeleteContact(int contactId)
        {
            IContact contact = _creatorContact.CreatorConstructor(3);
            return await contact.DeleteContact(contactId);

        }

        public async Task<ContactRes> GetContact(int contactId)
        {
            IContact contact = _creatorContact.CreatorConstructor(3);
            return await contact.GetContact(contactId);
        }

        public async Task<ContactRes> GetContacts()
        {
            IContact contact = _creatorContact.CreatorConstructor(3);
            return await contact.GetContacts();
        }

        public async Task<ContactRes> UpdateContact(Contacts contactReq)
        {
            IContact contact = _creatorContact.CreatorConstructor(contactReq.ContactType_ID);
            return await contact.UpdateContact(contactReq);
        }

    }
}