using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Chatbot.AddChatbot
{
    public class AddChatbotDTO
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public Guid SubscriptionId { get; set; } = Guid.Empty;
    }
}
