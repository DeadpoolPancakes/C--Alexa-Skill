using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReziAlexa.Models
{
    public class alexaQuerySession
    {
        public string sessionId { get; set; }
        public alexaQuerySessionApplication application {get; set; }
        public alexaQuerySessionAttributes attribute { get; set; }
        public alexaQuerySessionUser user { get; set; }
        public Boolean New {get; set;}
    }
}