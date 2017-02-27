namespace API
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class staff
    {
        public int StaffID { get; set; }

        public int StaffRoleID { get; set; }

        [StringLength(50)]
        public string StaffCode { get; set; }

        [StringLength(50)]
        public string StaffGender { get; set; }

        [StringLength(50)]
        public string StaffFirstName { get; set; }

        [StringLength(50)]
        public string StaffLastName { get; set; }

        [StringLength(50)]
        public string StaffAddress1 { get; set; }

        [StringLength(100)]
        public string StaffAddress2 { get; set; }

        [StringLength(100)]
        public string StaffCity { get; set; }

        public int? StaffProvince { get; set; }

        public int? StaffZipCode { get; set; }

        public int? StaffTelephone { get; set; }

        public int? StaffMobile { get; set; }

        public int? StaffEmail { get; set; }

        public DateTime? StaffIDIssueDate { get; set; }

        public DateTime? StaffIDExpiration { get; set; }

        [StringLength(100)]
        public string StaffPictureServer { get; set; }

        [StringLength(100)]
        public string StaffPictureClient { get; set; }

        public DateTime? InputDate { get; set; }

        public int? InputBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        public int? UpdateBy { get; set; }

        public DateTime? LastUseDate { get; set; }

        public int? Activated { get; set; }

        public int? Deleted { get; set; }

        public int? IsAgent { get; set; }

        public virtual staff staffs1 { get; set; }
    }
}
