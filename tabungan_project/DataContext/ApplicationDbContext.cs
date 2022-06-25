using tabungan_project.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace tabungan_project.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base(nameOrConnectionString : "Myconnection")
        {

        }

        public virtual DbSet<users> usersObject { get; set; }
        public virtual DbSet<status> statusObject { get; set; }
        public virtual DbSet<category> categoryObject{ get; set; }
        public virtual DbSet<item> itemObject{ get; set; }
        public virtual DbSet<tabungan> tabunganObject { get; set; }
        public virtual DbSet<detail_tabungan> detail_tabunganObject { get; set; }


        //public System.Data.Entity.DbSet<tabungan_project.Models.tabungan> tabungans { get; set; }

        //public System.Data.Entity.DbSet<tabungan_project.Models.detail_tabungan> detail_tabungan { get; set; }
    }
}