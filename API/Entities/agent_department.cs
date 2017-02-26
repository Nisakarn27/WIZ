namespace API
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class agent_department
    {
        [Key]
        public int AgentDeptID { get; set; }

        public int AgentTypeID { get; set; }

        [StringLength(50)]
        public string AgentDeptName { get; set; }

        public int? Deleted { get; set; }

        public virtual agent_type agent_type { get; set; }
    }
}
