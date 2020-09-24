using System;
using System.Collections.Generic;

namespace SES1BBackendAPI.Domain.Entity
{
    public partial class Staff
    {
        public Staff()
        {
            InverseManager = new HashSet<Staff>();
        }

        public int StaffId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Role { get; set; }
        public int? ManagerId { get; set; }

        public virtual Staff Manager { get; set; }
        public virtual ICollection<Staff> InverseManager { get; set; }
    }
}
