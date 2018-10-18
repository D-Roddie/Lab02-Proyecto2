using System;
using System.Collections.Generic;
using DataAccess.Crud;
using Entities;
using Exceptions;

namespace CoreAPI
{
    public class ContactManager : BaseManager
    {
        private readonly ContactCrudFactory crudContact;

        public ContactManager()
        {
            crudContact = new ContactCrudFactory();
        }

        public void Create(Contact contact)
        {
            try
            {
                var c = crudContact.Retrieve<Contact>(contact);
                if (c != null) throw new BusinessException(3);
                crudContact.Create(contact);
            }
            catch (Exception ex)
            {
                ExceptionManager.GetInstance().Process(ex);
            }
        }

        public List<Contact> RetrieveAll()
        {
            return crudContact.RetrieveAll<Contact>();
        }

        public Contact RetrieveById(Contact contact)
        {
            Contact c = null;
            try
            {
                c = crudContact.Retrieve<Contact>(contact);
                if (c == null) throw new BusinessException(4);
            }
            catch (Exception ex)
            {
                ExceptionManager.GetInstance().Process(ex);
            }

            return c;
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