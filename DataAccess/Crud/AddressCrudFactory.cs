using System;
using System.Collections.Generic;
using DataAccess.Dao;
using DataAccess.Mapper;
using Entities;

namespace DataAccess.Crud
{
    public class AddressCrudFactory : CrudFactory
    {
        private readonly AddressMapper mapper;

        public AddressCrudFactory()
        {
            mapper = new AddressMapper();
            dao = SqlDao.GetInstance();
        }


        public override void Create(BaseEntity entity)
        {
            var address = (Address) entity;
            var sqlOperation = mapper.GetCreateStatement(address);
            dao.ExecuteProcedure(sqlOperation);
        }

        public override T Retrieve<T>(BaseEntity entity)
        {
            var lstResult = dao.ExecuteQueryProcedure(mapper.GetRetrieveStatement(entity));
            var dic = new Dictionary<string, object>();
            if (lstResult.Count > 0)
            {
                dic = lstResult[0];
                var objs = mapper.BuildObject(dic);
                return (T) Convert.ChangeType(objs, typeof(T));
            }

            return default(T);
        }

        public override List<T> RetrieveAll<T>()
        {
            var lstAddress = new List<T>();
            var lstResult = dao.ExecuteQueryProcedure(mapper.GetRetrieveAllStatement());
            var dic = new Dictionary<string, object>();
            if (lstResult.Count > 0)
            {
                var objs = mapper.BuildObjects(lstResult);
                foreach (var c in objs) lstAddress.Add((T) Convert.ChangeType(c, typeof(T)));
            }

            return lstAddress;
        }

        public override void Update(BaseEntity entity)
        {
            var address = (Address) entity;
            dao.ExecuteProcedure(mapper.GetUpdateStatement(address));
        }

        public override void Delete(BaseEntity entity)
        {
            var address = (Address) entity;
            dao.ExecuteProcedure(mapper.GetDeleteStatement(address));
        }
    }
}