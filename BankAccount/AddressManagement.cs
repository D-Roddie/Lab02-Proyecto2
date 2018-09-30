﻿using System.Collections.Generic;
using DataAccess.Crud;
using Entities;

namespace BankAccount
{
    public class AddressManagement
    {
        private readonly AddressCrudFactory crudAddress;

        public AddressManagement()
        {
            crudAddress = new AddressCrudFactory();
        }

        public void Create(Address address)
        {
            crudAddress.Create(address);
        }

        public List<Address> RetrieveAll()
        {
            return crudAddress.RetrieveAll<Address>();
        }

        public Address RetrieveById(Address address)
        {
            return crudAddress.Retrieve<Address>(address);
        }

        internal void Update(Address address)
        {
            crudAddress.Update(address);
        }

        internal void Delete(Address address)
        {
            crudAddress.Delete(address);
        }

    }
}