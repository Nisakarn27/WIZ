using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WizcationLocal.ViewModel
{
    public class HotelViewModel
    { 
        public int AgentID { get; set; }

        public int AgentType { get; set; }
 
        public string AgentName { get; set; }
         
        public string AgentTATNumber { get; set; }
         
        public string AgentRegisterID { get; set; }
 
        public string AgentCode { get; set; }
         
        public string AgentAddress1 { get; set; }

        public string AgentAddress2 { get; set; } 

        public string AgentCity { get; set; }

        public int? AgentProvince { get; set; }

         public string AgentZipCode { get; set; }

         public string AgentContactName { get; set; }

         public string AgentMobile { get; set; }

         public string AgentTelephone { get; set; }

         public string AgentFax { get; set; }

         public string AgentEmail { get; set; }

         public string AgentPictureServer { get; set; }

         public string AgentPictureClient { get; set; }

         public string Latitude { get; set; }

         public string Longitude { get; set; }

        public string IDPropertiesCatergory { get; set; }

        public string IDPropertiesAmenities { get; set; }

        public List<string> PropertiesCatergory { get; set; }

        public List<string> PropertiesAmenities { get; set; }

        public double MinPrice{ get; set; }

        public List<CatergoryRoomViewModel> ListCatergoryRoom { get; set; }

    }
}