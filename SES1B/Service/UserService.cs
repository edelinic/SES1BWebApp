using Microsoft.AspNetCore.Identity;
using SES1B.Interface.Service;
using SES1B.Shared.DTO;
using SES1BBackendAPI.Domain.Entity;
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
            var user = _repository.PostUser().WithEmail(userDto.Email);

            // First Name Shouldnt be empty
            if (userDto.FirstName == null) {
               userDto.Password = string.Empty;
            }
            // Last Name Shouldnt be empty
            if (userDto.LastName == null){
                userDto.Password = string.Empty;
            }

            // Verify Email Format
            if (userDto.Email == null){
                userDto.Password = string.Empty;
            }
            // Password Shouldnt be empty
            if (userDto.Password == null){
                userDto.Password = string.Empty;
            }

            if (userDto.Dob == null){
                userDto.Password = string.Empty;
            }

            if (userDto.PhoneNumber == null){
                userDto.Password = string.Empty;
            }
            // Convert DTO to entity, call save user from the repository (save the data Check previous work)
            // if correct, save the user details

            user.FirstName = userDto.FirstName;
            user.LastName = userDto.LastName;
            user.Password = userDto.Password;
            user.Email = userDto.Email;
            user.Dob = userDto.Dob;
            user.PhoneNumber = userDto.PhoneNumber;
            return userDto;
        }
    }
}
