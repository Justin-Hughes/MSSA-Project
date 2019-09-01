using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.ComponentModel.DataAnnotations;

namespace MSSA.Model
{
    public class GDatabaseContext : DbContext
    {
        public DbSet<Tank> Tank { get; set; }
        public DbSet<Weapon> Weapon { get; set; }
        public DbSet<Statistics> Statistics { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;Database=Spanks");
        }
    }

    public class Tank
    {
        [Key]
        public string Username { get; set; }
        public int Health { get; set; }
        public string WeaponName { get; set; }
    }
    public class Weapon
    {
        [Key]
        public string WeaponName { get; set; }
        public string TrajectoryType { get; set; }
        public int Damage { get; set; }
    }

    public class Statistics
    {
        [Key]
        public string Username { get; set; }
        public uint Wins { get; set; }
        public uint Losses { get; set; }
        public uint Draws { get; set; }
        public uint TotalShotsFired { get; set; }
        public uint TotalDistanceTraveled { get; set; }
        public uint TotalDamageDealt { get; set; }
        public double Accuracy { get; set; }
    }
}
