using Application.DTOs.Chatbot.AddChatbot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository
{
    public interface IChatbot
    {
        Task<AddChatbotResponse> AddChatbotAsync(AddChatbotDTO addChatbotDTO);
    }
}
