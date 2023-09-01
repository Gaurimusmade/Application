using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Application.Models;

namespace Application.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext (DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<Application.Models.Addinfo> Addinfo { get; set; } = default!;

        public DbSet<Application.Models.Assesment> Assesment { get; set; } = default!;

        public DbSet<Application.Models.Company> Company { get; set; } = default!;

        public DbSet<Application.Models.Declaration> Declaration { get; set; } = default!;

        public DbSet<Application.Models.Education> Education { get; set; } = default!;

        public DbSet<Application.Models.Passport> Passport { get; set; } = default!;

        public DbSet<Application.Models.Private> Private { get; set; } = default!;
    }
}
