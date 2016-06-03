using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib;

namespace WCFAboutDataContractServerConsole
{
    public class MyService : IMyService
    {
        public Student GetStudentInfo()
        {
            AddrInfo info = new AddrInfo { Province = "荷兰省", City = "鹿特丹", DetailAddr = "摩诃路233号" };
            var scores = new Dictionary<string, float> {
                { "语文", 97f },
                { "英语", 64.5f },
                { "数学", 38f },
                { "历史", 77.6f },
                { "地理", 82.3f },
            };
            Student s = new Student { Name = "唐江流", Phone = "12344445555", Address = info, /*Scores = scores,*/ Scores2 = scores };



            return s;
        }
    }
}
