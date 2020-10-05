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
                userDto.IsSuccess = false;
                return userDto;
            }

            // if password not correct; return false
            if (user.Password != userDto.Password) {
                userDto.Password = string.Empty;
                userDto.IsSuccess = false;
                return userDto;
            }

            // if correct; return new token
            userDto.FirstName = user.FirstName;
            userDto.LastName = user.LastName;
            userDto.Password = string.Empty;
            userDto.Token = Guid.NewGuid().ToString();
            userDto.IsSuccess = true;
            return userDto;
        }

        public UserDTO Register(UserDTO userDto)
        {
            
            bool dataComplete = true;

            if (string.IsNullOrWhiteSpace(userDto.FirstName)) {
                userDto.Password = string.Empty;
                userDto.Messages.Add("First Name shouldnt be empty");
                dataComplete = false;
            }

            if (string.IsNullOrWhiteSpace(userDto.LastName)){
                userDto.Password = string.Empty;
                userDto.Messages.Add("Last Name shouldnt be empty");
                dataComplete = false;
            }

            if (string.IsNullOrWhiteSpace(userDto.Email)){
                userDto.Password = string.Empty;
                userDto.Messages.Add("Email shouldnt be empty");
                dataComplete = false;
            }

            if (string.IsNullOrWhiteSpace(userDto.Password)){
                userDto.Password = string.Empty;
                userDto.Messages.Add("Password shouldnt be empty");
                dataComplete = false;
            }

            if (userDto.Dob == null){
                userDto.Password = string.Empty;
                userDto.Messages.Add("Date of Birth shouldnt be empty");
                dataComplete = false;
            }

            if (string.IsNullOrWhiteSpace(userDto.PhoneNumber)){
                userDto.Password = string.Empty;
                userDto.Messages.Add("Phone Number shouldnt be empty");
                dataComplete = false;
            }

            
            // Makes sure that all if cases pass
            if (!dataComplete)
            {
                userDto.IsSuccess = false;
                return userDto;
            }

            var userEmail = _repository.GetUser().WithEmail(userDto.Email);
            if (userEmail != null)
            {
                userDto.IsSuccess = false;
                userDto.Messages.Add("You already have this email signed up");
                return userDto;
            }

            // Convert DTO to entity, call save user from the repository (save the data Check previous work)
            // if correct, save the user details
            var user = new User() {
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                Email = userDto.Email,
                Password = userDto.Password,
                Dob = userDto.Dob,
                PhoneNumber = userDto.PhoneNumber,
                LoyaltyMemberNumber = userDto.LoyaltyMemberNumber,
            };

            _repository.PostUser(user);
            userDto.UserId = user.UserId;
            userDto.IsSuccess = true;
            userDto.Messages.Add("User has registered successfully");
            return userDto;
        }
    }
}
