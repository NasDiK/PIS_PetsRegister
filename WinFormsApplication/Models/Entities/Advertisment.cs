using System;
using System.Collections.Generic;

namespace WinFormsApplication;

public partial class Advertisment
{
    public long Id { get; set; }

    public string PetName { get; set; } = null!;

    public string? BirthDate { get; set; }

    public long SettlementId { get; set; }

    public long PetCategoryId { get; set; }

    public long PetOwnerId { get; set; }

    public string? RegisterDate { get; set; }

    public string? PetPassportNumber { get; set; }

    public string? BreedName { get; set; }

    public string? AdditionalInformation { get; set; }

    public string CreationDateTime { get; set; } = null!;

    public virtual PetCategory PetCategory { get; set; } = null!;

    public virtual User PetOwner { get; set; } = null!;

    public virtual ICollection<Photography> Photographies { get; } = new List<Photography>();

    public virtual ICollection<Response> Responses { get; } = new List<Response>();

    public virtual Settlement Settlement { get; set; } = null!;
}
