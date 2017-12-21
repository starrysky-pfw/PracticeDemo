using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworDemo
{
    /// <summary>
    /// 创建数据库 
    /// </summary>
    public class CreateDataBase : CreateDatabaseIfNotExists<MyDbContext>
    {
        public override void InitializeDatabase(MyDbContext context)
        {
            base.InitializeDatabase(context);
        }

        protected override void Seed(MyDbContext context)
        {
            base.Seed(context);
        }
    }

    /// <summary>
    /// 升级数据库
    /// </summary>
    public class MigrateDbToLatestVersion : MigrateDatabaseToLatestVersion<MyDbContext, DbMigrationsCfg>
    {
        public override void InitializeDatabase(MyDbContext context)
        {
            base.InitializeDatabase(context);
        }
    }

    /// <summary>
    /// 升级配置
    /// </summary>
    public class DbMigrationsCfg : DbMigrationsConfiguration<MyDbContext>
    {
        public DbMigrationsCfg()
        {
            AutomaticMigrationDataLossAllowed = false;
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MyDbContext context)
        {
            base.Seed(context);
        }
    }

}
