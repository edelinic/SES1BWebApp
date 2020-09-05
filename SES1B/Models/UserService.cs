using System;
using System.Collections.Generic;
using System.Linq;

using SES1B.Controllers;

namespace SES1B.Models
    {
        public interface IUserService
        {
            public interface IUserService
        {
            User Authenticate(string username, string password);
            IEnumerable<User> GetAll();
            User Create(User user, string password);
            void Create(User user, int password);
        }

        public class UserService : IUserService
        {
            private NewAccountContext _context;

            public UserService(NewAccountContext context)
            {
                _context = context;
            }

            public User Authenticate(string username, string password)
            {
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                    return null;

                var user = _context.Users.SingleOrDefault((x) => x.Username == username);

                // check if username exists
                if (user == null)
                    return null;

                // check if password is correct

                if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
                {
                    return null;
                }

                // authentication successful
                return user;
            }

            private bool VerifyPasswordHash(string password, object passwordHash, object passwordSalt)
            {
                throw new NotImplementedException();
            }

            public IEnumerable<User> GetAll()
            {
                yield return (User)_context.Users;
            }

            // private helper methods

            private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
            {
                if (password == null) throw new ArgumentNullException("password");
                if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");

                using (var hmac = new System.Security.Cryptography.HMACSHA512())
                {
                    passwordSalt = hmac.Key;
                    passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                }
            }

            private static bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt)
            {
                if (password == null) throw new ArgumentNullException("password");
                if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");
                if (storedHash.Length != 64) throw new ArgumentException("Invalid length of password hash (64 bytes expected).", "passwordHash");
                if (storedSalt.Length != 128) throw new ArgumentException("Invalid length of password salt (128 bytes expected).", "passwordHash");

                using (var hmac = new System.Security.Cryptography.HMACSHA512(storedSalt))
                {
                    var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                    for (int i = 0; i < computedHash.Length; i++)
                    {
                        if (computedHash[i] != storedHash[i]) return false;
                    }
                }

                return true;
            }

            public void Create(User user, int password)
            {
                throw new NotImplementedException();
            }

            public void Delete(int id)
            {
                throw new NotImplementedException();
            }

            public User GetById(int id)
            {
                throw new NotImplementedException();
            }

            public User Create(User user, string password)
            {
                throw new NotImplementedException();
            }

            public void Update(User user, string password = null)
            {
                throw new NotImplementedException();
            }

            public User Authenticate(string username, string password)
            {
                throw new NotImplementedException();
            }
        }
    }

}
   
