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
        int BilPrisSOAP(Bil bil);
        [OperationContract]
        int ØresundBilPrisSOAP(BilØreSund bil);
        [OperationContract]
        int MCPrisSOAP(MC mc);
        [OperationContract]
        int ØresundMCPrisSOAP(MCØresund mc);
        [OperationContract]
        string BilTypeSOAP(Bil bil);
        [OperationContract]
        string MCTypeSOAP(MC mc);
        [OperationContract]
        Bil CreateBilSOAP(string nummerplade);
        [OperationContract]
        BilØreSund CreateBilOSOAP(string nummerplade);
        [OperationContract]
        MC CreateMCSOAP(string nummerplade);
        [OperationContract]
        MCØresund CreateMCOSOAP(string nummerplade);
    }

}
