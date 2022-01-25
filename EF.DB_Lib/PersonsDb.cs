using System.IO;
using EF.Model;
using Microsoft.EntityFrameworkCore;

namespace EF.DB_Lib
{
    public sealed class PersonsDb : DbContext
    {
        public DbSet<Person> TablePersons { get; set; }

        public PersonsDb()
        {
            Database.EnsureCreated();
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(GetConnectionString("connection_to_db.txt"));
        }

        private static string GetConnectionString(string path)
        {
            return File.ReadAllText(path);
        }
    }
}