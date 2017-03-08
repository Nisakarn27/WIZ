namespace WizcationLocal.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("agent _data")]
    public partial class agent__data
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public agent__data()
        {
            catergory_room = new HashSet<catergory_room>();
        }

        [Key]
        public int AgentID { get; set; }

        public int AgentType { get; set; }

        [StringLength(100)]
        public string AgentName { get; set; }

        [StringLength(100)]
        public string AgentTATNumber { get; set; }

        [StringLength(100)]
        public string AgentRegisterID { get; set; }

        [StringLength(100)]
        public string AgentCode { get; set; }

        [StringLength(100)]
        public string AgentAddress1 { get; set; }

        [StringLength(100)]
        public string AgentAddress2 { get; set; }

        [StringLength(80)]
        public string AgentCity { get; set; }

        public int? AgentProvince { get; set; }

        [StringLength(15)]
        public string AgentZipCode { get; set; }

        [StringLength(250)]
        public string AgentContactName { get; set; }

        [StringLength(20)]
        public string AgentMobile { get; set; }

        [StringLength(20)]
        public string AgentTelephone { get; set; }

        [StringLength(20)]
        public string AgentFax { get; set; }

        [StringLength(100)]
        public string AgentEmail { get; set; }

        [StringLength(100)]
        public string AgentPictureServer { get; set; }

        [StringLength(100)]
        public string AgentPictureClient { get; set; }

        [StringLength(50)]
        public string Latitude { get; set; }

        [StringLength(58)]
        public string Longitude { get; set; }

        public int? IsStaffRegister { get; set; }

        public DateTime? InputDate { get; set; }

        public int? InputBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        public int? UpdateBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<catergory_room> catergory_room { get; set; }
    }
}
