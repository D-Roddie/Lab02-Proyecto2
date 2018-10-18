using System;
using System.Web.Http;
using CoreAPI;
using Entities;
using Exceptions;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ExceptionFilter]
    public class AccountController : ApiController
    {
        private ApiResponse apiResp = new ApiResponse();

        // GET api/account
        public IHttpActionResult Get()
        {
            apiResp = new ApiResponse();
            var mng = new AccountManager();
            apiResp.Data = mng.RetrieveAll();
            return Ok(apiResp);
        }

        // GET/api/account/5
        public IHttpActionResult Get(string id)
        {
            try
            {
                var mng = new AccountManager();
                var account = new Account
                {
                    Identification = id
                };
                account = mng.RetrieveById(account);
                apiResp = new ApiResponse();
                apiResp.Data = account;
                return Ok(apiResp);
            }
            catch (BusinessException bex)
            {
                return InternalServerError(new Exception(bex.ExceptionID + "-" + bex.AppMessage.Message));
            }
        }

        // POST 
        public IHttpActionResult Post(Account account)
        {
            try
            {
                var mng = new AccountManager();
                mng.Create(account);
                apiResp = new ApiResponse();
                apiResp.Message = "Action was executed";
                return Ok(apiResp);
            }
            catch (BusinessException bex)
            {
                return InternalServerError(new Exception(bex.ExceptionID + "-" + bex.AppMessage.Message));
            }
        }

        // PUT 
        public IHttpActionResult Put(Account account)
        {
            try
            {
                var mng = new AccountManager();
                mng.Update(account);
                apiResp = new ApiResponse();
                apiResp.Message = "Action was executed";
                return Ok(apiResp);
            }
            catch (BusinessException bex)
            {
                return InternalServerError(new Exception(bex.ExceptionID + "-" + bex.AppMessage.Message));
            }
        }

        // DELETE 
        public IHttpActionResult Delete(Account account)
        {
            try
            {
                var mng = new AccountManager();
                mng.Delete(account);
                apiResp = new ApiResponse();
                apiResp.Message = "Action was executed";
                return Ok(apiResp);
            }
            catch (BusinessException bex)
            {
                return InternalServerError(new Exception(bex.ExceptionID + "-" + bex.AppMessage.Message));
            }
        }
    }
}