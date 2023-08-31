﻿using Entities.DB;
using Entities.DTO.Record;
using Services.Interfaces;

namespace Services.Services
{
    public class ContactServices 
    {
        private readonly ICreatorContact _creatorContact ;
        public ContactServices(ICreatorContact creatorContact)
        {
            _creatorContact = creatorContact;
        }

        public async Task<ContactRes> CreateContact(ContactReq contactReq)
        {
            IContact contact = _creatorContact.CreatorConstructor(contactReq.ContactType); 
            return await contact.CreateContact(contactReq);
        }

        public async Task<ContactRes> DeleteContact(int contactId)
        {
            IContact contact = _creatorContact.CreatorConstructor("ETC");
            return await contact.DeleteContact(contactId);

        }

        public async Task<ContactRes> GetContact(int contactId)
        {
            IContact contact = _creatorContact.CreatorConstructor("ETC");
            return await contact.GetContact(contactId);
        }

        public async Task<ContactRes> GetContacts()
        {
            IContact contact = _creatorContact.CreatorConstructor("ETC");
            return await contact.GetContacts();
        }

        public async Task<ContactRes> UpdateContact(ContactReq contactReq)
        {
            IContact contact = _creatorContact.CreatorConstructor(contactReq.ContactType);
            return await contact.UpdateContact(contactReq);
        }

    }
}