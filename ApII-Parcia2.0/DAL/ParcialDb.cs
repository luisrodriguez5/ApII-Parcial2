using ApII_Parcia2._0.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApII_Parcia2._0.DAL
{
    public class ParcialDb : DbContext
    {
        public ParcialDb() : base("ConStr") { }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Prestamos> Prestamos { get; set; }
        public DbSet<Cuentas> Cuentas { get; set; }

    }





}