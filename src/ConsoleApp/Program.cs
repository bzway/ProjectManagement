using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Project p = new Project();
            p.启动();
            p.规划();
            p.执行();
            p.监控();
            p.收尾();
        }
    }
}