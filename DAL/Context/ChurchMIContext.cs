using Microsoft.EntityFrameworkCore;

namespace ChurchMI.DAL.Context
{
    public partial class ChurchMIContext : DbContext
    {
        public ChurchMIContext() { }

        public ChurchMIContext(DbContextOptions<ChurchMIContext> options) : base(options) { }

        public virtual DbSet<Title> Titles { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<MaritalStatus> MaritalStatuses { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Announcement> Announcements { get; set; }


        IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("appsettings.json").Build();

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer
    }
}
