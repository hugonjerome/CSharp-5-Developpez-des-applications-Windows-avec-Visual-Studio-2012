using System;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using RemotingLibrary;

namespace RemotingClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TcpChannel channel = new TcpChannel();
                ChannelServices.RegisterChannel(channel, false);
                Chat chat = (Chat)Activator.GetObject(typeof(Chat), "tcp://localhost:10001/Chat");

                Console.WriteLine("Connexion au serveur réussie. Saisissez votre message: [Enter = Exit]");
                bool exit = false;
                while (!exit)
                {
                    string message = Console.ReadLine();
                    if (message != string.Empty)
                    {
                        try
                        {
                            if (chat != null)
                            {
                                bool result = chat.TransfertMessage(message);
                                if (result)
                                {
                                    Console.WriteLine("Le message à été transmis au serveur");
                                }
                                else
                                {
                                    throw new Exception();
                                }
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Erreur de communication avec le serveur");
                        }
                    }
                    else
                    {
                        exit = true;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Erreur de connexion au serveur");
            }
        }
    }
}
