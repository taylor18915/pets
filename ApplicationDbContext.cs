using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pet_World.Data;

namespace Pet_World.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Pet_World.Data.Dogs> Dogs { get; set; }
        public DbSet<Pet_World.Data.PetStores> PetStores { get; set; }
    }
}
