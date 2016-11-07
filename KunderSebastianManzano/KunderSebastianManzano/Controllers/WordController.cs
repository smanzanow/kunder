using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using KunderSebastianManzano.Models;

namespace KunderSebastianManzano.Controllers
{
    public class WordController : ApiController
    {
        public Word Post(string data)
        {
            Word ReturnData = new Word();
            try
            {
                if (data.Length == 4)
                {
                    ReturnData.description = "Success";
                    ReturnData.data = data.ToUpper();
                }
                else
                {
                    var a = new HttpResponseException(HttpStatusCode.BadRequest);
                    ReturnData.code = a.Response.StatusCode.GetHashCode().ToString();
                    ReturnData.description = a.Response.StatusCode.ToString();
                }
            }
            catch 
            {
                var a = new HttpResponseException(HttpStatusCode.InternalServerError);
                ReturnData.code = a.Response.StatusCode.GetHashCode().ToString();
                ReturnData.description = a.Response.StatusCode.ToString();
            }
            return ReturnData;
        }
    }
}
