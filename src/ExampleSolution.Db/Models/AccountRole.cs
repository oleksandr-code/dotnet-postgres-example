using System;
using System.Collections.Generic;

namespace ExampleSolution.Db.Models
{
    public partial class AccountRole
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public DateTime? GrantDate { get; set; }

        public virtual Role Role { get; set; }
        public virtual Account User { get; set; }
    }
}
