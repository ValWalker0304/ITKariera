using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTPServer.Enums
{
    public enum HttpResponseStatusCode
    {
        Ok = 200,
        Created = 201,
        Found = 302,
        SeeOther = 303,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 4033,
        NotFound = 404,
        InternalServerError = 500
    }
}
