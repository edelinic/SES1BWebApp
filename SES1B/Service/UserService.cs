using Microsoft.AspNetCore.Identity;
using SES1B.Interface.Service;
using SES1B.Shared.DTO;
using SES1BBackendAPI.Domain.Repository;
using SES1BBackendAPI.Interface.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SES1BBackendAPI.Service
{
    public class UserService : IUserService
    {
        // Every Service will have this Irepository
        // Automatically injected during runtime and the config of this will be in the startup.cs
        
        IRepository _repository;
        public UserService(IRepository repository)
        {
            _repository = repository;
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public UserDTO Login(UserDTO userDto) 
        {
            // Retrieve the user information from DB
            var user = _repository.GetUser().WithEmail(userDto.Email);

            // Check Email + Password
            // if email not registered; return false
            if (user == null) {
                userDto.Password = string.Empty;
                userDto.IsLoginSuccess = false;
                return userDto;
            }

            // if password not correct; return false
            if (user.Password != userDto.Password) {
                userDto.Password = string.Empty;
                userDto.IsLoginSuccess = false;
                return userDto;
            }

            // if correct; return new token
            userDto.FirstName = user.FirstName;
            userDto.LastName = user.LastName;
            userDto.Password = string.Empty;
            userDto.Token = Guid.NewGuid().ToString();
            userDto.IsLoginSuccess = true;
            return userDto;
        }

        public UserDTO Register(UserDTO userDto)
        {


            // First Name Shouldnt be empty
            if (userDto.FirstName == null) { 
            
            }
            // Last Name Shouldnt be empty
            if (userDto.LastName == null)
            {

            }

            // Verify Email Format
            // Password Shouldnt be empty
            // Convert DTO to entity, call save user from the repository (save the data Check previous work)
            return userDto;
        }
    }
}
