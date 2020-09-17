using SES1BBackendAPI.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SES1BBackendAPI.Domain.Repository
{
    public static partial class StaffRepositoryExtension
    {
        public static Staff WithStaffId(this IQueryable<Staff> staff, int StaffId)
        {
            return staff.SingleOrDefault(p => p.StaffId == StaffId);
        }
    }
}
