using System.Collections.Generic;
using DataAccess.Crud;
using Entities;

namespace BankAccount
{
    public class LoanManagement
    {
        private readonly LoanCrudFactory crudLoan;

        public LoanManagement()
        {
            crudLoan = new LoanCrudFactory();
        }

        public void Create(Loans loans)
        {
            crudLoan.Create(loans);
        }

        public List<Loans> RetrieveAll()
        {
            return crudLoan.RetrieveAll<Loans>();
        }

        public Loans RetrieveById(Loans loan)
        {
            return crudLoan.Retrieve<Loans>(loan);
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