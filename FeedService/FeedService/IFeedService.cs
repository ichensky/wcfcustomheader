using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace FeedService
{
    [ServiceContract]
    public interface IFeedService
    {

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <param name="q">The q - the query consists of a URL.</param>
        /// <param name="num">The number - Applicable to load feed only. This optional argument supplies the number of entries to load from the feed specified by q. A value of -1 indicates the maximum number of entries supported, currently 100. By default, load feed returns four results.</param>
        /// <param name="t">The t.</param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle  = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json, UriTemplate = "load?q={q}&num={num}&t={t}")]
        string GetData(string q, string num, string t);
    }
}
