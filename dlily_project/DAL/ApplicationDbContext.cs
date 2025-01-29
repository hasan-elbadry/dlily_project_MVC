
using dlily_project.DAL.Models.Offers;
using dlily_project.DAL.Models.Reviews;
using dlily_project.DAL.Models.Users;

namespace dlily_project.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReviewCompany>().HasKey(x => new {x.CompanyId,x.TouristId });
            modelBuilder.Entity<ReviewHotel>().HasKey(x => new { x.HotelId, x.TouristId });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ReviewCompany> ReviewCompanies { get; set; }
        public DbSet<ReviewHotel> ReviewHotels { get; set; }
        public DbSet<Tourist> Tourists { get; set; }
        public DbSet<Tourgide> Tourgides { get; set; }
        public DbSet<TouristPlaces> TouristPlaces { get; set; }
        public DbSet<HotelOffer> HotelOffers { get; set; }
        public DbSet<CompanyOffer> CompanyOffers { get; set; }
    }
}
