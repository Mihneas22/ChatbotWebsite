using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Chatbot.AddChatbot
{
    public record AddChatbotResponse(bool Flag, string message = null!);
}
