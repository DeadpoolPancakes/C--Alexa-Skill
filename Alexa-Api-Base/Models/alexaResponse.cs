using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AlexaBase;

namespace AlexaBase.Models
{
    public class AlexaResponse
    {
        public alexaOutputSpeech outputSpeech { get; set; }
        public Boolean shouldEndSession { get; set; } 
    }
}