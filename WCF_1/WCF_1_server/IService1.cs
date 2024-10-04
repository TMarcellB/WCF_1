using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCF_1_server.Models;
using WCF_1_server.Controllers;

namespace WCF_1_server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        List<Eloado> GetEloado();
        [OperationContract]
        Eloado GetEloadoName();
        [OperationContract]
        string UjEloado(Eloado ujEloado);
        [OperationContract]
        Zeneszam GetZeneszam();
        [OperationContract]
        Cd GetCd();
        [OperationContract]
        String ModositEloado(Eloado eloado);
        [OperationContract]
        String TorolEloado(int azon);


    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    
    
}
    
