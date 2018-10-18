using System;
using System.Collections.Generic;
using DataAccess.Crud;
using Entities;
using Exceptions;

namespace CoreAPI
{
    public class AccountManager : BaseManager
    {
        private readonly AccountCrudFactory crudAccount;

        public AccountManager()
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
            Account c = null;
            try
            {
                c = crudAccount.Retrieve<Account>(account);
                if (c == null) throw new BusinessException(4);
            }
            catch (Exception ex)
            {
                ExceptionManager.GetInstance().Process(ex);
            }

            return c;
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