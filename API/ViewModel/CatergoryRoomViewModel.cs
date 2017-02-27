using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.ViewModel
{
    public class CatergoryRoomViewModel
    {
         public int CatergoryRoomID { get; set; }

         public string RoomName { get; set; }

        public double? PriceDefault { get; set; }

         public string Description { get; set; }

         public string OrderImage { get; set; }

        public int MaximunAllowingGuest { get; set; }

        public int AgentID { get; set; }

        public CalendarPrice CalendarPrices { get; set; }
    }
}