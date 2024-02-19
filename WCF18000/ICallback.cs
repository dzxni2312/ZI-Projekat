using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace WCF18000
{
    
    public interface ICallback
    {
        [OperationContract(IsOneWay = true)]
        void Message(byte[] msg);
    }
}