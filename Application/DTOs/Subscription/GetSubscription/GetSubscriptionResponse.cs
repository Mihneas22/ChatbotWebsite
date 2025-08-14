using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Subscription.GetSubscription
{
    public record GetSubscriptionResponse(bool Flag, string message = null!, Domain.Models.Subscription sub = null!);
}
