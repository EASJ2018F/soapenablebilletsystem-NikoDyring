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

        public string BilTypeSOAP(Bil bil)
        {
            return bil.KøreTøjType();
        }

        public int BilPrisSOAP(Bil bil)
        {
            return bil.Pris();
        }

        public string MCTypeSOAP(MC mc)
        {
            return mc.KøreTøjType();
        }

        public int MCPrisSOAP(MC mc)
        {
            return mc.Pris();
        }

        public int ØresundBilPrisSOAP(BilØreSund bil)
        {
            return bil.Pris();
        }

        public int ØresundMCPrisSOAP(MCØresund mc)
        {
            return mc.Pris();
        }

        public Bil CreateBilSOAP(string nummerplade)
        {
            Bil bil = new Bil();
            bil.NummerPlade = nummerplade;

            return bil;
        }

        public BilØreSund CreateBilOSOAP(string nummerplade)
        {
            BilØreSund bilO = new BilØreSund();
            bilO.NummerPlade = nummerplade;

            return bilO;
        }

        public MC CreateMCSOAP(string nummerplade)
        {
            MC mc = new MC();
            mc.NummerPlade = nummerplade;

            return mc;
        }

        public MCØresund CreateMCOSOAP(string nummerplade)
        {
            MCØresund mco = new MCØresund();
            mco.NummerPlade = nummerplade;

            return mco;
        }
    }
}
