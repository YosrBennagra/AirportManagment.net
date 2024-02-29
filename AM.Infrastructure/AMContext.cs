using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
/*
 *1 AMContext : DbContext
 *2 Install ORM
 *3 Declarer les entité => tables
 * DbSet<Entity> Entites
 * Entites.add(E1)
 *4 chaine de connection
 *5 Add-migration {nom}
 * ken build failed ta3mel rebuild solution
 */
    public class AMContext : DbContext
    {
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Traveller> Travellers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb; Initial Catalog=AirportManagementDB;Integrated Security=true;"); 
            base.OnConfiguring(optionsBuilder);
        }

    }
}
