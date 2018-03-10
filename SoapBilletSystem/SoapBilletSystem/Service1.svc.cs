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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        // Library Objects.
        Bil bil1 = new Bil();
        BilØreSund bil2 = new BilØreSund();
        MC mc1 = new MC();
        MCØresund mc2 = new MCØresund();

        public string BilTypeSOAP()
        {
            return bil1.KøreTøjType();
        }

        public int BilPrisSOAP()
        {
            return bil1.Pris();
        }

        public string MCTypeSOAP()
        {
            return mc1.KøreTøjType();
        }

        public int MCPrisSOAP()
        {
            return mc1.Pris();
        }

        public int ØresundBilPrisSOAP()
        {
            return bil2.Pris();
        }

        public int ØresundMCPrisSOAP()
        {
            return mc2.Pris();
        }
    }
}
