using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ReziAlexa;

namespace ReziAlexa.Models
{
    public class AlexaResponse
    {
        public alexaOutputSpeech outputSpeech { get; set; }
        public Boolean shouldEndSession { get; set; } 
    }
}