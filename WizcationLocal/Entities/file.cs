namespace WizcationLocal.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("file")]
    public partial class file
    {
        [Key]
        public int FilesID { get; set; }

        public int? AgentID { get; set; }

        public string FileName { get; set; }

        public string Type { get; set; }

        public string AbsolutePath { get; set; }

        public bool? Deleted { get; set; }

        public DateTime? CreateDate { get; set; }

        public virtual agent__data agent__data { get; set; }
    }
}
