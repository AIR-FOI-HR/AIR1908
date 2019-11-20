using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Refit;

namespace webservice
{
    public interface MyWebService
    {
        [Post("stores.php")]
        Task<MyWebServiceResponse> getStores([Body(BodySerializationMethod.UrlEncoded)][AliasAs("method")] String method);

        [Post("discounts.php")]
        Task<MyWebServiceResponse> getDiscounts([Body(BodySerializationMethod.UrlEncoded)][AliasAs("method")] String method);
    }
}
