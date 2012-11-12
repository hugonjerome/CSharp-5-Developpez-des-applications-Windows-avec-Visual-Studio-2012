using System;

namespace RemotingLibrary
{
    public class Chat : MarshalByRefObject
    {
        public override object InitializeLifetimeService()
        {
            return null;
        }
        public bool TransfertMessage(string message)
        {
            Console.WriteLine(String.Format("Message reçu: {0}", message));
            return true;
        }
    }
}
