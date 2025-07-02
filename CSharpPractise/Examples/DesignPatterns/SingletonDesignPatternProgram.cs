using System;

namespace CSharpConcepts.DesignPatterns.Singleton
{
    public class SingletonDesignPatternProgram
    {
        static void Main()
        {
            LoadBalancer lb1 = LoadBalancer.GetLoadBalancer();
            LoadBalancer lb2 = LoadBalancer.GetLoadBalancer();
            LoadBalancer lb3 = LoadBalancer.GetLoadBalancer();
            LoadBalancer lb4 = LoadBalancer.GetLoadBalancer();
            if (lb1 == lb2 && lb2 == lb3 && lb3 == lb4)
            {
                Console.WriteLine("Same instance\n");
            }

            LoadBalancer balancer = LoadBalancer.GetLoadBalancer();
            for (int i = 0; i < 15; i++)
            {
                string server = balancer.Server;
                Console.WriteLine("Dispatch Request to: " + server);
            }

            // Wait for user

            Console.ReadKey();
        }
    }
}
