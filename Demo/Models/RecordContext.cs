using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Demo.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Demo.Models
{
    public class RecordContext:DbContext
    {
        public RecordContext() : base("RecordContext")
        {
        }
        public DbSet<Book1> Books { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}