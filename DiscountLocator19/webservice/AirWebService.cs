using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Refit;

namespace webservice
{
    public interface AirWebService
    {
        [Post("/stores.php")]
        Task<AirWebServiceResponse> getStores([Body(BodySerializationMethod.UrlEncoded)] object method);

        [Post("/discounts.php")]
        Task<AirWebServiceResponse> getDiscounts([Body(BodySerializationMethod.UrlEncoded)] object method);


    }
}
