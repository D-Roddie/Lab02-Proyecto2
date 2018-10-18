using System;
using System.Collections.Generic;
using DataAccess.Crud;
using Entities;
using Exceptions;

namespace CoreAPI
{
    public class AddressManager : BaseManager
    {
        private readonly AddressCrudFactory crudAddress;

        public AddressManager()
        {
            crudAddress = new AddressCrudFactory();
        }

        public void Create(Address address)
        {
            try
            {
                var c = crudAddress.Retrieve<Address>(address);
                if (c != null) throw new BusinessException(3);

                crudAddress.Create(address);
            }
            catch (Exception ex)
            {
                ExceptionManager.GetInstance().Process(ex);
            }
        }

        public List<Address> RetrieveAll()
        {
            return crudAddress.RetrieveAll<Address>();
        }

        public Address RetrieveById(Address address)
        {
            Address c = null;
            try
            {
                c = crudAddress.Retrieve<Address>(address);
                if (c == null) throw new BusinessException(4);
            }
            catch (Exception ex)
            {
                ExceptionManager.GetInstance().Process(ex);
            }

            return c;
        }

        public void Update(Address address)
        {
            crudAddress.Update(address);
        }

        public void Delete(Address address)
        {
            crudAddress.Delete(address);
        }
    }
}