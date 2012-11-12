using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using RemotingLibrary;

namespace RemotingServer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TcpChannel channel = new TcpChannel(10001);
                ChannelServices.RegisterChannel(channel, false);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(Chat), "Chat",  WellKnownObjectMode.Singleton);

                Console.WriteLine("Le serveur a démarré avec succès et écoute le port 10001.");
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Erreur lors du démarrage du serveur.");
                Console.ReadLine();
            }
        }
    }
}
