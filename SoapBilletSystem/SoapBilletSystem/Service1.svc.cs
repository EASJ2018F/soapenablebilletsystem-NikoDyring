using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BilletLib;

namespace SoapBilletSystem
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public string BilKøretøjTypeSOAP(Bil bil)
        {
            bil = new Bil("AA12345", 240);
            return bil.TypeAfKøretøj();
        }

        public string MCKøretøjTypeSOAP(MC mc)
        {
            mc = new MC("AA12345", 120);
            return mc.TypeAfKøretøj();
        }

        //public Bil OpretBilSOAP(string nummerplade, int pris)
        //{
        //    //Bil bil1 = new Bil(nummerplade, pris);
        //    //return bil1;
        //    return bil22;
        //}

        //public MC OpretMCSOAP(string nummerplade, int pris)
        //{
        //    //MC mc1 = new MC(nummerplade, pris);
        //    //return mc1;-
        //    return MC22;
        //}
    }
}
