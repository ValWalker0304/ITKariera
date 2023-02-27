using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTPServer.Responses
{
    public interface IHttpResponse
    {
        IHttpResponseStatusCode StatusCode { get; set; }
        IHttpHeaderCollection Headers { get; }

        byte[] Content  { get; set; }

        void AddHeader(HttpHeader header);

        byte[] GetBytes();
    }
}
