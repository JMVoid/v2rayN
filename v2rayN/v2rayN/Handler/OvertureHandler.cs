using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using v2rayN.Mode;

namespace v2rayN.Handler
{
    class OvertureHandler
    {
        //private static string SampleOverture = Global.overtureSampleConfig;
        /// <summary>
        ///  Generate the overture/x2ray dns configuration file
        /// </summary>

        public static int GenerateOvertureConfig(Config config, string fileName, out string msg)
        {
            msg = string.Empty;
            try
            {
                msg = UIRes.I18N("InitialConfiguration");
                string result = Utils.GetEmbedText(Global.overtureSampleConfig);
                if (Utils.IsNullOrEmpty(result))
                {
                    msg = UIRes.I18N("FailedGetDefaultConfiguration");
                    return -1;
                }
                OvertureConfig overtureConfig = Utils.FromJson<OvertureConfig>(result);
                if (overtureConfig == null)
                {
                    msg = UIRes.I18N("FailedGenDefaultConfiguration");
                    return -1;
                }
                primary(config, ref overtureConfig);
                alternative(config, ref overtureConfig);
                Utils.ToJsonFile(overtureConfig, fileName);
                msg = string.Format(UIRes.I18N("SuccessfulConfiguration"), config.getSummary());
            }
            catch {
                msg = UIRes.I18N("FailedGenDefaultConfiguration");
                return -1;
            }
            return 0;
        }

        public static int Export2ClientConfig(Config config, string fileName, out string msg) {
            msg = string.Empty;
            return GenerateOvertureConfig(config, fileName, out msg);
        }

        public static int primary(Config config, ref OvertureConfig overtureConfig)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(config.directDNS)) {
                    return 0;
                }
                List<string> servers = new List<string>();
                string[] arrDNS = config.directDNS.Split(',');
                foreach (string str in arrDNS)
                {
                    string ipStr = str.Trim();
                    if (Utils.IsIPort(ipStr)) {
                        servers.Add(ipStr);
                    }
                }
                if (overtureConfig.PrimaryDNS.Count >= 1 && servers.Count >= 1)
                {
                    int count = 0;
                    foreach (DnsSetting dnsSetting in overtureConfig.PrimaryDNS)
                    {
                        if (!Utils.IsNullOrEmpty(servers[count])) {
                            dnsSetting.Address = servers[count];
                        }
                        count++;
                    }
                }
            }
            catch {
            }
            return 0;
        }

        public static int alternative(Config config, ref OvertureConfig overtureConfig)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(config.proxyDNS))
                {
                    return 0;
                }
                List<string> servers = new List<string>();
                string[] arrDNS = config.proxyDNS.Split(',');
                foreach (string str in arrDNS)
                {
                    string ipStr = str.Trim();
                    if (Utils.IsIPort(ipStr))
                    {
                        servers.Add(ipStr);
                    }
                }
                if (overtureConfig.AlternativeDNS.Count >= 1 && servers.Count >=1 )
                {
                    int count = 0;
                    foreach (DnsSetting dnsSetting in overtureConfig.AlternativeDNS)
                    {
                        if (!Utils.IsNullOrEmpty(servers[count]))
                        {
                            dnsSetting.Address = servers[count];
                        }
                        dnsSetting.SOCKS5Address = "127.0.0.1:" + config.inbound[0].localPort;
                        count++;
                    }
                }
            }
            catch {
            }
            return 0;
        }
    }
}
