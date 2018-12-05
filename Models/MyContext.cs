using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrimeiraAplicacao.Models
{
    public class MyContext : DbContext
    {
        public DbSet<Pessoa> Pessoa { get; set; }
    }
}