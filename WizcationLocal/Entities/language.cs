namespace WizcationLocal.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("language")]
    public partial class language
    {
        [Key]
        public int LangID { get; set; }

        [StringLength(50)]
        public string LangName { get; set; }

        [StringLength(50)]
        public string LangPrefix { get; set; }

        public int? Activated { get; set; }

        public int? Deleted { get; set; }
    }
}
