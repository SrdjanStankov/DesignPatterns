using System;
using System.Collections.Generic;

namespace DesignPatterns.Singleton
{
    public class LoadBalancer
    {
        public static readonly LoadBalancer instance = new LoadBalancer();

        private Random random = new Random();
        private List<string> servers = new List<string>()
        {
            "ServerI", "ServerII", "ServerIII", "ServerIV", "ServerV"
        };

        public string Server => servers[random.Next(servers.Count)].ToString();
    }
}
