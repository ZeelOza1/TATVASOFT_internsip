﻿
using Mission.Entities.Models;

namespace Mission.Services.IServices
{
    public interface IUserService
    {
        Task<UserResponseModel> GetUserById(int id);
        Task<string> DeleteUser(int id);

        Task<UserResponseModel> UpdateUser(int id, UserResponseModel model);
    }

}
