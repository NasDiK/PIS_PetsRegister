using System;
using System.Collections.Generic;

namespace WinFormsApplication;

public partial class Response
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public long AdvertismentId { get; set; }

    public byte[] IsGeneral { get; set; } = null!;

    public virtual Advertisment Advertisment { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
