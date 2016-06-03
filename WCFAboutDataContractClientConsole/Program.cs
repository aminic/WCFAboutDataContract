using ShareLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFAboutDataContractClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseAddress = "http://localhost:999/";
            var c = new WSClient(baseAddress);
            var s = c.GetService<IMyService>();
            var student = s.GetStudentInfo();
            Console.Read();


        }
    }
}
