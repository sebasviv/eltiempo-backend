
using System;
using Microsoft.EntityFrameworkCore;
using pruebasvmvc.Models;

namespace pruebasvmvc.Data
{
    public class dbContext:DbContext
    {
        public dbContext(DbContextOptions<dbContext> options) : base(options)
         {

         }
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<Ciudad> Ciudad { get; set; }
    }
}
