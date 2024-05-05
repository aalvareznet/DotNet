using System;
using System.Collections.Generic;

namespace Memberships.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? PasswordHash { get; set; }
}
