using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ReziAlexa.Models;

namespace ReziAlexa.Controllers
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
                response = "Hello world"
            };
            data.response.shouldEndSession = true;
            return data;
        }

    }
}
