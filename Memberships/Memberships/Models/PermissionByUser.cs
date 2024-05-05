﻿using System;
using System.Collections.Generic;

namespace Memberships.Models;

public partial class PermissionByUser
{
    public int? UserId { get; set; }

    public int? PermissionId { get; set; }

    public virtual Permission? Permission { get; set; }

    public virtual User? User { get; set; }
}
