using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Role
    {
        public Guid RoleId { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
        public ICollection<UserAccount> UserAccounts { get; set; }
    }
} 