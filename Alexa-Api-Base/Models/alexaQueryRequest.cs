using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlexaBase.Models
{
    public class alexaQueryRequest
    {
        public string type { get; set;}
        public string reuqestId { get; set; }
        public string locale { get; set; }
        public string timestamp { get; set; }
        public alexaQueryIntent intent { get; set; }

    }
}