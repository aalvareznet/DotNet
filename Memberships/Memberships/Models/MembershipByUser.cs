using System;
using System.Collections.Generic;

namespace Memberships.Models;

public partial class MembershipByUser
{
    public int? UserId { get; set; }

    public int? MembershipId { get; set; }

    public int? MembershipStatusId { get; set; }

    public virtual Membership? Membership { get; set; }

    public virtual MembershipStatus? MembershipStatus { get; set; }

    public virtual User? User { get; set; }
}
