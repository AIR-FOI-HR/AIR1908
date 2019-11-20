using System;
using System.Collections.Generic;
using System.Text;
using Refit;

namespace webservice
{
    public class MyWebServiceCaller
    {
        private readonly String baseUrl = "http://cortex.foi.hr/mtl/courses/air/";

        public MyWebServiceCaller()
        {
            var myApi = RestService.For<MyWebService>(baseUrl);
        }

        public void getAll()
        {

        }
    }
}
