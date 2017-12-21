using EntityFrameworDemo;
using EntityFramework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //EntityFramework Test
            EFTest eftest = new EFTest();
            eftest.InitStudentMsg();
        }
    }
}
