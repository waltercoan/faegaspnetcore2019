using System;
using empresaapp.Models;
using Microsoft.EntityFrameworkCore;

namespace empresaapp.Db
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Client>().HasData(new Client 
            { Id = 1, 
              Name = "Zezinho", 
              Address = "Rua allalal", 
              Birthday = DateTime.Now});
        }
        public virtual DbSet<Client> Clients { get; set; }
    }
}