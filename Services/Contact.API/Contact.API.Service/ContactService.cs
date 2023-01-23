using Contact.API.Infrastructure;
using System;

namespace Contact.API.Service
{
    public class ContactService : IContactService
    {
        public Models.ContactModels.Contact GetContact()
        {
            return new Models.ContactModels.Contact()
            {
                Id = Guid.NewGuid(),
                FirstName = "Okan",
                LastName = "Yilmaz"
            };
        }

        public Models.ContactModels.Contact GetContactById(Guid Id)
        {
            return new Models.ContactModels.Contact()
            {
                Id = Id,
                FirstName = "Okan",
                LastName = "Yilmaz"
            };
        }
    }
}
