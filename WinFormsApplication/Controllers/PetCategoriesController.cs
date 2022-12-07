using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApplication.Models.Entities;
using WinFormsApplication.Services.Database;

namespace WinFormsApplication.Controllers
{
    internal class PetCategoriesController
    {
        internal List<PetCategory>? getAllPetCategories() =>
            DatabaseService.getAllPetCategories()?.ToList();

        internal PetCategory? getPetCategoryById(long id) =>
            DatabaseService.getPetCategoryById(id);
    }
}
