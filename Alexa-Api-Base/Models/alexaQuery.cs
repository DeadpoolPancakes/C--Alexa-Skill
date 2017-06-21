using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReziAlexa.Models
{
    public class alexaQuery
    {
        public alexaQuerySession session { get; set; }
        public alexaQueryRequest request { get; set; }
        public string version { get; set; }
    }
}