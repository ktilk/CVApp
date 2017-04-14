using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class CVAppDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactType> ContactTypes { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Characteristic> Characteristics { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<PersonCharacteristic> PersonCharacteristics { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CVAppDatabase;Trusted_Connection=True;");
        }
    }
}
