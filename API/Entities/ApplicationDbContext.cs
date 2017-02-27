using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Security.Claims;
using Microsoft.AspNet.Identity;
using System.Threading.Tasks;

namespace API
{
    
    public class ApplicationDbContext : DbContext
    { 
        public  DbSet<agent__data> agent__data { get; set; }
        public  DbSet<agent_department> agent_department { get; set; }
        public  DbSet<agent_linkto> agent_linkto { get; set; }
        public  DbSet<agent_type> agent_type { get; set; }
        public  DbSet<booking_log> booking_log { get; set; }
        public  DbSet<calendar_price> calendar_price { get; set; }
        public  DbSet<catergory_room> catergory_room { get; set; }
        public  DbSet<file> files { get; set; }
        public  DbSet<language> languages { get; set; }
        public  DbSet<permission_group> permission_group { get; set; }
        public  DbSet<permission_group_name> permission_group_name { get; set; }
        public  DbSet<permission_item> permission_item { get; set; }
        public  DbSet<permission_item_name> permission_item_name { get; set; }
        public  DbSet<poperties_catergory> poperties_catergory { get; set; }
        public  DbSet<properties_amenities> properties_amenities { get; set; }
        public  DbSet<properties_data> properties_data { get; set; }
        public  DbSet<room> rooms { get; set; }
        public  DbSet<sales_data> sales_data { get; set; }
        public  DbSet<staff> staffs { get; set; }
        public  DbSet<staffs_linktoagent> staffs_linktoagent { get; set; }
        public  DbSet<staffs_permission> staffs_permission { get; set; }
        public  DbSet<status_booking> status_booking { get; set; }
        public  DbSet<status_room> status_room { get; set; }

        public ApplicationDbContext()
         : this(true)
        {
        }

        public ApplicationDbContext(bool lazyLoadingEnabled)
            : base("DefaultConnection")
        {
            base.Configuration.LazyLoadingEnabled = lazyLoadingEnabled;
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Add(new DecimalPrecisionAttributeConvention());

            base.OnModelCreating(modelBuilder);
        }

    }

}
