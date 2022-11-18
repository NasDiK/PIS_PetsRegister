using System;
using System.Collections.Generic;

namespace WinFormsApplication;

public partial class Settlement
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Advertisment> Advertisments { get; } = new List<Advertisment>();
}
