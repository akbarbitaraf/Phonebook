using Entities.DTO.Record;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Interfaces;
using Services.Services;
using System.Data;

namespace Phonebook.Controllers
{
    public class ContactController : Controller
    {
        private readonly ContactServices _contactServices;
        public ContactController(ContactServices contactServices)
        {
            _contactServices = contactServices; 
        }
        [HttpPost]
        public async Task<ContactRes> Creatorcontact([FromForm] ContactReq contactReq)
        {
            return await _contactServices.CreateContact(contactReq);

        }
        [HttpGet("id")] 
        public async Task<ContactRes> GetContact(int id)
        {
            return await _contactServices.GetContact(id); 
        }
        [HttpGet]
        public async Task<ContactRes> GetContacts()
        {
            return await _contactServices.GetContacts();
        }
        [HttpDelete]
        public async Task<ContactRes> DeleteContact(int contactId)
        {
            throw new NotImplementedException();
        }
        [HttpPut]
        public async Task<ContactRes> UpdateContact(ContactReq contactReq)
        {
            throw new NotImplementedException();
        }

    }
}
