using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCF_1_server.Controllers;
using WCF_1_server.Models;

namespace WCF_1_server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public List<Eloado> GetEloado()
        {
            List<Eloado> list = new EloadoController().EloadokLista();
           
            return list;
        }
        public string GetEloadoName()
        {
            Eloado eloado1 = new Eloado()
            {
                EloadoAz = 1,
                EloadoName = "Queen"
            };
            return eloado1.EloadoName;
        }
        public Cd GetCd()
        {
            Cd cd = new Cd()
            {
                CdAz = 1,
                CdCim = "ASDASD",
                Kiado = "az"
            };
            return cd;
        }
       

        Eloado IService1.GetEloadoName()
        {
            throw new NotImplementedException();
        }

        public Zeneszam GetZeneszam()
        {
            Zeneszam zeneszam = new Zeneszam()
            {
                ZeneszamAz = 1,
                ZeneszamCim = "Who wants to live forever",
                ZeneszamHossz = "3:15"
            };
            return zeneszam;
        }

        public string UjEloado(Eloado ujEloado)
        {
            
            



            return new EloadoController().InsertEloado(ujEloado);
        }

        public string ModositEloado(Eloado eloado)
        { 
            return new EloadoController().UpdateEloado(eloado) ;
        }

        public string TorolEloado(int azon)
        {
            return new EloadoController().DeleteEloado(azon);
        }
    }
}
