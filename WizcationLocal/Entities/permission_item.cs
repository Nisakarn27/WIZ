namespace WizcationLocal.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class permission_item
    {
        [Key]
        public int PermissionItemID { get; set; }

        [StringLength(100)]
        public string PermissionItemTranslate { get; set; }

        [StringLength(100)]
        public string PermissionItemUrl { get; set; }

        public int? PermissionItemOrdering { get; set; }

        public int? Activated { get; set; }

        [StringLength(50)]
        public string Deleted { get; set; }
    }
}
