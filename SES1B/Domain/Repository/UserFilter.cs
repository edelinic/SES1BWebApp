using SES1BBackendAPI.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SES1BBackendAPI.Domain.Repository
{
    public static partial class UserRepositoryExtension
    {
        public static User WithUserId(this IQueryable<User> users, int UserId)
        {
            return users.SingleOrDefault(p => p.UserId == UserId);
        }

        public static User WithEmail(this IQueryable<User> users, string email)
        {
            return users.SingleOrDefault(p => p.Email == email);
        }
    }
}
