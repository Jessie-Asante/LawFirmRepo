using LawFirm.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace LawFirm.Infrastructure.Data
{
    public partial class DbLawFirmContext:DbContext
    {
        public DbLawFirmContext(DbContextOptions<DbLawFirmContext> options):base(options)
        {
                
        }

        public virtual DbSet<TblHomeTag> TblHomeTags { get; set; }
        public virtual DbSet<TblAboutTag> TblAboutTags { get; set; }
        public virtual DbSet<TblServiceTag> TblServiceTags { get; set; }
        public virtual DbSet<TblBookingTag> TblBookingTags { get; set; }
        public virtual DbSet<TblReasonsTag> TblReasonsTags { get; set; }
        public virtual DbSet<TblUserBooking> TblUserBookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblHomeTag>(entity => 
            {
                entity.HasKey(e => e.HmtId);
            });
            
            modelBuilder.Entity<TblAboutTag>(entity => 
            {
                entity.HasKey(e => e.AbtId);
            }); 
            
            modelBuilder.Entity<TblServiceTag>(entity => 
            {
                entity.HasKey(e => e.SvtId);
            }); 
            
            modelBuilder.Entity<TblBookingTag>(entity => 
            {
                entity.HasKey(e => e.BktId);
            }); 
            
            modelBuilder.Entity<TblReasonsTag>(entity => 
            {
                entity.HasKey(e => e.RstId);
            }); 
            
            modelBuilder.Entity<TblUserBooking>(entity => 
            {
                entity.HasKey(e => e.UsbId);
            });
        }
    }
}