using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCoreDemo
{
    /// <summary>
    /// 数据库上下文
    /// </summary>
    public class MyCoreDbContext : DbContext
    {
        public MyCoreDbContext(DbContextOptions<MyCoreDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        /// <summary>
        /// 配置 
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=EFCodeAdvance;uid=sa;pwd=sql2012;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
