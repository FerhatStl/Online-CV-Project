using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Context:DbContext
    {
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Language> Languages { get; set; }
    }
}