using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using KunderSebastianManzano.Models;

namespace KunderSebastianManzano.Controllers
{
    public class TimeController : ApiController
    {
        public Time Get(DateTime hora)
        {
            Time returnData = new Time();
            try
            {
                returnData.code = "200";
                returnData.description = "Success";
                returnData.data = hora.ToUniversalTime().ToString();
            }
            catch
            {
                var a = new HttpResponseException(HttpStatusCode.InternalServerError);
                returnData.code = a.Response.StatusCode.GetHashCode().ToString();
                returnData.description = a.Response.StatusCode.ToString();
            }
            return returnData;
        }
    }
}
