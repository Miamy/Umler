using Miamy.Umler.Services.Interfaces;

namespace Miamy.Umler.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from the Message Service";
        }
    }
}
