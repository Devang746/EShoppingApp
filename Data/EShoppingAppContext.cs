using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EShoppingApp.Models;

namespace EShoppingApp.Data
{
    public class EShoppingAppContext : DbContext
    {
        public EShoppingAppContext (DbContextOptions<EShoppingAppContext> options)
            : base(options)
        {
        }

        public DbSet<EShoppingApp.Models.Userdetails> Userdetails { get; set; }
    }
}
