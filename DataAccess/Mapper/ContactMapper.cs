using System.Collections.Generic;
using DataAccess.Dao;
using Entities;

namespace DataAccess.Mapper
{
    public class ContactMapper : EntityMapper, ISqlStatements, IObjectMapper
    {
        private const string DB_COL_ID = "CUSTOMERID";
        private const string DB_COL_TYPE = "COMMSTYPE";
        private const string DB_COL_VALUE = "COMMSVALUE";

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var contact = new Contact
            {
                ID = GetStringValue(row, DB_COL_ID),
                TypeCommunication = GetStringValue(row, DB_COL_TYPE),
                Value = GetStringValue(row, DB_COL_VALUE)
            };
            return contact;
        }

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();
            foreach (var row in lstRows)
            {
                var contact = BuildObject(row);
                lstResults.Add(contact);
            }

            return lstResults;
        }

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation {ProcedureName = "CRE_CONTACT_PR"};
            var c = (Contact) entity;
            operation.AddVarcharParam(DB_COL_ID, c.ID);
            operation.AddVarcharParam(DB_COL_TYPE, c.TypeCommunication);
            operation.AddVarcharParam(DB_COL_VALUE, c.Value);


            return operation;
        }

        public SqlOperation GetRetrieveAllStatement()
        {
            var operation = new SqlOperation {ProcedureName = "RET_ALL_CONTACT_PR"};
            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation {ProcedureName = "UPD_CONTACT_PR"};
            var c = (Contact) entity;
            operation.AddVarcharParam(DB_COL_ID, c.ID);
            operation.AddVarcharParam(DB_COL_TYPE, c.TypeCommunication);
            operation.AddVarcharParam(DB_COL_VALUE, c.Value);


            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation {ProcedureName = "DEL_CONTACT_PR"};
            var c = (Contact) entity;
            operation.AddVarcharParam(DB_COL_ID, c.ID);
            return operation;
        }

        public SqlOperation GetRetrieveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation {ProcedureName = "RET_CONTACT_PR"};
            var c = (Contact) entity;
            operation.AddVarcharParam(DB_COL_ID, c.ID);
            return operation;
        }
    }
}