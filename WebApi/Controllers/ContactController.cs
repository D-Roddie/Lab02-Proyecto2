using System;
using System.Web.Http;
using CoreAPI;
using Entities;
using Exceptions;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ExceptionFilter]
    public class ContactController : ApiController
    {
        private ApiResponse apiResp = new ApiResponse();

        // GET api/contact
        public IHttpActionResult Get()
        {
            apiResp = new ApiResponse();
            var mng = new ContactManager();
            apiResp.Data = mng.RetrieveAll();
            return Ok(apiResp);
        }


        // GET/api/contact/5
        public IHttpActionResult Get(string id)
        {
            try
            {
                var mng = new ContactManager();
                var contact = new Contact
                {
                    ID = id
                };
                contact = mng.RetrieveById(contact);
                apiResp = new ApiResponse();
                apiResp.Data = contact;
                return Ok(apiResp);
            }
            catch (BusinessException bex)
            {
                return InternalServerError(new Exception(bex.ExceptionID + "-" + bex.AppMessage.Message));
            }
        }

        // POST 
        public IHttpActionResult Post(Contact contact)
        {
            try
            {
                var mng = new ContactManager();
                mng.Create(contact);
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
        public IHttpActionResult Put(Contact contact)
        {
            try
            {
                var mng = new ContactManager();
                mng.Update(contact);
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
        public IHttpActionResult Delete(Contact contact)
        {
            try
            {
                var mng = new ContactManager();
                mng.Delete(contact);
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