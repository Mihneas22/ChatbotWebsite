using Application.DTOs.User.GetUserByUsername;
using Application.DTOs.User.LoginUser;
using Application.DTOs.User.RegisterUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository
{
    public interface IUser
    {
        Task<RegisterUserResponse> RegisterUserAsync(RegisterUserDTO registerUserDTO);

        Task<LoginUserResponse> LoginUserAsync(LoginUserDTO loginUserDTO);

        Task<GetUserByNameResponse> GetUserAsync(GetUserByUsernameDTO getUserByUsernameDTO);
    }
}
