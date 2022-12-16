using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

// Client app is the one sending messages to a Server/listener.
// Both listener and client can send messages back and forth once a
// communication is established.
namespace HCI_Chatbot_Client
{
    public class Program
    {
        public static void Main()
        {
            ChatbotClient chatbotClient = new ChatbotClient();
            chatbotClient.StartClient();
        }
    }
}