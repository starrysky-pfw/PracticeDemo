using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.ModelConfiguration;
using EntityFramework.Domain;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EntityFrameworDemo
{
    /// <summary>
    /// 数据库上下文
    /// </summary>
    public class MyDbContext : DbContext
    {
        public const string connection = "Server=192.168.0.13;Database=EFAdvance;uid=sa;pwd=sql2012;";
        //注意：以下写法不能生成数据库到指定的服务器上 只能生成到 MSSQLLocalDB 中【暂未查找到具体原因】
        //public MyDbContext()
        //{
        //    if (!Database.Exists(connection))
        //    {
        //        Database.SetInitializer(new CreateDataBase()); //创建数据库
        //    }
        //    else
        //    {
        //        Database.SetInitializer(new MigrateDbToLatestVersion()); //升级数据库
        //    }
        //}

        public MyDbContext() : base(connection)
        {
            if (!Database.Exists(connection))
            {
                Database.SetInitializer(new CreateDataBase()); //创建数据库
            }
            else
            {
                Database.SetInitializer(new MigrateDbToLatestVersion()); //升级数据库
            }
        }

        /// <summary>
        /// 数据库创建 模型配置
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();  //去除表名加s的复数配置
            modelBuilder.Configurations.Add(new StudentMap());  //添加模型
        }
    }

    /// <summary>
    /// map 映射类
    /// </summary>
    public class StudentMap : EntityTypeConfiguration<Student>
    {
        public StudentMap()
        {
            this.HasKey(s => s.Id);
            this.ToTable("Student");
            this.Property(s => s.Name).HasColumnName("Name").HasMaxLength(16);
            this.Property(s => s.Address).HasColumnName("Address").HasMaxLength(64);
            this.Property(s => s.Nation).HasColumnName("Nation").HasMaxLength(16);
        }
    }
}
