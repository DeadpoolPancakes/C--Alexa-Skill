using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlexaBase.Models
{
    public class BriefingResponse
    {
        public Guid uid { get; set; }
        public DateTime updateDate { get; set; }
        public string titleText { get; set; }
        public string mainText { get; set; }
        public string redirectionUrl { get; set; }
    }
}