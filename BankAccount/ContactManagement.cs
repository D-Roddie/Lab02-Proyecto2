using System.Collections.Generic;
using DataAccess.Crud;
using Entities;

namespace BankAccount
{
    public class ContactManagement
    {
        private readonly ContactCrudFactory crudContact;

        public ContactManagement()
        {
            crudContact = new ContactCrudFactory();
        }

        public void Create(Contact contact)
        {
            crudContact.Create(contact);
        }

        public List<Contact> RetrieveAll()
        {
            return crudContact.RetrieveAll<Contact>();
        }

        public Contact RetrieveById(Contact contact)
        {
            return crudContact.Retrieve<Contact>(contact);
        }

        public void Update(Contact contact)
        {
            crudContact.Update(contact);
        }

        public void Delete(Contact contact)
        {
            crudContact.Delete(contact);
        }
    }
}