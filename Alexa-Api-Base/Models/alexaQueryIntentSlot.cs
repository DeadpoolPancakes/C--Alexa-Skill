using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlexaBase.Models
{
    public class alexaQueryIntentSlot
    {

        //all slot types must be mapped out in here to get intellisense
        public alexaQueryIntentSlotValue slotname { get; set; }
        public alexaQueryIntentSlotValue slotnametwo { get; set; }

    }
}