using System;
using System.Web.Http;
using CoreAPI;
using Entities;
using Exceptions;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ExceptionFilter]
    public class AddressController : ApiController
    {
        private ApiResponse apiResp = new ApiResponse();

        //GET api/address
        public IHttpActionResult Get()
        {
            apiResp = new ApiResponse();
            var mng = new AddressManager();
            apiResp.Data = mng.RetrieveAll();
            return Ok(apiResp);
        }

        //GET/api/address/5
        public IHttpActionResult Get(string id)
        {
            try
            {
                var mng = new AddressManager();
                var address = new Address
                {
                    IDCustomer = id
                };

                address = mng.RetrieveById(address);
                apiResp = new ApiResponse();
                apiResp.Data = address;
                return Ok(apiResp);
            }
            catch (BusinessException bex)
            {
                return InternalServerError(new Exception(bex.ExceptionID + "-" + bex.AppMessage.Message));
            }
        }

        // POST
        public IHttpActionResult Put(Address address)
        {
            try
            {
                var mng = new AddressManager();
                mng.Update(address);
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
        public IHttpActionResult Delete(Address address)
        {
            try
            {
                var mng = new AddressManager();
                mng.Delete(address);
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