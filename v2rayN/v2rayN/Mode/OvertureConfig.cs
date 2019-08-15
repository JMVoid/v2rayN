using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v2rayN.Mode
{
   public class OvertureConfig
    {
        public string BindAddress  {get; set;}
        public string DebugHTTPAddress  {get;set;}
        public List<DnsSetting> PrimaryDNS { get; set; }
        public List<DnsSetting> AlternativeDNS { get; set; }
        public bool OnlyPrimaryDNS { get; set; }
        public bool IPv6UseAlternativeDNS { get; set; }
        public string WhenPrimaryDNSAnswerNoneUse { get; set; }
        public IPNetworkFile IPNetworkFile { get; set; }
        public DomainFile DomainFile { get; set; }
        public string HostsFile { get; set; }
        public int MinimumTTL { get; set; }
        public string DomainTTLFile { get; set; }
        public int CacheSize { get; set; }
        public List<int> RejectQType { get; set; }
    }

    public class DnsSetting
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Protocol { get; set; }
        public string SOCKS5Address { get; set; }
        public int Timeout { get; set; }
        public EDNSClient EDNSClientSubnet { get; set; }
    }

    public class EDNSClient
    {
        public string Policy { get; set; }

        public string ExternalIP { get; set; }

        public bool NoCookie { get; set; }
    }

    public class IPNetworkFile
    {
        public string Primary { get; set; }
        public string Alternative { get; set; }
    }

    public class DomainFile
    {
            public string Primary { get; set; }
            public string Alternative { get; set; }
            public string Matcher { get; set; }
    }
 
}
