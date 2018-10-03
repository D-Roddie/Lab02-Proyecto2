using System.Collections.Generic;
using DataAccess.Dao;
using Entities;

namespace DataAccess.Mapper
{
    public class AccountMapper : EntityMapper, ISqlStatements, IObjectMapper
    {
        private const string DB_COL_ID = "ID";
        private const string DB_COL_ACCNAME = "ACCNAME";
        private const string DB_COL_CURRECY = "CURRENCY";
        private const string DB_COL_BALANCE = "BALANCE";

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var account = new Account
            {
                Identification = GetStringValue(row, DB_COL_ID),
                AccountName = GetStringValue(row, DB_COL_ACCNAME),
                Currency = GetStringValue(row, DB_COL_CURRECY),
                Balance = GetIntValue(row, DB_COL_BALANCE)
            };
            return account;
        }

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();
            foreach (var row in lstRows)
            {
                var account = BuildObject(row);
                lstResults.Add(account);
            }

            return lstResults;
        }

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation {ProcedureName = "CRE_ACCOUNT_PR"};
            var c = (Account) entity;
            operation.AddVarcharParam(DB_COL_ID, c.Identification);
            operation.AddVarcharParam(DB_COL_ACCNAME, c.AccountName);
            operation.AddVarcharParam(DB_COL_CURRECY, c.Currency);
            operation.AddIntParam(DB_COL_BALANCE, c.Balance);

            return operation;
        }

        public SqlOperation GetRetrieveAllStatement()
        {
            var operation = new SqlOperation {ProcedureName = "RET_ALL_ACCOUNT_PR"};
            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation {ProcedureName = "UPD_ACCOUNT_PR"};
            var c = (Account) entity;
            operation.AddVarcharParam(DB_COL_ID, c.Identification);
            operation.AddVarcharParam(DB_COL_ACCNAME, c.AccountName);
            operation.AddVarcharParam(DB_COL_CURRECY, c.Currency);
            operation.AddIntParam(DB_COL_BALANCE, c.Balance);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation {ProcedureName = "DEL_ACCOUNT_PR"};
            var c = (Account) entity;
            operation.AddVarcharParam(DB_COL_ID, c.Identification);
            return operation;
        }

        public SqlOperation GetRetrieveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation {ProcedureName = "RET_ACCOUNT_PR"};
            var c = (Account) entity;
            operation.AddVarcharParam(DB_COL_ID, c.Identification);
            return operation;
        }
    }
}