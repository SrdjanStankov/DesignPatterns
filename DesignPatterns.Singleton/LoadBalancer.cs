using System;
using System.Collections.Generic;

namespace DesignPatterns.Singleton
{
    public class LoadBalancer
    {
        private static object syncLock = new object();
        private static LoadBalancer instance;

        private Random random = new Random();
        private List<string> servers = new List<string>()
        {
            "ServerI", "ServerII", "ServerIII", "ServerIV", "ServerV"
        };

        public static LoadBalancer GetLoadBalancer()
        {
            if (instance is null)
            {
                lock (syncLock)
                {
                    instance ??= new LoadBalancer();
                }
            }

            return instance;
        }

        public string Server => servers[random.Next(servers.Count)].ToString();
    }
}
