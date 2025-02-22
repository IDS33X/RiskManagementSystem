﻿using System.Threading.Tasks;
using Util.Dtos.User;
using Util.Support.Requests.User;
using Util.Support.Responses.User;

namespace Service.Service
{
    public interface IUserService
    {
        Task<AddUserResponse> Add(AddUserRequest request);
        Task<UserDto> GetById(int id);
        Task<UsersByDepartmentResponse> GetUsersByDepartment(UsersByDepartmentRequest request);
        Task<UsersByDepartmentSearchResponse> GetUsersByDepartmentAndSearch(UsersByDepartmentSearchRequest request);
        Task<EditUserLoginResponse> UpdatePassword(EditUserLoginRequest request);
        Task<EditUserProfileResponse> UpdateProfile(EditUserProfileRequest request);
    }
}
