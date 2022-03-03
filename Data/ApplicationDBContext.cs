#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BaiThucHanh1402.Models;

    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext (DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<BaiThucHanh1402.Models.Student> Student { get; set; }

        public DbSet<BaiThucHanh1402.Models.Person> Person { get; set; }

        public DbSet<BaiThucHanh1402.Models.Employee> Employee { get; set; }
    }
