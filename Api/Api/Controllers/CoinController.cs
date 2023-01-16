using Api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    [System.Web.Http.Cors.EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/Coins")]
    public class CoinsController : ApiController
    {
        [HttpGet]
        [Route("GetCoins")]
        public Response GetCoins()
        {
            Response result = new Response();
            try
            {
                result.Data = new CoinsService().GetNegetiveCoins();
                result.IsSuccess = true;
                result.StatusCode = HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Message = $"Error: {ex.Message} try again";
                result.StatusCode = HttpStatusCode.Unauthorized;
            }
            return result;
        }
    }
}
