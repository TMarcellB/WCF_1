using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF_1_server.Models
{
    [DataContract]
    public class Cd
    {
        [DataMember]
        public int CdAz { get; set; }
        [DataMember]
        public string CdCim { get; set; }
        [DataMember]
        public string Kiado { get; set; }
    }
}