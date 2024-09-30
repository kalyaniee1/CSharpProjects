using EntityFRamework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFRamework.Data
{
    internal class AppDbContext:DbContext
    {
        public string _connectionString;
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<EmpoyeeDetails> EmpoyeeDetails { get; set; }
        public AppDbContext() {
            _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EFCore;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
