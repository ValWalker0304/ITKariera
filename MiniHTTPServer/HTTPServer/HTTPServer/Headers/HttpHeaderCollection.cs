using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTPServer.Headers
{
    public class HttpHeaderCollection: IHttpHeaderCollection
    {
        private readonly Dictionary<string, HttpHeader > headers;
        public HttpHeaderCollection()
        {
            this.headers = new Dictionary<string, HttpHeader>();
        }

        public void AddHeader(HttpHeader header)
        {
            this.headers.Add(header.Key, header);
        }

        public bool ContainsHeader(string key)
        {
            if (this.headers.ContainsKey(key))
            {
                return true;
            }
            else 
                return false;
            
        }

        public HttpHeader GetHeader(string key)
        {
            if (ContainsHeader(key) == true)
            {
                return null;//Should return header
            }
            else return null;
        }

        public override string ToString()
        {
            foreach (var header in this.headers)
            {
                return $"{header.Value}/r/n";
            }
            return null;
        }
    }
}
