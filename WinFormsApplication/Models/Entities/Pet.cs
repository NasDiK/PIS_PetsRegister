using System;
using System.Collections.Generic;

namespace WinFormsApplication.Models.Entities;

public partial class Pet
{
    public long Id { get; set; }

    public string PetName { get; set; } = null!;

    public string PetBirthDate { get; set; } = null!;

    public string RegisterDate { get; set; } = null!;

    public string PetPassportNumber { get; set; } = null!;

    public string BreedName { get; set; } = null!;

    public string PetSex { get; set; } = null!;

    public long OwnerId { get; set; }

    public virtual User Owner { get; set; } = null!;
}
