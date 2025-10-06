using Microsoft.EntityFrameworkCore;
using studentManagmentPlatform.Core;
using studentManagmentPlatform.Core.Entities;
using System.IO;
using System.Security.Principal;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace studentManagmentPlatform.DB.Data;

public class AppDbContext : DbContext
{
    public DbSet<Classroom> Customers => Set<Classroom>();
    public DbSet<Student> Accounts => Set<Student>();
    public DbSet<StudentMarksDetails> Transactions => Set<StudentMarksDetails>();
    public DbSet<Teacher> CustomerProfiles => Set<Teacher>();


    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);


        // Student -> Teacher many-to-many
        modelBuilder.Entity<Student>()
            .HasMany(s => s.Teachers)
            .WithMany(t => t.Students);

        // Classroom -> Students one-to-many
        modelBuilder.Entity<Classroom>()
        .HasMany(c => c.Students)
        .WithOne(s => s.Classroom)
        .HasForeignKey(s => s.ClassroomId);

        // Classroom -> Teachers many-to-many
        modelBuilder.Entity<Classroom>()
       .HasMany(c => c.Teachers)
       .WithMany(t => t.Classrooms);



    }
}
