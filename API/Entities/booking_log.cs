namespace API
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class booking_log
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BookingID { get; set; }

        public int? AgentID { get; set; }

        public int? PriceBooking { get; set; }

        public int? CreateUser { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateTimeBooking { get; set; }

        [StringLength(50)]
        public string DiscondCode { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LastUpdateBooking { get; set; }

        public int? LastUpdateUser { get; set; }

        public int? RoomID { get; set; }

        public int? CatergoryRoomID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CheckInDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CheckOutDate { get; set; }

        public int? StatusBooking { get; set; }

        public virtual catergory_room catergory_room { get; set; }

        public virtual room room { get; set; }

        public virtual status_booking status_booking { get; set; }
    }
}
