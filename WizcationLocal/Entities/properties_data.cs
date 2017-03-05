namespace WizcationLocal.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class properties_data
    {
        [Key]
        public int PropertiesID { get; set; }

        public int? AgentID { get; set; }

        public string PropertiesCatergory { get; set; }

        public string PropertiesAmenities { get; set; }
    }
}
