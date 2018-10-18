using System;
using System.Collections.Generic;
using DataAccess.Crud;
using Entities;
using Exceptions;

namespace BankAccount
{
    public class AccountManagement
    {
        private readonly AccountCrudFactory crudAccount;

        public AccountManagement()
        {
            crudAccount = new AccountCrudFactory();
        }

        public void Create(Account account)
        {
            try
            {
                var c = crudAccount.Retrieve<Account>(account);
                if (c != null) throw new BusinessException(3);

                crudAccount.Create(account);
            }
            catch (Exception ex)
            {
                ExceptionManager.GetInstance().Process(ex);
            }
        }

        public List<Account> RetrieveAll()
        {
            return crudAccount.RetrieveAll<Account>();
        }

        public Account RetrieveById(Account account)
        {
            return crudAccount.Retrieve<Account>(account);
        }

        public void Update(Account account)
        {
            crudAccount.Update(account);
        }

        public void Delete(Account account)
        {
            crudAccount.Delete(account);
        }
    }
}