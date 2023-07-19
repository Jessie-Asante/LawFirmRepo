using LawFirm.Application.BaseDtos.CommandDtos;
using LawFirm.Application.BaseDtos.QueryDtos;
using LawFirm.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace LawFirm.Infrastructure.Data
{
    public partial class DbLawFirmContext:DbContext
    {
        public DbLawFirmContext(DbContextOptions<DbLawFirmContext> options):base(options)
        {
                
        }

        //Tables
        public virtual DbSet<TblHomeTag> TblHomeTags { get; set; }
        public virtual DbSet<TblAboutTag> TblAboutTags { get; set; }
        public virtual DbSet<TblServiceTag> TblServiceTags { get; set; }
        public virtual DbSet<TblBookingTag> TblBookingTags { get; set; }
        public virtual DbSet<TblReasonsTag> TblReasonsTags { get; set; }
        public virtual DbSet<TblUserBooking> TblUserBookings { get; set; }

        //CommandDTOs
        public virtual DbSet<CommandHomesDto> CommandHomesDtos { get; set; }
        public virtual DbSet<CommandReasonsDto> CommandReasonsDtos { get; set; }
        public virtual DbSet<CommandAboutDto> CommandAboutDtos { get; set; }
        public virtual DbSet<CommandServicesDto> CommandServicesDtos { get; set; }
        public virtual DbSet<CommandBookingDto> CommandBookingDtos { get; set; }
        public virtual DbSet<CommandUserBookingDto> CommandUserBookingDtos { get; set; }


        //QueryDTOs
        public virtual DbSet<UserBookingDto> UserBookingDtos { get; set; }
        public virtual DbSet<ServicesDto> ServicesDtos { get; set; }
        public virtual DbSet<ReasonsDto> ReasonsDtos { get; set; }
        public virtual DbSet<HomeDto> HomeDtos { get; set; }
        public virtual DbSet<BookingDto> BookingDtos { get; set; }
        public virtual DbSet<AboutDto> AboutDtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //CommandDTOs
            modelBuilder.Entity<CommandHomesDto>(entity =>{ entity.HasNoKey(); });
            modelBuilder.Entity<CommandReasonsDto>(entity =>{ entity.HasNoKey(); });
            modelBuilder.Entity<CommandAboutDto>(entity =>{ entity.HasNoKey(); });
            modelBuilder.Entity<CommandServicesDto>(entity =>{ entity.HasNoKey(); });
            modelBuilder.Entity<CommandBookingDto>(entity =>{ entity.HasNoKey(); });
            modelBuilder.Entity<CommandUserBookingDto>(entity =>{ entity.HasNoKey(); });


            //QueryDTOs
            modelBuilder.Entity<UserBookingDto>(entity =>{ entity.HasNoKey(); });
            modelBuilder.Entity<ServicesDto>(entity =>{ entity.HasNoKey(); });
            modelBuilder.Entity<ReasonsDto>(entity =>{ entity.HasNoKey(); });
            modelBuilder.Entity<HomeDto>(entity =>{ entity.HasNoKey(); });
            modelBuilder.Entity<BookingDto>(entity =>{ entity.HasNoKey(); });
            modelBuilder.Entity<AboutDto>(entity =>{ entity.HasNoKey(); });
            
            
            
            //Tables
            modelBuilder.Entity<TblHomeTag>(entity => 
            {
                entity.HasKey(e => e.HmtId);
            });
            
            modelBuilder.Entity<TblAboutTag>(entity => 
            {
                entity.HasKey(e => e.AbtIdpk);
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