namespace WizcationLocal.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class calendar_price
    {
        [Key]
        public int PriceCalendarID { get; set; }

        public int? AgentID { get; set; }

        public int? CatergoryRoomID { get; set; }

        public double? PromotionPrice { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }

        public DateTime? LastUpdate { get; set; }
    }
}
