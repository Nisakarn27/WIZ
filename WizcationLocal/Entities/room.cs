namespace WizcationLocal.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("room")]
    public partial class room
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public room()
        {
            booking_log = new HashSet<booking_log>();
            calendar_price = new HashSet<calendar_price>();
        }

        public int RoomID { get; set; }

        public int? AgentID { get; set; }

        public int? CatergoryRoomID { get; set; }

        public int? StatusRoomID { get; set; }

        public virtual agent__data agent__data { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<booking_log> booking_log { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<calendar_price> calendar_price { get; set; }

        public virtual catergory_room catergory_room { get; set; }

        public virtual status_room status_room { get; set; }
    }
}
