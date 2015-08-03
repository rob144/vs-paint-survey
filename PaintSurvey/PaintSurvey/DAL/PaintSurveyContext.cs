using PaintSurvey.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PaintSurvey.DAL
{
    public class PaintSurveyContext : DbContext
    {
        public PaintSurveyContext() : base("PaintSurveyContext") { }
        
        public DbSet<Project> Projects { get; set; }
        public DbSet<Paint> Paints { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<DefaultRoom> DefaultRooms { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}