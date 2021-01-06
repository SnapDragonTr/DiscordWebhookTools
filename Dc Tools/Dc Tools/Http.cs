using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Dc_Tools
{
    class Http
    {
        public static byte[] Post(string uri, NameValueCollection Pairs)
        {
            using (WebClient webClient = new WebClient())
                return webClient.UploadValues(uri, Pairs);

        }
    }
}
