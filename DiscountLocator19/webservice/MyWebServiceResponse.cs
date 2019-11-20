using System;
using System.Collections.Generic;
using System.Text;

namespace webservice
{
    public class MyWebServiceResponse
    {
        public int responseId { get; set; }
        public String responseText { get; set; }
        public long timeStamp { get; set; }
        public String items { get; set; }
    }
}
