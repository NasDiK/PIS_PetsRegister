using System;
using System.Collections.Generic;

namespace WinFormsApplication.Models.Entities;

public partial class User
{
    public long Id { get; set; }

    public string? Username { get; set; }

    public string Password { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public long RoleId { get; set; }

    public string? PhoneNumber { get; set; }

    public virtual ICollection<Advertisment> Advertisments { get; } = new List<Advertisment>();

    public virtual ICollection<Pet> Pets { get; } = new List<Pet>();

    public virtual Role Role { get; set; } = null!;
}
