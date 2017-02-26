namespace API
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class permission_group_name
    {
        [Key]
        public int PermissionGroupNameID { get; set; }

        public int? PermissionGroupID { get; set; }

        [StringLength(100)]
        public string PermissionGroupName { get; set; }

        public int? LangID { get; set; }

        public virtual permission_group permission_group { get; set; }
    }
}
