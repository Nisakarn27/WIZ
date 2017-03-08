namespace WizcationLocal.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class catergory_room
    {
        [Key]
        public int CatergoryRoomID { get; set; }

        [StringLength(100)]
        public string RoomName { get; set; }

        public double? PriceDefault { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        [Column(TypeName = "text")]
        public string OrderImage { get; set; }

        public int? MaximunAllowingGuest { get; set; }

        public int AgentID { get; set; }

        public virtual agent__data agent__data { get; set; }
    }
}
