using System.Collections.Generic;
using DataAccess.Dao;
using Entities;

namespace DataAccess.Mapper
{
    public class CustomerMapper : EntityMapper, ISqlStatements, IObjectMapper
    {
        private const string DB_COL_ID = "ID";
        private const string DB_COL_NAME = "NAME";
        private const string DB_COL_LAST_NAME = "LAST_NAME";
        private const string DB_COL_BIRTHDAY = "BIRTHDAY";
        private const string DB_COL_AGE = "AGE";
        private const string DB_COL_SOCIALSTATUS = "SOCIAL_STATUS";
        private const string DB_COL_GENDER = "GENDER";

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var customer = BuildObject(row);
                lstResults.Add(customer);
            }

            return lstResults;
        }


        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var customer = new Customer
            {
                Id = GetStringValue(row, DB_COL_ID),
                Name = GetStringValue(row, DB_COL_NAME),
                LastName = GetStringValue(row, DB_COL_LAST_NAME),
                Birthday = GetStringValue(row, DB_COL_BIRTHDAY),
                Age = GetIntValue(row, DB_COL_AGE),
                SocialStatus = GetStringValue(row, DB_COL_SOCIALSTATUS),
                Gender = GetStringValue(row, DB_COL_GENDER)
            };

            return customer;
        }


        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation {ProcedureName = "CRE_CUSTOMER_PR"};

            var c = (Customer) entity;
            operation.AddVarcharParam(DB_COL_ID, c.Id);
            operation.AddVarcharParam(DB_COL_NAME, c.Name);
            operation.AddVarcharParam(DB_COL_LAST_NAME, c.LastName);
            operation.AddVarcharParam(DB_COL_BIRTHDAY, c.Birthday);
            operation.AddIntParam(DB_COL_AGE, c.Age);
            operation.AddVarcharParam(DB_COL_SOCIALSTATUS, c.SocialStatus);
            operation.AddVarcharParam(DB_COL_GENDER, c.Gender);

            return operation;
        }


        public SqlOperation GetRetrieveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation {ProcedureName = "RET_CUSTOMER_PR"};

            var c = (Customer) entity;
            operation.AddVarcharParam(DB_COL_ID, c.Id);

            return operation;
        }

        public SqlOperation GetRetrieveAllStatement()
        {
            var operation = new SqlOperation {ProcedureName = "RET_ALL_CUSTOMER_PR"};
            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation {ProcedureName = "UPD_CUSTOMER_PR"};

            var c = (Customer) entity;
            operation.AddVarcharParam(DB_COL_ID, c.Id);
            operation.AddVarcharParam(DB_COL_NAME, c.Name);
            operation.AddVarcharParam(DB_COL_LAST_NAME, c.LastName);
            operation.AddVarcharParam(DB_COL_BIRTHDAY, c.Birthday);
            operation.AddIntParam(DB_COL_AGE, c.Age);
            operation.AddVarcharParam(DB_COL_SOCIALSTATUS, c.SocialStatus);
            operation.AddVarcharParam(DB_COL_GENDER, c.Gender);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation {ProcedureName = "DEL_CUSTOMER_PR"};

            var c = (Customer) entity;
            operation.AddVarcharParam(DB_COL_ID, c.Id);
            return operation;
        }
    }
}