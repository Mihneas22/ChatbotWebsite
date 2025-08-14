using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Subscription.AddSubscription
{
    public class AddSubscriptionDTO
    {
        [Required]
        public string Type { get; set; } = string.Empty;

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public int Price { get; set; } = 0;

        [Required]
        public int MessagesMax { get; set; } = 0;

        [Required]
        public Guid? UserId { get; set; } = Guid.Empty;
    }
}
