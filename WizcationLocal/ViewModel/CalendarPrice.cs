using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WizcationLocal.ViewModel
{
    public class CalendarPrice
    {
        public int PriceCalendarID { get; set; }

        public int? AgentID { get; set; }

        public int? CatergoryRoomID { get; set; }

        public double? PromotionPrice { get; set; }
         
        public DateTime? StartDate { get; set; }
         
        public DateTime? EndDate { get; set; } 
    }
}