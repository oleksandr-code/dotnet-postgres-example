using System;
using System.Collections.Generic;

namespace ExampleSolution.Db.Models
{
    public partial class Account
    {
        public Account()
        {
            AccountRole = new HashSet<AccountRole>();
        }

        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? LastLogin { get; set; }

        public virtual ICollection<AccountRole> AccountRole { get; set; }
    }
}
