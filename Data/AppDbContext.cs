using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApi.Model;

namespace TestApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<custommer> tb_custommer { get; set; }
        public virtual DbSet<custommer_address> tb_custommer_addresses { get; set; }
        public virtual DbSet<detail_payment> tb_detail_payment { get; set; }
        public virtual DbSet<detail_product> tb_detail_product { get; set; }
        public virtual DbSet<payment_method> tb_payment_method { get; set; }
        public virtual DbSet<product> tb_product { get; set; }
        public virtual DbSet<transaksi> tb_transaksi { get; set; }
    }
}
