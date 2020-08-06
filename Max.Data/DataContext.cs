using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Max.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

public class DataContext : IdentityDbContext
{
        public DataContext (DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }

        public DbSet<Dashboard> Dashboard { get; set; }
    }
