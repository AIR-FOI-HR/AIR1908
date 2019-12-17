using database.Entities;
using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace webservice
{
    public class MyWebServiceCaller
    {
        MyWebServiceHandler mMyWebServiceHandler;
        public Store[] _storeItems;
        private static MyWebService _api;

        private const String baseUrl = "http://cortex.foi.hr/mtl/courses/air";

        public MyWebServiceCaller()
        {
            
        }

        public MyWebServiceCaller(MyWebServiceHandler myWebServiceHandler)
        {
            mMyWebServiceHandler = myWebServiceHandler;
        }


        public async void getAll(Dictionary<String, String> method, String entityType)
        {
            _api = RestService.For<MyWebService>(baseUrl);
            

            var callStores = await _api.getStores(method);
            var callDiscounts = await _api.getStores(method);

            if (callStores != null)
            {
                if (entityType == "store")
                {
                    handleStores(callStores);
                }
            }

        }

        private void handleStores(MyWebServiceResponse responseStores)
        {
            Store[] storeItems = JsonConvert.DeserializeObject<Store[]>(responseStores.items);
            if (mMyWebServiceHandler != null)
            {
                mMyWebServiceHandler.onDataArrived(new List<Store>(storeItems), true, responseStores.timeStamp);
                _storeItems = storeItems;
            }
            
        }
        public Store[] SendStoreItems() {
            return _storeItems;
        }

        private void handleDiscounts(MyWebServiceResponse responseDiscounts)
        {

            Discount[] discountItems = JsonConvert.DeserializeObject<Discount[]>(responseDiscounts.items, new JsonSerializerSettings
{
                DateFormatString = "yyyy-MM-dd"
});
            if (mMyWebServiceHandler != null)
            {
                mMyWebServiceHandler.onDataArrived(new List<Discount>(discountItems), true, responseDiscounts.timeStamp);

            }

        }

    }
}
