using Microsoft.EntityFrameworkCore;
using WinFormsApplication.Models.Entities;

namespace WinFormsApplication.Services.Database
{
    internal static class DatabaseService
    {
        static DatabaseContext db = new DatabaseContext();

        #region Users 

        /// <summary>
        /// Возвращает пользователя по логину или номер телефона
        /// </summary>
        /// <param name="login">Логин или номер телефона</param>
        internal static User? getUserByLogin(string login) =>
            db.Users.FirstOrDefault(x => x.Username == login || x.PhoneNumber == login);

        internal static User? RegisterUser(User user)
        {
            db.Users.Add(user); db.SaveChanges();
            return user;
        }

        #endregion

        #region petCategories

        internal static IEnumerable<PetCategory>? getAllPetCategories() =>
            db.PetCategories;
        internal static PetCategory? getPetCategoryById(long id) => 
            db.PetCategories.FirstOrDefault(x => x.Id == id);

        #endregion

        #region Settlements 

        internal static IEnumerable<Settlement>? getAllSettlements() =>
            db.Settlements;

        internal static Settlement? getSettlementById(long id) =>
            db.Settlements.FirstOrDefault(x => x.Id == id);

        #endregion

        #region Roles


        internal static IEnumerable<Role>? getAllRoles() => 
            db.Roles;

        internal static long getRoleIdByName(string roleName) =>
            db.Roles.First((role) => role.Name == roleName).Id;

        #endregion

        #region Advertisments

        internal static void createAdvertisment(Advertisment newAdvertisment)
        {
            db.Advertisments.Add(newAdvertisment); db.SaveChanges();
        }

        internal static IEnumerable<Advertisment>? getAllAdvertisments() =>
            db.Advertisments.Include(u => u.Photographies);

        internal static Advertisment? getAdvertismentById(long Id) =>
            db.Advertisments.FirstOrDefault(ad => ad.Id == Id);

        internal static void UpdateAdvertisment(Advertisment advertisment)
        {
            db.SaveChanges();
        }

        internal static void DeleteAdvertisment(Advertisment advertisment)
        {
            db.Advertisments.Remove(advertisment); db.SaveChanges();
        }

        #endregion

        #region Photographies
        internal static void UploadPhotographies(params Photography[]? photographies)
        {
            db.Photographies.AddRange(photographies);
            db.SaveChanges();
        }

        internal static IEnumerable<Photography>? getPhotographiesFilenames(long? advertID) =>
            db.Photographies.Where((photo) => photo.AdvertismentId == advertID);

        internal static Photography? getPhotographyById(long photoId) =>
            db.Photographies.FirstOrDefault((photo) => photo.Id == photoId);

        internal static void DeletePhotography(Photography photo)
        {
            db.Photographies.Remove(photo); db.SaveChanges();
        }

        #endregion

        #region OwnPets

        internal static IEnumerable<Pet>? getUserAnimals(long userId) =>
            db.Pets.Where((pet) => pet.OwnerId == userId);

        internal static Pet? getPetById(long petId) =>
            db.Pets.FirstOrDefault((pet) => pet.Id == petId);
        internal static void registerPet(Pet animal)
        {
            db.Pets.Add(animal); db.SaveChanges();
        }

        internal static void updatePet(Pet animal)
        {
            db.SaveChanges();
        }

        internal static void deletePet(Pet pet)
        {
            db.Pets.Remove(pet); db.SaveChanges();
        }

        #endregion
    }
}
