namespace WizcationLocal.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class poperties_catergory
    {
        [Key]
        public int PropertiesCatergoryID { get; set; }

        [StringLength(50)]
        public string PropertiesCatergoryName { get; set; }
    }
}
