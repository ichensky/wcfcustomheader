using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Web;
using System.Text;
using System.Web;

namespace FeedService
{
    public class FeedService : IFeedService
    {
        public string GetData(string q, string num, string t)
        {
            var s = "";

            var str = new StringBuilder("{\"responseData\": {\"xmlString\":\"");
            str.Append(s);
            str.Append("\"}, \"responseDetails\": null, \"responseStatus\": 200}");

            if (WebOperationContext.Current != null)
                WebOperationContext.Current.OutgoingResponse.ContentType = "text/javascript; charset=utf-8";

            return str.ToString();
        }
    }
}
