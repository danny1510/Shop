
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Web.Data
{
    using Microsoft.EntityFrameworkCore;
    using Shop.Web.Data.Entities;
    //la clase DataContext hereda de una clase llamada DbContext, parausar entity framework
    public class DataContext : DbContext
    {
        // Modelo que se va a tirar a la base de datos
        public DbSet <Product> Products { get; set; }

        //conectarse a la base de datos
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

    }


}
