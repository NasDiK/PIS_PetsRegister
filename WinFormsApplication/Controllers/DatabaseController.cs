using WinFormsApplication.Models.Entities;

namespace WinFormsApplication.Controllers
{
    public class DatabaseController
    {
        DatabaseContext db;

        public DatabaseController()
        {
            db = new DatabaseContext();
        }

        #region Users

        /// <summary>
        /// Возвращает пользователя по логину или номер телефона
        /// </summary>
        /// <param name="login">Логин или номер телефона</param>
        internal User? getUserByLogin(string login) =>
            db.Users.FirstOrDefault(x => x.Username == login || x.PhoneNumber == login);

        internal User? RegisterUser(User user)
        {
            db.Users.Add(user); db.SaveChanges();
            return user;
        }

        #endregion

        #region petCategories

        internal List<PetCategory> getAllPetCategories() =>
            db.PetCategories.ToList();
        internal PetCategory? getPetCategoryById(long id) => db.PetCategories.FirstOrDefault(x => x.Id == id);

        #endregion

        #region Settlements

        internal List<Settlement> getAllSettlements() =>
            db.Settlements.ToList();

        internal Settlement? getSettlementById(long id) => db.Settlements.FirstOrDefault(x => x.Id == id);

        #endregion

        #region Roles


        internal List<Role> getAllRoles() => db.Roles.ToList();

        internal long getRoleIdByName(string roleName) =>
            db.Roles.First((role) => role.Name == roleName).Id;

        #endregion

        #region Advertisments

        internal Advertisment? createAdvertisment(Advertisment newAdvertisment)
        {
            try
            {
                db.Advertisments.Add(newAdvertisment); db.SaveChanges();
                return newAdvertisment;
            }
            catch { return null; }
        }

        internal List<Advertisment>? getAllAdvertisments() => db.Advertisments.ToList();

        internal bool UpdateAdvertisment(Advertisment advertisment)
        {
            try
            {
                var advert = db.Advertisments.FirstOrDefault(ad => ad.Id == advertisment.Id);

                if (advert == null)
                    throw new Exception("advert is null");

                advert.PetCategoryId = advertisment.PetCategoryId;
                advert.PetName = advertisment.PetName;
                advert.PetBirthDate = advertisment.PetBirthDate;
                advert.SettlementId = advertisment.SettlementId;
                advert.RegisterDate = advertisment.RegisterDate;
                advert.PetPassportNumber = advertisment.PetPassportNumber;
                advert.BreedName = advertisment.BreedName;
                advert.PetSex = advertisment.PetSex;
                advert.AdditionalInformation = advertisment.AdditionalInformation;

                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        internal bool DeleteAdvertisment(long advertismentId)
        {
            try
            {
                var advert = db.Advertisments.FirstOrDefault(adv => adv.Id == advertismentId);
                if (advert == null)
                    throw new Exception("advert was null");

                db.Advertisments.Remove(advert);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        #endregion

        #region Photographies
        internal void UploadPhotographies(long advertId, IEnumerable<string>? guidFileNames)
        {
            var photographies = guidFileNames?.Select((filename) =>
            {
                return new Photography()
                {
                    AdvertismentId = advertId,
                    Filepath = filename
                };
            });

            db.Photographies.AddRange(photographies);
            db.SaveChanges();
        }

        internal Photography?[] getPhotographiesFilenames(long? advertID)
        {
            return db.Photographies.Where((photo) => photo.AdvertismentId == advertID).ToArray();

        }

        #endregion

        #region OwnPets

        internal IEnumerable<Pet>? getUserAnimals(long userId) =>
            db.Users.Where((user) => user.Id == userId).First().Pets;

        internal bool registerPet(Pet animal)
        {
            try
            {
                db.Pets.Add(animal); db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        internal bool updatePet(Pet animal)
        {
            try
            {
                var pet = db.Pets.Where(pet => pet.Id == animal.Id).First();

                pet.PetName = animal.PetName;
                pet.PetBirthDate = animal.PetBirthDate;
                pet.RegisterDate = animal.RegisterDate;
                pet.PetPassportNumber = animal.PetPassportNumber;
                pet.BreedName = animal.BreedName;
                pet.PetSex = animal.PetSex;

                db.SaveChanges();

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
                var pet = db.Pets.Where(pet => pet.Id == animalId).FirstOrDefault();

                if (pet == null) 
                    throw new Exception("delete pet was null");
                db.Pets.Remove(pet);
                db.SaveChanges();
                
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }


        #endregion
    }
}
