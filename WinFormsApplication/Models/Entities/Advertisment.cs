using System;
using System.Collections.Generic;

namespace WinFormsApplication.Models.Entities;

public partial class Advertisment
{
    public long Id { get; set; }

    public string PetName { get; set; } = null!;

    public string PetBirthDate { get; set; } = null!;

    public long SettlementId { get; set; }

    public long PetCategoryId { get; set; }

    public long PetOwnerId { get; set; }

    public string RegisterDate { get; set; } = null!;

    public string PetPassportNumber { get; set; } = null!;

    public string BreedName { get; set; } = null!;

    public string PetSex { get; set; } = null!;

    public string AdditionalInformation { get; set; } = null!;

    public string CreationDateTime { get; set; } = null!;

    public virtual PetCategory PetCategory { get; set; } = null!;

    public virtual User PetOwner { get; set; } = null!;

    public virtual ICollection<Photography> Photographies { get; } = new List<Photography>();

    public virtual Settlement Settlement { get; set; } = null!;
}
