using System;
using System.Collections.Generic;

namespace WinFormsApplication.Models.Entities;

public partial class Settlement
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Advertisment> Advertisments { get; } = new List<Advertisment>();
}
