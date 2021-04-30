using System.Collections.Generic;
using API_App.Services;

namespace API_App
{
    public class ResponseHeaders
    {
        public CallManager callManager;

        public Dictionary<string, string> responseHeadersDict = new Dictionary<string, string>();

        public ResponseHeaders()
        {
            callManager = new CallManager();
        }

        public void GetHeaders()
        {
            foreach (var item in callManager.Response.Headers)
            {
                string[] pairs = item.ToString().Split('=');
                responseHeadersDict.Add(pairs[0], pairs[1]);
            }
        }

    }
}
