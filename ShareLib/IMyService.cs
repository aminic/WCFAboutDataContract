﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ShareLib
{
    [ServiceContract]
    public interface IMyService
    {
        [OperationContract]
        Student GetStudentInfo();
    }
}
