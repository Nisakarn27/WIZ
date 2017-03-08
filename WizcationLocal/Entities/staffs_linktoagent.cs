namespace WizcationLocal.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class staffs_linktoagent
    {
        [Key]
        public int StaffID { get; set; }

        public int? AgentTypeID { get; set; }

        public virtual agent_type agent_type { get; set; }
    }
}
