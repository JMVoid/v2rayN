﻿using System.Collections.Generic;

namespace v2rayN.Mode
{
    /// <summary>
    /// v2ray配置文件实体类
    /// 例子SampleConfig.txt
    /// </summary>
    public class V2rayConfig
    {
        /// <summary>
        /// 日志配置
        /// </summary>
        public Log log { get; set; }
        /// <summary>
        /// 传入连接配置
        /// </summary>
        public List<Inbounds> inbounds { get; set; }
        /// <summary>
        /// 传出连接配置
        /// </summary>
        public List<Outbounds> outbounds { get; set; }

        /// <summary>
        /// DNS 配置
        /// </summary>
        public Dns dns { get; set; }
        /// <summary>
        /// 路由配置
        /// </summary>
        public Routing routing { get; set; }
    }

    public class Log
    {
        /// <summary>
        /// 
        /// </summary>
        public string access { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string error { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string loglevel { get; set; }
    }

    public class Inbounds
    {
        /// <summary>
        /// 
        /// </summary>
        public int port { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string listen { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string protocol { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Sniffing sniffing { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Inboundsettings settings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public StreamSettings streamSettings { get; set; }

    }

    public class Inboundsettings
    {
        /// <summary>
        /// 
        /// </summary>
        public string auth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool udp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<UsersItem> clients { get; set; }
    }

    public class UsersItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int alterId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string security { get; set; }
    }
    public class Sniffing
    {
        /// <summary>
        /// 
        /// </summary>
        public bool enabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> destOverride { get; set; }
    }

    public class Outbounds
    {
        /// <summary>
        /// 默认值agentout
        /// </summary>
        public string tag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string protocol { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Outboundsettings settings { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public StreamSettings streamSettings { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mux mux { get; set; }
    }

    public class Outboundsettings
    {
        /// <summary>
        /// 
        /// </summary>
        public List<VnextItem> vnext { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ServersItem> servers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Response response { get; set; }
    }

    public class VnextItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int port { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<UsersItem> users { get; set; }
    }
    public class ServersItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string method { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool ota { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string password { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int port { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int level { get; set; }
    }

    public class Mux
    {
        /// <summary>
        /// 
        /// </summary>
        public bool enabled { get; set; }
    }

    public class Response
    {
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
    }

    public class dnsServer
    {
            public string address { get; set; }
            
            public int port { get; set; }
    }
    public class Dns
    {
        /// <summary>
        /// 
        /// </summary>
        //public List<string> servers { get; set; }
        public List<dnsServer> servers { get; set; }
    }

    public class RulesItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string port { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string outboundTag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<string> ip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<string> domain { get; set; }
    }

    public class Routing
    {
        /// <summary>
        /// 
        /// </summary>
        public string domainStrategy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<RulesItem> rules { get; set; }
    }

    public class StreamSettings
    {
        /// <summary>
        /// 
        /// </summary>
        public string network { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string security { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public TlsSettings tlsSettings { get; set; }

        /// <summary>
        /// Tcp传输额外设置
        /// </summary>
        public TcpSettings tcpSettings { get; set; }
        /// <summary>
        /// Kcp传输额外设置
        /// </summary>
        public KcpSettings kcpSettings { get; set; }
        /// <summary>
        /// ws传输额外设置
        /// </summary>
        public WsSettings wsSettings { get; set; }
        /// <summary>
        /// h2传输额外设置
        /// </summary>
        public HttpSettings httpSettings { get; set; }

        /// <summary>
        /// QUIC
        /// </summary>
        public QuicSettings quicSettings { get; set; }
        
    }

    public class TlsSettings
    {
        /// <summary>
        /// 是否允许不安全连接（用于客户端）
        /// </summary>
        public bool allowInsecure { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string serverName { get; set; }
    }

    public class TcpSettings
    {
        /// <summary>
        /// 是否重用 TCP 连接
        /// </summary>
        public bool connectionReuse { get; set; }
        /// <summary>
        /// 数据包头部伪装设置
        /// </summary>
        public Header header { get; set; }
    }

    public class Header
    {
        /// <summary>
        /// 伪装
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 结构复杂，直接存起来
        /// </summary>
        public object request { get; set; }
        /// <summary>
        /// 结构复杂，直接存起来
        /// </summary>
        public object response { get; set; }
    }

    public class KcpSettings
    {
        /// <summary>
        /// 
        /// </summary>
        public int mtu { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int tti { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int uplinkCapacity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int downlinkCapacity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool congestion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int readBufferSize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int writeBufferSize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Header header { get; set; }
    }

    public class WsSettings
    {
        /// <summary>
        /// 
        /// </summary>
        public bool connectionReuse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Headers headers { get; set; }
    }
    public class Headers
    {
        /// <summary>
        /// 
        /// </summary>
        public string Host { get; set; }
    }

    public class HttpSettings
    {
        /// <summary>
        /// 
        /// </summary>
        public string path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<string> host { get; set; }

    }

    public class QuicSettings
    {
        /// <summary>
        /// 
        /// </summary>
        public string security { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Header header { get; set; }
    }

}
