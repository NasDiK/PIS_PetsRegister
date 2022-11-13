using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApplication.Models.Entities
{
    internal class Advertisment
    {
        public int Id { get; set; }
        public string? PetName { get; set; }
        public DateTime? BirthDate { get; set; } //TODO настроить getset на короткую дату
        public Settlement? Settlement { get; set; } // id ?
        public PetCategory? PetCategory { get; set; } // id ?
        public User? PetOwner { get; set; } // id ?
        public DateTime? RegisterDate { get; set; } //TODO настроить getset на короткую дату
        public string? PetPassportNumber { get; set; } //TODO валидатор
        public string? BreedName { get; set; }
        public string? AdditionalInformation { get; set; }
        public DateTime? CreationDateTime { get; set; }
    }
}
