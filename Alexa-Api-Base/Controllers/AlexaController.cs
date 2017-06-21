using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AlexaBase.Models;

namespace AlexaBase.Controllers
{
    public class AlexaController : ApiController
    {
        private alexa data = new alexa()
        {
            version = "1.0",
            response = new AlexaResponse(),
            sessionAttributes = {}

        };
        public alexa GetResponse()
        {
            data.response.outputSpeech = new alexaOutputSpeech()
            {
              type  = "PlainText",
              response = "Hello world"
            };
            data.response.shouldEndSession = true;
            return data;
        }
        public alexa PostResponse(alexaQuery query)
        {
            data.response.outputSpeech = new alexaOutputSpeech()
            {
                type = query.request.intent.name,
                response = query.request.intent.slots.slotname.value
            };
            data.response.shouldEndSession = true;
            return data;
        }

    }
}
