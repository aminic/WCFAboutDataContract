using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ShareLib
{
    [DataContract]
    [KnownType(typeof(Dictionary<string, float>))]
    public class Student
    {
        [DataMember]
        public string Name;
        [DataMember]
        public string Phone;
        [DataMember]
        public AddrInfo Address;
        //[DataMember]
        //public Dictionary<string, float> Scores;
        [DataMember]
        public object Scores2;
    }

    [DataContract]
    public class AddrInfo
    {
        [DataMember]
        public string Province;
        [DataMember]
        public string City;
        [DataMember]
        public string DetailAddr;
    }
}
