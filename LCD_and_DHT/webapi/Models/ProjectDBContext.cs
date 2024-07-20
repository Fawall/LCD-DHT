using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace webapi.Models
{
    public partial class ProjectDBContext : DbContext{
        public ProjectDBContext(DbContextOptions<ProjectDBContext> options) : base (options)
        {}

        public virtual DbSet<EnviromentModel> Enviroment { get ;set;}

       protected override void OnModelCreating(ModelBuilder modelBuilder)
       {
           modelBuilder.Entity<EnviromentModel>(entity => {
               entity.HasKey(k => k.EnviromentId);
           });
           OnModelCreatingPartial(modelBuilder);
       }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }



}