using System;
using System.Web.Http;
using CoreAPI;
using Entities;
using Exceptions;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ExceptionFilter]
    public class LoanController : ApiController
    {
        private ApiResponse apiResp = new ApiResponse();

        //GET api/loan
        public IHttpActionResult Get()
        {
            apiResp = new ApiResponse();
            var mng = new LoanManager();
            apiResp.Data = mng.RetrieveAll();
            return Ok(apiResp);
        }

        // GET api/loan/5
        public IHttpActionResult Get(string id)
        {
            try
            {
                var mng = new LoanManager();
                var loan = new Loans
                {
                    LoansID = id
                };
                loan = mng.RetrieveById(loan);
                apiResp = new ApiResponse();
                apiResp.Data = loan;
                return Ok(apiResp);
            }
            catch (BusinessException bex)
            {
                return InternalServerError(new Exception(bex.ExceptionID + "-" + bex.AppMessage.Message));
            }
        }

        // POST 
        public IHttpActionResult Post(Loans loan)
        {
            try
            {
                var mng = new LoanManager();
                mng.Create(loan);
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
        public IHttpActionResult Put(Loans loan)
        {
            try
            {
                var mng = new LoanManager();
                mng.Update(loan);
                apiResp = new ApiResponse();
                apiResp.Message = "Action was executed.";

                return Ok(apiResp);
            }
            catch (BusinessException bex)
            {
                return InternalServerError(new Exception(bex.ExceptionID + "-" + bex.AppMessage.Message));
            }
        }

        // DELETE 
        public IHttpActionResult Delete(Loans loan)
        {
            try
            {
                var mng = new LoanManager();
                mng.Delete(loan);
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