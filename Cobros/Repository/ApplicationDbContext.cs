using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.IO;
using Cobros.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Cobros.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        //public DbSet<Cliente> Clientes { get; set; }



    }
}
