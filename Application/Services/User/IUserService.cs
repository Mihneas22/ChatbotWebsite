using Application.DTOs.User.GetUserByUsername;
using Application.DTOs.User.LoginUser;
using Application.DTOs.User.RegisterUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.User
{
    public interface IUserService
    {
        Task<RegisterUserResponse> RegisterUserService(RegisterUserDTO registerUserDTO);

        Task<LoginUserResponse> LoginUserService(LoginUserDTO loginUserDTO);

        Task<GetUserByNameResponse> GetUserService(GetUserByUsernameDTO getUserByUsernameDTO);
    }
}
