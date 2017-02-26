namespace API
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class permission_item_name
    {
        [Key]
        [Column(Order = 0)]
        public int PermissionItemNameID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PermissionItemID { get; set; }

        [StringLength(100)]
        public string PermissionItemName { get; set; }

        public int? LangID { get; set; }
    }
}
