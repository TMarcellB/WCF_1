using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF_1_server.Models
{
    [DataContract]
    public class Zeneszam
    {
        [DataMember]
        public int ZeneszamAz { get; set; }
        [DataMember]
        public string ZeneszamHossz { get; set; }
        [DataMember]
        public string ZeneszamCim { get; set; }
    }
}