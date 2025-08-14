using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.User.GetUserByUsername
{
    public record GetUserByNameResponse(bool Flag, string message = null!, Domain.Models.User user = null!);
}
