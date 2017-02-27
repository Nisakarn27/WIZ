namespace API
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class properties_amenities
    {
        [Key]
        public int PropertiesAmenitiesID { get; set; }

        [StringLength(50)]
        public string PropertiesAmenitiesName { get; set; }
    }
}
