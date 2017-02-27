namespace API
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class permission_group
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public permission_group()
        {
            permission_group_name = new HashSet<permission_group_name>();
        }

        [Key]
        public int PermissionGroupID { get; set; }

        [StringLength(100)]
        public string PermissionGroupTranslate { get; set; }

        public int? PermissionGroupOrdering { get; set; }

        [StringLength(50)]
        public string Deleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<permission_group_name> permission_group_name { get; set; }
    }
}
