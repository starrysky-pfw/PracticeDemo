using EntityFrameworDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EntityFramework.Domain;
using System.Threading;


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

            var tmp = new Student
            {
                Name = "张三",
                Address = "成都市",
                ContactPhone = 13212124514,
                Nation = "汉族",
                Age = 24
            };
            context.Set<Student>().Attach(tmp);
            var entryStudent = context.Entry(tmp);

            var state = entryStudent.State;

            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

            context.SaveChangesAsync(cancellationTokenSource.Token);
            CancellationTokenSource source = CancellationTokenSource.CreateLinkedTokenSource(cancellationTokenSource.Token);


            //cancellationTokenSource

            var tmpstu = context.Set<Student>().Where(s => s.Name == "张三").FirstOrDefault();
            context.SaveChanges();

        }
    }
}
