using System;
using System.Collections.Generic;

namespace WinFormsApplication;

public partial class User
{
    public long Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? FullName { get; set; }

    public long RoleId { get; set; }

    public string? PhoneNumber { get; set; }

    public virtual ICollection<Advertisment> Advertisments { get; } = new List<Advertisment>();

    public virtual ICollection<Response> Responses { get; } = new List<Response>();

    public virtual Role Role { get; set; } = null!;
}
