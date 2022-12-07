using WinFormsApplication.Models.Entities;
using WinFormsApplication.Services.Database;

namespace WinFormsApplication.Controllers
{
    internal class OwnPetsController
    {
        internal IEnumerable<Pet>? getUserAnimals(long userId) =>
            DatabaseService.getUserAnimals(userId);

        internal bool registerPet(Pet animal)
        {
            //можно присосать валидаторы
            try
            {
                DatabaseService.registerPet(animal);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        internal Pet? getPetById(long animalId) =>
            DatabaseService.getPetById(animalId);
        internal bool updatePet(Pet animal)
        {
            //можно присосать валидаторы
            try
            {
                var pet = this.getPetById(animal.Id);

                if (pet == null)
                    throw new Exception("pet was null");

                pet.PetName = animal.PetName;
                pet.PetBirthDate = animal.PetBirthDate;
                pet.RegisterDate = animal.RegisterDate;
                pet.PetPassportNumber = animal.PetPassportNumber;
                pet.BreedName = animal.BreedName;
                pet.PetSex = animal.PetSex;

                DatabaseService.updatePet(pet);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        internal bool deletePet(long animalId)
        {
            try
            {
                var pet = this.getPetById(animalId);

                if (pet == null)
                    throw new Exception("delete pet was null");

                DatabaseService.deletePet(pet);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
