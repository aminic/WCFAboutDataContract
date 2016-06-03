using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFAboutDataContractServerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseAddress = "http://locahost:999/";
            var host = new RealServerHost(baseAddress);
            host.Start();
            Console.WriteLine("已启动");
            Console.Read();
        }
    }
}
