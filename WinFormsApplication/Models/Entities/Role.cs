using System;
using System.Collections.Generic;

namespace WinFormsApplication;

public partial class Role
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<User> Users { get; } = new List<User>();
}
