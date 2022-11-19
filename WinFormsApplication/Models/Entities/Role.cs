using System;
using System.Collections.Generic;

namespace WinFormsApplication.Models.Entities;

public partial class Role
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<User> Users { get; } = new List<User>();
}
