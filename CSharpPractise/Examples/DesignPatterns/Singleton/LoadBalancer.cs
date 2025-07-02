using System;
using System.Collections.Generic;

namespace CSharpConcepts.DesignPatterns.Singleton
{
    public class LoadBalancer
    {
        private static LoadBalancer _instance;
        List<string> server = new List<string>();
        private Random random = new Random();
        private static object synLock = new object();
        private LoadBalancer()
        {
            server.Add("Server I");
            server.Add("Server II");
            server.Add("Server III");
            server.Add("Server IV");
            server.Add("Server V");
            server.Add("Server VI");
            server.Add("Server VI");
            server.Add("Server VII");
            server.Add("Server IX");
        }

        public static LoadBalancer GetLoadBalancer()
        {
            if (_instance == null)
            {
                lock (synLock)
                {
                    if (_instance == null)
                    {
                        _instance = new LoadBalancer();
                    }
                }
            }
            return _instance;
        }
        public string Server
        {
            get
            {
                int r = random.Next(server.Count);
                return server[r].ToString();
            }
        }
    }
}
