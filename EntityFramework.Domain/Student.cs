using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Domain
{
    /// <summary>
    /// 学生信息
    /// </summary>
    public class Student
    {
        public int Id { get; set; }
        /// <summary>
        /// 学生名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public int ContactPhone { get; set; }
        /// <summary>
        /// 名族
        /// </summary>
        public string Nation { get; set; }
    }
}
