using Gehaltsbuero.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gehaltsbuero.Repository.Sql
{
    public class GehaltsbueroContext : DbContext
    {
        public DbSet<Vertreter> Vertreter { get; set; }

        public GehaltsbueroContext(DbContextOptions<GehaltsbueroContext> options) : base(options){ }


    }
}
