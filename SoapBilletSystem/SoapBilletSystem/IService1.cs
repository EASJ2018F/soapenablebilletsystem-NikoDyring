using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BilletLibrary;

namespace SoapBilletSystem
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int BilPrisSOAP();
        [OperationContract]
        int ØresundBilPrisSOAP();
        [OperationContract]
        int MCPrisSOAP();
        [OperationContract]
        int ØresundMCPrisSOAP();
        [OperationContract]
        string BilTypeSOAP();
        [OperationContract]
        string MCTypeSOAP();

    }

}
