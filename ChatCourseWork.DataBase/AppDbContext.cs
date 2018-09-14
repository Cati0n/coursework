using System.Data.Entity;
using ChatCourseWork.DataBase.Entities;

namespace ChatCourseWork.DataBase
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
            : base("name=DbEntities")
        {
        }

        public virtual DbSet<User> Users { get; set; }

        protected void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}