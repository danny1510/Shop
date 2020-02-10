
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Web.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    //la clase DataContext hereda de una clase llamada DbContext, para usar entity framework
    using Microsoft.EntityFrameworkCore;
    using Shop.Web.Data.Entities;
  
    public class DataContext : IdentityDbContext<User>
    {
        // Modelo que se va a tirar a la base de datos
        public DbSet <Product> Products { get; set; }
        public DbSet<Country> Countries { get; set; }

        //conectarse a la base de datos
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

    }


}
