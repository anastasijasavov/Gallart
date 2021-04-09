using Gallart.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gallart.ViewModels.Users;

namespace Gallart.DataAccess
{
    public class MyDbContext :DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<List> Lists { get; set; }
        public DbSet<Painting> Paintings { get; set; }

        public DbSet<ListToPainting> ListToPaintings { get; set; }
        public MyDbContext()
        {
            Users = this.Set<User>();
            Lists = this.Set<List>();
            Paintings = this.Set<Painting>();
            ListToPaintings = this.Set<ListToPainting>();
        }
        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lists>()
                .HasMany<Painting>(s => s.PaintingList)
                .WithMany(c => c.ListsList)
                .(cs =>
                {
                    cs.MapLeftKey("ListId");
                    cs.MapRightKey("PaintingId");
                    cs.ToTable("ListsPaintings");
                });
        }*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=UsersDb;User Id=savov;Password=korpazaotpatke;");
        }
       
    }
}
