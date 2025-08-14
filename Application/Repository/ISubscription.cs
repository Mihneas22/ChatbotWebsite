using Application.DTOs.Subscription.AddSubscription;
using Application.DTOs.Subscription.GetSubscription;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository
{
    public interface ISubscription
    {
        Task<AddSubscriptionResponse> AddSubscriptionAsync(AddSubscriptionDTO addSubscriptionDTO);
    
        Task<GetSubscriptionResponse> GetSubscriptionAsync(GetSubscriptionDTO getSubscriptionDTO);
    }
}
