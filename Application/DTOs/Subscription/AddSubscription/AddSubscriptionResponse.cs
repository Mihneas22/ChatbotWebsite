using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Subscription.AddSubscription
{
    public record AddSubscriptionResponse(bool Flag, string message = null!);
}
