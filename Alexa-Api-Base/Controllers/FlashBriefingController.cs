using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AlexaBase.Models;

namespace AlexaBase.Controllers
{
    public class FlashBriefingController : ApiController
    {
        // GET: FlashBriefing
        public BriefingResponse GetFlashBriefing()
        {
            BriefingResponse briefing = new BriefingResponse();
            briefing.uid = new Guid();
            briefing.updateDate = DateTime.Now;
            briefing.titleText = "Your custom flash briefing";
            briefing.mainText = "This is your custom flash briefing response";
            briefing.redirectionUrl = "https://github.com/DeadpoolPancakes/WebAPI-Alexa-Skill";
            return briefing;
        }
    }
}