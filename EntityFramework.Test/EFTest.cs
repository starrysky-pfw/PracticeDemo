using EntityFrameworDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EntityFramework.Domain;

namespace EntityFramework.Test
{
    public class EFTest
    {
        public static DbContext context = null;
        public EFTest()
        {
            if (context == null)
            {
                context = new MyDbContext();
            }
        }

        /// <summary>
        /// 初始化创建学生信息 生成或更新数据库
        /// </summary>
        public void InitStudentMsg()
        {
            int studentCount = context.Set<Student>().Count();
            if (studentCount == 0)
            {
                context.Set<Student>().Add(new Student
                {
                    Name = "starrysky",
                    Age = 20,
                    Address = "成都市",
                    Nation = "汉族"
                });
                context.SaveChanges();
            }
        }
    }
}
