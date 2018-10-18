using System;
using System.Collections.Generic;
using DataAccess.Crud;
using Entities;
using Exceptions;

namespace CoreAPI
{
    public class LoanManager : BaseManager
    {
        private readonly LoanCrudFactory crudLoan;

        public LoanManager()
        {
            crudLoan = new LoanCrudFactory();
        }

        public void Create(Loans loan)
        {
            try
            {
                var c = crudLoan.Retrieve<Loans>(loan);
                if (c != null) throw new BusinessException(3);

                crudLoan.Create(loan);
            }
            catch (Exception ex)
            {
                ExceptionManager.GetInstance().Process(ex);
            }
        }

        public List<Loans> RetrieveAll()
        {
            return crudLoan.RetrieveAll<Loans>();
        }

        public Loans RetrieveById(Loans loan)
        {
            Loans c = null;
            try
            {
                c = crudLoan.Retrieve<Loans>(loan);
                if (c == null) throw new BusinessException(4);
            }
            catch (Exception ex)
            {
                ExceptionManager.GetInstance().Process(ex);
            }

            return c;
        }

        public void Update(Loans loan)
        {
            crudLoan.Update(loan);
        }

        public void Delete(Loans loan)
        {
            crudLoan.Delete(loan);
        }
    }
}