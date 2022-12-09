using System;
using System.Collections.Generic;

namespace WinFormsApplication.Models.Entities;

public partial class Photography
{
    public long Id { get; set; }

    public long AdvertismentId { get; set; }

    public string Filepath { get; set; } = null!;

    public string? IsGeneral { get; set; }

    public virtual Advertisment Advertisment { get; set; } = null!;
}
