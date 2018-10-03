using System.Collections.Generic;
using DataAccess.Dao;
using Entities;

namespace DataAccess.Mapper
{
    public class AddressMapper : EntityMapper, ISqlStatements, IObjectMapper
    {
        private const string DB_COL_IDCUSTOMER = "CUSTOMERID";
        private const string DB_COL_PROVINCE = "PROVINCE";
        private const string DB_COL_STREET = "STREET";
        private const string DB_COL_DISTRICT = "DISTRICT";

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var address = new Address
            {
                IDCustomer = GetStringValue(row, DB_COL_IDCUSTOMER),
                Province = GetStringValue(row, DB_COL_PROVINCE),
                Street = GetStringValue(row, DB_COL_STREET),
                District = GetStringValue(row, DB_COL_DISTRICT)
            };
            return address;
        }

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();
            foreach (var row in lstRows)
            {
                var address = BuildObject(row);
                lstResults.Add(address);
            }

            return lstResults;
        }

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation {ProcedureName = "CRE_ADDRESS_PR"};
            var c = (Address) entity;
            operation.AddVarcharParam(DB_COL_IDCUSTOMER, c.IDCustomer);
            operation.AddVarcharParam(DB_COL_PROVINCE, c.Province);
            operation.AddVarcharParam(DB_COL_STREET, c.Street);
            operation.AddVarcharParam(DB_COL_DISTRICT, c.District);

            return operation;
        }

        public SqlOperation GetRetrieveAllStatement()
        {
            var operation = new SqlOperation {ProcedureName = "RET_ALL_ADDRESS_PR"};
            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation {ProcedureName = "UPD_ADDRESS_PR"};
            var c = (Address) entity;
            operation.AddVarcharParam(DB_COL_IDCUSTOMER, c.IDCustomer);
            operation.AddVarcharParam(DB_COL_PROVINCE, c.Province);
            operation.AddVarcharParam(DB_COL_STREET, c.Street);
            operation.AddVarcharParam(DB_COL_DISTRICT, c.District);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation {ProcedureName = "DEL_ADDRESS_PR"};
            var c = (Address) entity;
            operation.AddVarcharParam(DB_COL_IDCUSTOMER, c.IDCustomer);
            return operation;
        }

        public SqlOperation GetRetrieveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation {ProcedureName = "RET_ADDRESS_PR"};
            var c = (Address) entity;
            operation.AddVarcharParam(DB_COL_IDCUSTOMER, c.IDCustomer);
            return operation;
        }
    }
}