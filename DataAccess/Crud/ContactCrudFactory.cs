using System;
using System.Collections.Generic;
using DataAccess.Dao;
using DataAccess.Mapper;
using Entities;

namespace DataAccess.Crud
{
    public class ContactCrudFactory : CrudFactory
    {
        private readonly ContactMapper mapper;

        public ContactCrudFactory()
        {
            mapper = new ContactMapper();
            dao = SqlDao.GetInstance();
        }


        public override void Create(BaseEntity entity)
        {
            var contact = (Contact) entity;
            var sqlOperation = mapper.GetCreateStatement(contact);
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
            var lstContact = new List<T>();
            var lstResult = dao.ExecuteQueryProcedure(mapper.GetRetrieveAllStatement());
            var dic = new Dictionary<string, object>();
            if (lstResult.Count > 0)
            {
                var objs = mapper.BuildObjects(lstResult);
                foreach (var c in objs) lstContact.Add((T) Convert.ChangeType(c, typeof(T)));
            }

            return lstContact;
        }

        public override void Update(BaseEntity entity)
        {
            var contact = (Contact) entity;
            dao.ExecuteProcedure(mapper.GetUpdateStatement(contact));
        }

        public override void Delete(BaseEntity entity)
        {
            var contact = (Contact) entity;
            dao.ExecuteProcedure(mapper.GetDeleteStatement(contact));
        }
    }
}