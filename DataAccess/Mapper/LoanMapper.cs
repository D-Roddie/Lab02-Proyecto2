

using System.Collections.Generic;
using DataAccess.Dao;
using Entities;

namespace DataAccess.Mapper
{
    public class LoanMapper : EntityMapper, ISqlStatements, IObjectMapper
    {
        private const string DB_COL_ID = "LOANSID";
        private const string DB_COL_AMOUNT = "AMOUNT";
        private const string DB_COL_RATE = "RATE";
        private const string DB_COL_LOANNAME = "LOANNAME";
        private const string DB_COL_SHARE= "SHARE";
        private const string DB_COL_STARTDATE = "STARTDATE";
        private const string DB_COL_LOANSTATUS= "LOANSTATUS";
        private const string DB_COL_BALANCEOPERATION = "BALANCEOPERATION";
        
        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var loan = new Loans
            {
                LoansID = GetStringValue(row, DB_COL_ID),
                Amount = GetStringValue(row, DB_COL_AMOUNT),
                Rate = GetStringValue(row, DB_COL_RATE),
                LoanName = GetStringValue(row, DB_COL_LOANNAME),
                Share = GetStringValue(row, DB_COL_SHARE),
                StartDate = GetStringValue(row, DB_COL_STARTDATE),
                Status = GetStringValue(row, DB_COL_LOANSTATUS),
                BalanceOperation = GetStringValue(row, DB_COL_BALANCEOPERATION)
            };
            return loan;
        }

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();
            foreach (var row in lstRows)
            {
                var loan = BuildObject(row);
                lstResults.Add(loan);
            }

            return lstResults;
        }

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_LOAN_PR" };
            var c = (Loans)entity;
            operation.AddVarcharParam(DB_COL_ID, c.LoansID);
            operation.AddVarcharParam(DB_COL_AMOUNT, c.Amount);
            operation.AddVarcharParam(DB_COL_RATE, c.Rate);
            operation.AddVarcharParam(DB_COL_LOANNAME, c.LoanName);
            operation.AddVarcharParam(DB_COL_SHARE, c.Share);
            operation.AddVarcharParam(DB_COL_STARTDATE, c.StartDate);
            operation.AddVarcharParam(DB_COL_LOANSTATUS, c.Status);
            operation.AddVarcharParam(DB_COL_BALANCEOPERATION, c.Amount);

            return operation;
        }

        public SqlOperation GetRetrieveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_LOAN_PR" };
            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_ACCOUNT_PR" };
            var c = (Loans)entity;
            operation.AddVarcharParam(DB_COL_ID, c.LoansID);
            operation.AddVarcharParam(DB_COL_AMOUNT, c.Amount);
            operation.AddVarcharParam(DB_COL_RATE, c.Rate);
            operation.AddVarcharParam(DB_COL_LOANNAME, c.LoanName);
            operation.AddVarcharParam(DB_COL_SHARE, c.Share);
            operation.AddVarcharParam(DB_COL_STARTDATE, c.StartDate);
            operation.AddVarcharParam(DB_COL_LOANSTATUS, c.Status);
            operation.AddVarcharParam(DB_COL_BALANCEOPERATION, c.Amount);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_LOAN_PR" };
            var c = (Loans)entity;
            operation.AddVarcharParam(DB_COL_ID, c.LoansID);
            return operation;
        }

        public SqlOperation GetRetrieveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_LOAN_PR" };
            var c = (Loans)entity;
            operation.AddVarcharParam(DB_COL_ID, c.LoansID);
            return operation;
        }
    }
}